using Microsoft.VisualStudio.OLE.Interop;
using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Getters_Setters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliação
{
    public partial class FormPurchase : Form
    {
        double valorTotal = 0;
        int quantidadeDeLabels = 5;

        public FormPurchase()
        {
            InitializeComponent();
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }

        private void FormPurchase_Load(object sender, EventArgs e)
        {
            AtualizarPrecoTotal();
            PrintarValorTotal();
            InitializeButtonEvents();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ArrastarTela();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void EnviarMensagem(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void InitializeButtonEvents()
        {
            for (int i = 1; i <= 5; i++)
            {
                Button addButton = (Button)Controls.Find("btnAdd" + i, true)[0];
                Button minusButton = (Button)Controls.Find("btnMinus" + i, true)[0];

                addButton.Click += AdicionarQuantidade;
                minusButton.Click += RemoverQuantidade;
            }
        }

        private void PrintarValorTotal()
        {
            lblPrecoTotal.Text = "Total: R$ " + valorTotal.ToString("F2");
        }

        private void LabelProduto_TextChanged(object sender, EventArgs e)
        {
            double novoValorProduto = 0;

            if (double.TryParse(((Label)sender).Text, out novoValorProduto))
            {
                valorTotal += novoValorProduto;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string textoLabel = lblQuantidade1.Text;
            int.TryParse(textoLabel, out int valor);
            valor += 1;
            lblQuantidade1.Text = valor.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string textoLabel = lblQuantidade1.Text;
            int.TryParse(textoLabel, out int valor);
            if (valor != 1)
            {
                valor -= 1;
                lblQuantidade1.Text = valor.ToString();
            }
            else
            {
                MessageBox.Show("Não foi possível diminuir a quantidade, caso queira remover use o botão", "Falha",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public byte[] convertToPictureBox(int ID_Produto)
        {
            string connectionString = Database.GetConexao();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT URL_img FROM produtos WHERE id = @ID_Produto";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@id", ID_Produto);

                string urlDaImagem = command.ExecuteScalar() as string;

                if (urlDaImagem != null)
                {
                    using (WebClient client = new WebClient())
                    {
                        try
                        {
                            byte[] imagemBytes = client.DownloadData(urlDaImagem);

                            return imagemBytes;
                        }
                        catch (WebException)
                        {
                            return null;
                        }
                    }
                }
                else
                {
                    return null;
                }
            }
        }

        /*private void getImage(int ID_Produto)
        {
            byte[] imagemBytes = convertToPictureBox(ID_Produto);

            if (imagemBytes != null)
            {
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    Image imagem = Image.FromStream(ms);

                    pictureBox1.Image = imagem;


                    pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
                }
            }
            else
            {
                pictureBox1.Image = null;
                pictureBox1.SizeMode = PictureBoxSizeMode.Normal;
            }
        }*/

        public bool GetDetails()
        {
            string connectionString = Database.GetConexao();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string query = "SELECT c.id, p.nome, p.descricao, c.quantidade, c.preco_total FROM carrinho c " +
                    "JOIN produtos p ON c.produto_id = p.id " +
                    "WHERE c.cliente_id = @usuario_id AND c.produto_id IS NOT NULL " +
                    "UNION ALL " +
                    "SELECT c.id, s.nome, s.descricao, c.quantidade, c.preco_total " +
                    "FROM carrinho c " +
                    "JOIN servicos s ON c.servico_id = s.id " +
                    "WHERE c.cliente_id = @usuario_id AND c.servico_id IS NOT NULL " +
                    "ORDER BY c.id ASC;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@usuario_id", UsuarioAtual.usuarioID);

                SqlDataReader reader = command.ExecuteReader();

                int labelIndex = 1;

                while (reader.Read())
                {
                    Panel panelLabels = tableLayoutPanel1.Controls.Find("panel" + labelIndex, true).FirstOrDefault() as Panel;

                    if (panelLabels != null)
                    {
                        Label lblNome = panelLabels.Controls.Find("lblNome" + labelIndex, true).FirstOrDefault() as Label;
                        Label lblDescricao = panelLabels.Controls.Find("lblDescricao" + labelIndex, true).FirstOrDefault() as Label;
                        Label lblQuantidade = panelLabels.Controls.Find("lblQuantidade" + labelIndex, true).FirstOrDefault() as Label;
                        Label lblPreco = panelLabels.Controls.Find("lblPreco" + labelIndex, true).FirstOrDefault() as Label;

                        if (lblNome != null && lblDescricao != null && lblQuantidade != null && lblPreco != null)
                        {
                            string nome = reader["nome"].ToString();
                            string descricao = reader["descricao"].ToString();
                            float preco = Convert.ToSingle(reader["preco_total"]);
                            int quantidade = Convert.ToInt32(reader["quantidade"]);

                            lblNome.Text = nome;
                            lblDescricao.Text = descricao;
                            lblQuantidade.Text = quantidade.ToString();
                            lblPreco.Text = "R$ " + preco.ToString();
                        }
                    }

                    labelIndex++;
                }

                reader.Close();

                return true;
            }
            return false;
        }

        public void AtualizarQuantidade(int id, int quantidadeAlterada)
        {
            using (SqlConnection connection = new SqlConnection(Database.GetConexao()))
            {
                try
                {
                    connection.Open();

                    string verificarQuantidadeQuery = "SELECT quantidade FROM carrinho WHERE id = @id";
                    SqlCommand cmdVerificarQuantidade = new SqlCommand(verificarQuantidadeQuery, connection);
                    cmdVerificarQuantidade.Parameters.AddWithValue("@id", id);
                    int quantidadeAtual = (int)cmdVerificarQuantidade.ExecuteScalar();

                    MessageBox.Show(quantidadeAtual.ToString());

                    if (quantidadeAtual + quantidadeAlterada < 0)
                    {
                        MessageBox.Show("Não há estoque suficiente para esta operação.");
                        return;
                    }

                    string atualizarQuantidadeQuery = "UPDATE carrinho SET quantidade = quantidade + @quantidadeAlterada WHERE id = @id";
                    SqlCommand cmdAtualizarQuantidade = new SqlCommand(atualizarQuantidadeQuery, connection);
                    cmdAtualizarQuantidade.Parameters.AddWithValue("@quantidadeAlterada", quantidadeAlterada);
                    cmdAtualizarQuantidade.Parameters.AddWithValue("@id", id);
                    cmdAtualizarQuantidade.ExecuteNonQuery();

                    string buscarQuantidadeAtualizadaQuery = "SELECT quantidade FROM carrinho WHERE id = @id";
                    SqlCommand cmdBuscarQuantidadeAtualizada = new SqlCommand(buscarQuantidadeAtualizadaQuery, connection);
                    cmdBuscarQuantidadeAtualizada.Parameters.AddWithValue("@id", id);
                    int novaQuantidade = (int)cmdBuscarQuantidadeAtualizada.ExecuteScalar();

                    lblQuantidade1.Text = novaQuantidade.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro: " + ex.Message);
                }
            }
        }

        private void AdicionarQuantidade(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = ObterIdDoCarrinho(btn.Name);

            AtualizarQuantidade(id, 1);
            AtualizarPrecoTotal();
        }

        private void RemoverQuantidade(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            int id = ObterIdDoCarrinho(btn.Name);

            AtualizarQuantidade(id, -1);
            AtualizarPrecoTotal();
            PrintarValorTotal();
        }

        private int ObterIdDoCarrinho(string nomeBotao)
        {
            string[] splitString = nomeBotao.Split(new[] { "btnAdd", "btnMinus" }, StringSplitOptions.RemoveEmptyEntries);

            if (splitString.Length == 1 && int.TryParse(splitString[0], out int id))
            {
                return id;
            }
            else
            {
                MessageBox.Show("Não foi possível obter o ID do carrinho a partir do nome do botão.");
                return 0;
            }
        }

        private void AtualizarPrecoTotal()
        {
            for (int i = 1; i <= quantidadeDeLabels; i++)
            {
                // Construindo o nome do label com base no valor de i
                string nomeLabel = "lblPreco" + i;

                // Encontrando o controle (label) com o nome construído
                Control[] foundControls = this.Controls.Find(nomeLabel, true);

                if (foundControls.Length > 0 && foundControls[0] is Label)
                {
                    string textoPreco = ((Label)foundControls[0]).Text;

                    double preco;
                    if (double.TryParse(textoPreco, out preco))
                    {
                        valorTotal += preco;
                    }
                }
            }
        }

        private void btnCloseCart_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panelTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastarTela();
            EnviarMensagem(this.Handle, 0x112, 0xf012, 0);
        }

        private void lblTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ArrastarTela();
            EnviarMensagem(this.Handle, 0x112, 0xf012, 0);
        }

    }
}
