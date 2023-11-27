using ProjetoAvaliação.Classes.Design;
using ProjetoAvaliação.UC_s;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliação
{
    public partial class FormSAC : Form
    {
        UC_DuvidasFrequentes duvidasFrequentes = new UC_DuvidasFrequentes();
        UC_Cadastro cadastro = new UC_Cadastro();
        UC_Entrega entrega = new UC_Entrega();
        UC_PedidosPagamentos pedidosPagamentos = new UC_PedidosPagamentos();
        UC_TrocaDevolucao trocaDevolucao = new UC_TrocaDevolucao();

        public FormSAC()
        {
            InitializeComponent();
            duvidasFrequentes.BringToFront();
            duvidasFrequentes.Show();
        }

        private void buttonSAC1_Click(object sender, EventArgs e)
        {
            cadastro.BringToFront();
            cadastro.Show();
        }

        private void buttonSAC2_Click(object sender, EventArgs e)
        {
            trocaDevolucao.BringToFront();
            trocaDevolucao.Show();
        }

        private void buttonSAC3_Click(object sender, EventArgs e)
        {
            entrega.BringToFront();
            entrega.Show();
        }

        private void buttonSAC4_Click(object sender, EventArgs e)
        {
            pedidosPagamentos.BringToFront();
            pedidosPagamentos.Show();
        }

        private void Form3_Load_1(object sender, EventArgs e)
        {
            carregarTema();

            panel1.Visible = true;

            this.panel1.Controls.Add(duvidasFrequentes);
            duvidasFrequentes.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(cadastro);
            cadastro.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(entrega);
            entrega.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(pedidosPagamentos);
            pedidosPagamentos.Dock = DockStyle.Fill;

            this.panel1.Controls.Add(trocaDevolucao);
            trocaDevolucao.Dock = DockStyle.Fill;
        }
        public void carregarTema()
        {
            buttonSAC1.BackColor = ThemeColor.PrimaryColor;
            buttonSAC1.ForeColor = Color.White;
            buttonSAC1.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonSAC2.BackColor = ThemeColor.PrimaryColor;
            buttonSAC2.ForeColor = Color.White;
            buttonSAC2.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonSAC3.BackColor = ThemeColor.PrimaryColor;
            buttonSAC3.ForeColor = Color.White;
            buttonSAC3.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonSAC4.BackColor = ThemeColor.PrimaryColor;
            buttonSAC4.ForeColor = Color.White;
            buttonSAC4.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }
    }
}
