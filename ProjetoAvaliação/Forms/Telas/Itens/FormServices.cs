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
    public partial class FormServices : Form
    {
        public FormServices()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            CarregarTema();
        }

        private void CarregarTema()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            TemaLabelSecondaryColor(labelServiceTitle1, labelServiceTitle2, labelServiceTitle3, labelServiceTitle4, labelServiceTitle5, labelServiceTitle6, labelServiceTitle7, labelServiceTitle8);

            TemaLabelPrimaryColor(labelServicePrice1, labelServicePrice2, labelServicePrice3, labelServicePrice4, labelServicePrice5, labelServicePrice6, labelServicePrice7, labelServicePrice8);

            Button[] buttonsArray = { buttonServiceBuy1, buttonServiceBuy2, buttonServiceBuy3, buttonServiceBuy4, buttonServiceBuy5, buttonServiceBuy6, buttonServiceBuy7, buttonServiceBuy8 };

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

        private void Comprar(int id)
        {
            DatabaseServicos conn = new DatabaseServicos();

            DialogResult result = RJMessageBox.Show("Deseja adicionar este serviço ao seu carrinho?",
                    "Compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (conn.Create(1, UsuarioAtual.usuarioID))
                {
                    RJMessageBox.Show("Seu serviço foi adicionado com sucesso!", "Compra",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Não foi possível inserir o serviço no carrinho.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void buttonServiceBuy1_Click(object sender, EventArgs e)
        {
            Comprar(1);
        }

        private void buttonServiceBuy2_Click(object sender, EventArgs e)
        {
            Comprar(2);
        }

        private void buttonServiceBuy3_Click(object sender, EventArgs e)
        {
            Comprar(3);
        }

        private void buttonServiceBuy4_Click(object sender, EventArgs e)
        {
            Comprar(4);
        }

        private void buttonServiceBuy5_Click(object sender, EventArgs e)
        {
            Comprar(5);
        }

        private void buttonServiceBuy6_Click(object sender, EventArgs e)
        {
            Comprar(6);
        }

        private void buttonServiceBuy7_Click(object sender, EventArgs e)
        {
            Comprar(7);
        }

        private void buttonServiceBuy8_Click(object sender, EventArgs e)
        {
            Comprar(8);
        }
    }
}
