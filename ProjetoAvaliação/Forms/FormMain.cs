using System.Data.SqlClient;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Security.Policy;
using System.Windows.Forms;
using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Design;

namespace ProjetoAvaliação
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMain()
        {
            InitializeComponent();
            random = new Random();
            btnCloseChildForm.Visible = false;
            this.Text = string.Empty;
            this.ControlBox = false;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            ArrastarTela();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ArrastarTela();

        [DllImport("user32.dll", EntryPoint = "SendMessage")]
        private extern static void EnviarMensagem(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private Color SelecionarCor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);

            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }

            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }

        private void AtivarBotao(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DesabilitarBotao();
                    Color color = SelecionarCor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.MudarBrilho(color, -0.5);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.MudarBrilho(color, -0.5);
                    btnCloseChildForm.Visible = true;
                }
            }
        }

        private void DesabilitarBotao()
        {
            foreach (Control previousBtn in panelMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }

        private void AbrirChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            AtivarBotao(btnSender);

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();

            lblTitle.Text = childForm.Text;
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormProducts(), sender);
        }

        private void btnServices_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormServices(), sender);
        }

        private void btnSAC_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormSAC(), sender);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormAbout(), sender);
        }

        private void btnAccount_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormAccount(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            if (activeForm != null)
            {
                activeForm.Close();
                Reset();
            }
        }

        private void Reset()
        {
            DesabilitarBotao();
            lblTitle.Text = "HOME";
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelLogo.BackColor = Color.FromArgb(39, 39, 58);
            currentButton = null;
            btnCloseChildForm.Visible = false;
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panelDesktopPane_Paint(object sender, PaintEventArgs e)
        {

        }
        private void HabilitarTriggerCalcularPrecoTotal()
        {
            string connectionString = Database.GetConexao();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    string query = @"
                        CREATE TRIGGER calcular_preco_total
                        ON carrinho
                        AFTER INSERT, UPDATE
                        AS
                        BEGIN
                            -- Atualizar preco_total para novos registros inseridos
                            UPDATE carrinho
                            SET preco_total = (p.preco * i.quantidade)
                            FROM carrinho c
                            JOIN inserted i ON c.id = i.id
                            LEFT JOIN produtos p ON i.produto_id = p.id
                            WHERE i.produto_id IS NOT NULL;

                            -- Atualizar preco_total para registros atualizados
                            UPDATE carrinho
                            SET preco_total = (s.preco * i.quantidade)
                            FROM carrinho c
                            JOIN inserted i ON c.id = i.id
                            LEFT JOIN servicos s ON i.servico_id = s.id
                            WHERE i.servico_id IS NOT NULL;
                        END;
                    ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void HabilitarTriggerAtualizacaoEstoque()
        {
            string connectionString = Database.GetConexao();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // Execute o comando SQL para criar ou habilitar a trigger 'att'
                    string query = @"
                        CREATE OR ALTER TRIGGER att ON carrinho 
                        AFTER INSERT
                        AS
                        BEGIN
                            -- Atualização para produtos
                            UPDATE produtos 
                            SET quantidade = produtos.quantidade - inserted.quantidade
                            FROM produtos 
                            INNER JOIN inserted ON inserted.produto_id = produtos.id
                            WHERE produtos.id = inserted.produto_id
                            AND inserted.servico_id IS NULL; -- Verifica se é um produto, não um serviço

                            UPDATE produtos 
                            SET situacao = 'inativo' 
                            WHERE quantidade < 1;

                            -- Atualização para serviços
                            UPDATE servicos 
                            SET situacao = 'inativo' 
                            FROM servicos 
                            INNER JOIN inserted ON inserted.servico_id = servicos.id
                            WHERE servicos.id = inserted.servico_id
                            AND inserted.produto_id IS NULL; -- Verifica se é um serviço, não um produto
                        END;
                    ";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                }
                finally
                {
                    connection.Close();
                }
            }
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            HabilitarTriggerCalcularPrecoTotal();
            HabilitarTriggerAtualizacaoEstoque();
        }
    }
}