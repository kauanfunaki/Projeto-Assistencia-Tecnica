using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Design;
using ProjetoAvaliação.Classes.Getters_Setters;

namespace ProjetoAvaliação
{
    public partial class FormProducts : Form
    {
        public FormProducts()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarTema();
        }

        private void CarregarTema()
        {
            foreach (Control btns in panelMain.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }

            TemaLabelSecondaryColor(labelProduct1, labelProduct2, labelProduct3, labelProduct4, labelProduct5, labelProduct6, labelProduct7, labelProduct8);

            TemaLabelPrimaryColor(labelPriceProduct1, labelPriceProduct2, labelPriceProduct3, labelPriceProduct4, labelPriceProduct5, labelPriceProduct6, labelPriceProduct7, labelPriceProduct8);

            Button[] buttonsArray = { buttonBuyProduct1, buttonBuyProduct2, buttonBuyProduct3, buttonBuyProduct4, buttonBuyProduct5, buttonBuyProduct6, buttonBuyProduct7, buttonBuyProduct8 };

            foreach (Button btn in buttonsArray)
            {
                TemaBotao(btn);
            }
        }

        private void TemaLabelPrimaryColor(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = ThemeColor.PrimaryColor;
            }
        }

        private void TemaLabelSecondaryColor(params Label[] labels)
        {
            foreach (Label label in labels)
            {
                label.ForeColor = ThemeColor.SecondaryColor;
            }
        }

        private void TemaBotao(Control btns)
        {
            if (btns.GetType() == typeof(Button))
            {
                Button btn = (Button)btns;

                btn.BackColor = ThemeColor.PrimaryColor;
                btn.ForeColor = Color.White;
                btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
            }
        }
        private void pictureBox9_Click(object sender, EventArgs e)
        {
            FormPurchase purchase = new FormPurchase();
            purchase.GetDetails();
            purchase.ShowDialog();
        }

        private void Comprar(int id)
        {
            DatabaseProdutos conn = new DatabaseProdutos();

            DialogResult result = RJMessageBox.Show("Deseja adicionar este produto ao seu carrinho?",
                    "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (conn.Create(id, UsuarioAtual.usuarioID))
                {
                    RJMessageBox.Show("Seu produto foi adicionado com sucesso!", "Compra",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Não foi possível inserir o produto no carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonBuyProduct1_Click(object sender, EventArgs e)
        {
            Comprar(1);
        }

        private void buttonBuyProduct2_Click(object sender, EventArgs e)
        {
            Comprar(2);
        }

        private void buttonBuyProduct3_Click(object sender, EventArgs e)
        {
            Comprar(3);
        }

        private void buttonBuyProduct4_Click(object sender, EventArgs e)
        {
            Comprar(4);
        }

        private void buttonBuyProduct5_Click(object sender, EventArgs e)
        {
            Comprar(5);
        }

        private void buttonBuyProduct6_Click(object sender, EventArgs e)
        {
            Comprar(6);
        }

        private void buttonBuyProduct7_Click(object sender, EventArgs e)
        {
            Comprar(7);
        }

        private void buttonBuyProduct8_Click(object sender, EventArgs e)
        {
            Comprar(8);
        }
    }
}
