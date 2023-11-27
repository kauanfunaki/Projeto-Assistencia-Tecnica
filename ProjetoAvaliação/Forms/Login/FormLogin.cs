using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static ProjetoAvaliação.Classes.Database.DatabaseClientes;
using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Design;
using ProjetoAvaliação.Classes.Getters_Setters;

namespace ProjetoAvaliação
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tbLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsername.Text.Trim();
            string password = tbPassword.Text.Trim();

            DatabaseClientes conn = new DatabaseClientes();

            UsuarioAtual.usuarioID = conn.Authentication(username, password, 1);
            ErrorAuthentication result = conn.Authentication(username, password);

            switch (result)
            {
                case ErrorAuthentication.UsernameIncorreto:
                    RJMessageBox.Show("Não foi possível encontrar seu nome de usuário!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case ErrorAuthentication.PasswordIncorreto:
                    RJMessageBox.Show("Sua senha está incorreta!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                case ErrorAuthentication.ErroDesconhecido:
                    RJMessageBox.Show("Erro ao autenticar, por favor tente novamente!", "Erro",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;

                default:
                    FormMain main = new FormMain();
                    this.Visible = false;
                    main.Show();
                    break;
            }

            tbUsername.Clear();
            tbPassword.Clear();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            FormCadastro cadastro = new FormCadastro();
            this.Visible = false;
            cadastro.Show();
        }

        private void tbUsername_Click(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;
        }

        private void tbPassword_Click(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;

            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {
            tbUsername.BackColor = Color.White;
            panelUsername.BackColor = Color.White;

            panelPassword.BackColor = SystemColors.Control;
            tbPassword.BackColor = SystemColors.Control;
        }

        private void tbPassword_TextChanged(object sender, EventArgs e)
        {
            tbPassword.BackColor = Color.White;
            panelPassword.BackColor = Color.White;

            tbUsername.BackColor = SystemColors.Control;
            panelUsername.BackColor = SystemColors.Control;
        }

        private void pbPassword_MouseDown(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = false;
        }

        private void pbPassword_MouseUp(object sender, MouseEventArgs e)
        {
            tbPassword.UseSystemPasswordChar = true;
        }
    }
}
