using ProjetoAvaliação.Classes.Database;
using ProjetoAvaliação.Classes.Design;
using ProjetoAvaliação.Classes.Getters_Setters;
using ProjetoAvaliação.Forms.Account;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoAvaliação
{
    public partial class FormAccount : Form
    {
        private Form activeForm;
        DatabaseClientes conn = new DatabaseClientes();
        public FormAccount()
        {
            InitializeComponent();
        }

        private void FormAccount_Load(object sender, EventArgs e)
        {
            CarregarTema();
            lblUsuario.Text = conn.GetID(UsuarioAtual.usuarioID);
        }
        private void CarregarTema()
        {
            foreach (Control btns in tableLayoutPanel2.Controls)
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
            lblUsuario.ForeColor = ThemeColor.PrimaryColor;
        }

        private void AbrirChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
            {
                activeForm.Close();
            }

            activeForm = childForm;

            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;

            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;

            childForm.BringToFront();
            childForm.Show();
        }

        private void btnCompleteCadastro_Click(object sender, EventArgs e)
        {
            AbrirChildForm(new FormCompleteCadastro(), sender);
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            FormMain main = (FormMain)this.ParentForm;
            FormLogin login = new FormLogin();

            main.Hide();
            login.Show();
        }
    }
}
