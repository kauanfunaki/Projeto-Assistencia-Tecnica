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

namespace ProjetoAvaliação.Forms.Account
{
    public partial class FormCompleteCadastro : Form
    {
        DatabaseClientes conn = new DatabaseClientes();
        public FormCompleteCadastro()
        {
            InitializeComponent();
        }

        private void FormCompleteCadastro_Load(object sender, EventArgs e)
        {
            CarregarTema();
            CarregarDados();
        }

        private void CarregarTema()
        {
            foreach (Control btns in tableLayoutPanel4.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
            //label1.ForeColor = ThemeColor.SecondaryColor;
            //label2.ForeColor = ThemeColor.PrimaryColor;
        }

        private void CarregarDados()
        {
            int usuarioID = UsuarioAtual.usuarioID; // Obtém o ID do usuário atual

            Cliente cliente = conn.GetClienteByID(usuarioID);

            if (cliente != null)
            {
                tbUsuario.Text = cliente.usuario;
                tbNome.Text = cliente.nome_completo;
                tbCPF.Text = cliente.cpf;
                tbEmail.Text = cliente.email;
                tbFone.Text = cliente.telefone;
                tbCEP.Text = cliente.cep;
                tbRua.Text = cliente.rua;
                tbNumero.Text = cliente.numero.ToString();
                tbBairro.Text = cliente.bairro;
                tbCidade.Text = cliente.cidade;
                tbUF.Text = cliente.estado;
                tbPais.Text = cliente.pais;
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            tbUsuario.Clear();
            tbNome.Clear();
            tbCPF.Clear();
            tbEmail.Clear();
            tbFone.Clear();
            tbCEP.Clear();
            tbRua.Clear();
            tbNumero.Clear();
            tbBairro.Clear();
            tbCidade.Clear();
            tbUF.Clear();
            tbPais.Clear();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            DatabaseClientes conn = new DatabaseClientes();

            DialogResult result = RJMessageBox.Show("Confirma o cadastro de seus dados?",
                    "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (conn.Update(UsuarioAtual.usuarioID, tbUsuario.Text, tbNome.Text, tbCPF.Text, tbEmail.Text, tbFone.Text, tbCEP.Text, tbRua.Text, int.Parse(tbNumero.Text), tbBairro.Text, tbCidade.Text, tbUF.Text, tbPais.Text))
                {
                    RJMessageBox.Show("Seu cadastro foi realizado com sucesso!", "Cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    RJMessageBox.Show("Não foi possível completar seu cadastro.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                this.Close();
            }
        }
    }
}
