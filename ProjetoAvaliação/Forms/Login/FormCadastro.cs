using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Design;

namespace ProjetoAvaliação
{
    public partial class FormCadastro : Form
    {
        public FormCadastro()
        {
            InitializeComponent();
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            this.Visible = false;
            login.Show();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            if (!VerificarBlank())
            {
                if (VerificarSenha())
                {
                    if (!VerificarUsername())
                    {

                        if (VerificarQuantidadeCaracteres(tbUsername, tbPassword, tbEmail, 20, 5))
                        {
                            ConfirmarCadastro();
                        }
                        else
                        {
                            MostrarMensagem($"{VerificarQuantidadeCaracteres(tbUsername, tbPassword, tbEmail, 20, 5, 1)} os requisitos da quantidade de caracteres!", "Aviso");
                        }
                    }
                    else
                    {
                        MostrarMensagem("Caracteres especiais no username não são permitidos!", "Aviso");
                    }
                }
                else
                {
                    MostrarMensagem("As senhas não conferem!", "Aviso");
                }
            }
            else
            {
                MostrarMensagem("Todos os campos devem ser preenchidos!", "Aviso");
            }
        }

        private void MostrarMensagem(string mensagem, string titulo)
        {
            RJMessageBox.Show(mensagem, titulo, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            LimparCampos();
        }

        private void ConfirmarCadastro()
        {
            DatabaseClientes conn = new DatabaseClientes();

            DialogResult result = RJMessageBox.Show("Confirma seu cadastro em nosso aplicativo?",
                    "Cadastro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                if (conn.Create(tbUsername.Text, tbPassword.Text, tbEmail.Text))
                {
                    RJMessageBox.Show("Seu cadastro foi realizado com sucesso!", "Cadastro",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                    FormLogin login = new FormLogin();
                    this.Visible = false;
                    login.Show();
                }
                else
                {
                    RJMessageBox.Show("O nome de usuário e/ou e-mail já existe, tente novamente!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                LimparCampos();
            }
        }

        public void LimparCampos()
        {
            List<TextBox> listaTextBox = new List<TextBox>() { tbUsername, tbPassword, tbConfirmPassword, tbEmail };
            foreach (TextBox t in listaTextBox) { t.Clear(); }
        }

        private bool VerificarBlank()
        {
            List<TextBox> listaTextBox = new List<TextBox>() { tbUsername, tbPassword, tbConfirmPassword, tbEmail };
            foreach (TextBox t in listaTextBox) { if (string.IsNullOrWhiteSpace(t.Text)) return true; }
            return false;
        }

        private bool VerificarUsername()
        {
            Regex regex = new Regex("^[a-zA-Z0-9 ]*$");

            if (!regex.IsMatch(tbUsername.Text))
                return true;
            else
                return false;
        }

        private bool VerificarSenha()
        {
            if (tbPassword.Text == tbConfirmPassword.Text)
                return true;
            else
                return false;
        }

        private bool VerificarQuantidadeCaracteres(TextBox tb, TextBox tb2, TextBox tb3, int maximoCaracteres, int minimoCaracteres)
        {
            List<TextBox> listaTextBox = new List<TextBox>() { tb, tb2, tb3 };
            foreach (TextBox t in listaTextBox) { if (t.Text.Length > maximoCaracteres || t.Text.Length < minimoCaracteres) return false; }
            return true;
        }

        private string VerificarQuantidadeCaracteres(TextBox tb, TextBox tb2, TextBox tb3, int maximoCaracteres, int minimoCaracteres, int aux)
        {
            aux = 0;
            string a = "";

            List<TextBox> listaTextBox = new List<TextBox>() { tb, tb2, tb3 };
            foreach (TextBox t in listaTextBox)
            {
                if (t.Text.Length > maximoCaracteres || t.Text.Length < minimoCaracteres)
                {
                    aux++;
                    a = $"{string.Concat(t.Name.Skip(2))} não cumpre";
                }
            }

            if (aux > 1)
                a = "Os campos não cumprem";

            return a;
        }

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }

        private void pbConfirmPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbConfirmPassword.UseSystemPasswordChar = false;
        }

        private void pbConfirmPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbConfirmPassword.UseSystemPasswordChar = true;
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            panelConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            tbPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;

            panelConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbConfirmPassword_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            tbConfirmPassword.BackColor = Color.White;
            panelConfirmPassword.BackColor = Color.White;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbEmail_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            tbConfirmPassword.BackColor = SystemColors.Control;
            panelConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = Color.White;
            tbEmail.BackColor = Color.White;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            panelConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            tbPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;

            panelConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbConfirmPassword_TextChanged(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            tbConfirmPassword.BackColor = Color.White;
            panelConfirmPassword.BackColor = Color.White;

            panelEmail.BackColor = SystemColors.Control;
            tbEmail.BackColor = SystemColors.Control;
        }

        private void tbEmail_TextChanged(object sender, EventArgs e)
        {
            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;

            tbConfirmPassword.BackColor = SystemColors.Control;
            panelConfirmPassword.BackColor = SystemColors.Control;

            panelEmail.BackColor = Color.White;
            tbEmail.BackColor = Color.White;
        }
    }
}