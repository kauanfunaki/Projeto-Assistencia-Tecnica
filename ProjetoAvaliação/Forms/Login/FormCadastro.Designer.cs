namespace ProjetoAvaliação
{
    partial class FormCadastro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCadastro));
            panel2 = new Panel();
            btnReturn = new Button();
            panelEmail = new Panel();
            tbEmail = new TextBox();
            pbEmail = new PictureBox();
            panelConfirmPassword = new Panel();
            tbConfirmPassword = new TextBox();
            pbConfirmPassword = new PictureBox();
            linkEmail = new LinkLabel();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            btnCadastrar = new Button();
            panelPassword = new Panel();
            tbPassword = new TextBox();
            pbPassword = new PictureBox();
            panelUsername = new Panel();
            tbUsername = new TextBox();
            pbUsername = new PictureBox();
            label5 = new Label();
            btnClose = new Button();
            panel1 = new Panel();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel2.SuspendLayout();
            panelEmail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmail).BeginInit();
            panelConfirmPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).BeginInit();
            panelPassword.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).BeginInit();
            panelUsername.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsername).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(btnReturn);
            panel2.Controls.Add(panelEmail);
            panel2.Controls.Add(panelConfirmPassword);
            panel2.Controls.Add(linkEmail);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(btnCadastrar);
            panel2.Controls.Add(panelPassword);
            panel2.Controls.Add(panelUsername);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(btnClose);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(300, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(450, 530);
            panel2.TabIndex = 3;
            // 
            // btnReturn
            // 
            btnReturn.Cursor = Cursors.Hand;
            btnReturn.FlatAppearance.BorderSize = 0;
            btnReturn.FlatStyle = FlatStyle.Flat;
            btnReturn.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnReturn.ForeColor = Color.FromArgb(41, 128, 185);
            btnReturn.Image = (Image)resources.GetObject("btnReturn.Image");
            btnReturn.Location = new Point(-1, 0);
            btnReturn.Name = "btnReturn";
            btnReturn.Size = new Size(40, 40);
            btnReturn.TabIndex = 16;
            btnReturn.TabStop = false;
            btnReturn.UseVisualStyleBackColor = true;
            btnReturn.Click += btnReturn_Click;
            // 
            // panelEmail
            // 
            panelEmail.BackColor = SystemColors.Control;
            panelEmail.Controls.Add(tbEmail);
            panelEmail.Controls.Add(pbEmail);
            panelEmail.Location = new Point(0, 304);
            panelEmail.Name = "panelEmail";
            panelEmail.Size = new Size(450, 45);
            panelEmail.TabIndex = 15;
            // 
            // tbEmail
            // 
            tbEmail.BackColor = SystemColors.Control;
            tbEmail.BorderStyle = BorderStyle.None;
            tbEmail.Cursor = Cursors.IBeam;
            tbEmail.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbEmail.ForeColor = Color.FromArgb(41, 128, 185);
            tbEmail.Location = new Point(55, 13);
            tbEmail.Name = "tbEmail";
            tbEmail.PlaceholderText = "Email";
            tbEmail.Size = new Size(370, 17);
            tbEmail.TabIndex = 4;
            tbEmail.Click += tbEmail_Click;
            tbEmail.TextChanged += tbEmail_TextChanged;
            // 
            // pbEmail
            // 
            pbEmail.Image = (Image)resources.GetObject("pbEmail.Image");
            pbEmail.Location = new Point(15, 11);
            pbEmail.Name = "pbEmail";
            pbEmail.Size = new Size(24, 24);
            pbEmail.SizeMode = PictureBoxSizeMode.Zoom;
            pbEmail.TabIndex = 6;
            pbEmail.TabStop = false;
            // 
            // panelConfirmPassword
            // 
            panelConfirmPassword.BackColor = SystemColors.Control;
            panelConfirmPassword.Controls.Add(tbConfirmPassword);
            panelConfirmPassword.Controls.Add(pbConfirmPassword);
            panelConfirmPassword.Location = new Point(0, 253);
            panelConfirmPassword.Name = "panelConfirmPassword";
            panelConfirmPassword.Size = new Size(450, 45);
            panelConfirmPassword.TabIndex = 14;
            // 
            // tbConfirmPassword
            // 
            tbConfirmPassword.BackColor = SystemColors.Control;
            tbConfirmPassword.BorderStyle = BorderStyle.None;
            tbConfirmPassword.Cursor = Cursors.IBeam;
            tbConfirmPassword.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbConfirmPassword.ForeColor = Color.FromArgb(41, 128, 185);
            tbConfirmPassword.Location = new Point(55, 13);
            tbConfirmPassword.Name = "tbConfirmPassword";
            tbConfirmPassword.PlaceholderText = "Confime a senha";
            tbConfirmPassword.Size = new Size(370, 17);
            tbConfirmPassword.TabIndex = 3;
            tbConfirmPassword.UseSystemPasswordChar = true;
            tbConfirmPassword.Click += tbConfirmPassword_Click;
            tbConfirmPassword.TextChanged += tbConfirmPassword_TextChanged;
            // 
            // pbConfirmPassword
            // 
            pbConfirmPassword.Image = (Image)resources.GetObject("pbConfirmPassword.Image");
            pbConfirmPassword.Location = new Point(15, 11);
            pbConfirmPassword.Name = "pbConfirmPassword";
            pbConfirmPassword.Size = new Size(24, 24);
            pbConfirmPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbConfirmPassword.TabIndex = 6;
            pbConfirmPassword.TabStop = false;
            pbConfirmPassword.MouseDown += pbConfirmPassword_MouseDown;
            pbConfirmPassword.MouseUp += pbConfirmPassword_MouseUp;
            // 
            // linkEmail
            // 
            linkEmail.AutoSize = true;
            linkEmail.LinkColor = Color.FromArgb(41, 128, 185);
            linkEmail.Location = new Point(191, 488);
            linkEmail.Name = "linkEmail";
            linkEmail.Size = new Size(118, 15);
            linkEmail.TabIndex = 6;
            linkEmail.TabStop = true;
            linkEmail.Text = "kauanfu@gmail.com";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label8.ForeColor = Color.Silver;
            label8.Location = new Point(64, 488);
            label8.Name = "label8";
            label8.Size = new Size(129, 15);
            label8.TabIndex = 0;
            label8.Text = "Envie um email para:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label7.ForeColor = Color.Silver;
            label7.Location = new Point(64, 473);
            label7.Name = "label7";
            label7.Size = new Size(332, 15);
            label7.TabIndex = 11;
            label7.Text = "Para ter acesso a esse app ou quaisquer outras dúvidas";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label6.ForeColor = Color.Silver;
            label6.Location = new Point(64, 458);
            label6.Name = "label6";
            label6.Size = new Size(57, 15);
            label6.TabIndex = 10;
            label6.Text = "Suporte:";
            // 
            // btnCadastrar
            // 
            btnCadastrar.BackColor = Color.FromArgb(41, 128, 185);
            btnCadastrar.Cursor = Cursors.Hand;
            btnCadastrar.FlatStyle = FlatStyle.Flat;
            btnCadastrar.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            btnCadastrar.ForeColor = Color.White;
            btnCadastrar.Location = new Point(15, 374);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(148, 35);
            btnCadastrar.TabIndex = 5;
            btnCadastrar.Text = "CADASTRAR";
            btnCadastrar.UseVisualStyleBackColor = false;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // panelPassword
            // 
            panelPassword.BackColor = SystemColors.Control;
            panelPassword.Controls.Add(tbPassword);
            panelPassword.Controls.Add(pbPassword);
            panelPassword.Location = new Point(0, 202);
            panelPassword.Name = "panelPassword";
            panelPassword.Size = new Size(450, 45);
            panelPassword.TabIndex = 7;
            // 
            // tbPassword
            // 
            tbPassword.BackColor = SystemColors.Control;
            tbPassword.BorderStyle = BorderStyle.None;
            tbPassword.Cursor = Cursors.IBeam;
            tbPassword.Font = new Font("Montserrat", 10F, FontStyle.Regular, GraphicsUnit.Point);
            tbPassword.ForeColor = Color.FromArgb(41, 128, 185);
            tbPassword.Location = new Point(55, 11);
            tbPassword.Name = "tbPassword";
            tbPassword.PlaceholderText = "Senha";
            tbPassword.Size = new Size(370, 17);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            tbPassword.Click += tbPassword_Click;
            tbPassword.TextChanged += tbPassword_TextChanged;
            // 
            // pbPassword
            // 
            pbPassword.Image = (Image)resources.GetObject("pbPassword.Image");
            pbPassword.Location = new Point(15, 11);
            pbPassword.Name = "pbPassword";
            pbPassword.Size = new Size(24, 24);
            pbPassword.SizeMode = PictureBoxSizeMode.Zoom;
            pbPassword.TabIndex = 6;
            pbPassword.TabStop = false;
            pbPassword.MouseDown += pbPassword_MouseDown;
            pbPassword.MouseUp += pbPassword_MouseUp;
            // 
            // panelUsername
            // 
            panelUsername.BackColor = Color.White;
            panelUsername.Controls.Add(tbUsername);
            panelUsername.Controls.Add(pbUsername);
            panelUsername.Location = new Point(0, 151);
            panelUsername.Name = "panelUsername";
            panelUsername.Size = new Size(450, 45);
            panelUsername.TabIndex = 6;
            // 
            // tbUsername
            // 
            tbUsername.BorderStyle = BorderStyle.None;
            tbUsername.Cursor = Cursors.IBeam;
            tbUsername.Font = new Font("Montserrat", 12F, FontStyle.Regular, GraphicsUnit.Point);
            tbUsername.ForeColor = Color.FromArgb(41, 128, 185);
            tbUsername.Location = new Point(55, 11);
            tbUsername.Name = "tbUsername";
            tbUsername.PlaceholderText = "Username";
            tbUsername.Size = new Size(370, 20);
            tbUsername.TabIndex = 1;
            tbUsername.Click += tbUsername_Click;
            tbUsername.TextChanged += tbUsername_TextChanged;
            // 
            // pbUsername
            // 
            pbUsername.Image = (Image)resources.GetObject("pbUsername.Image");
            pbUsername.Location = new Point(15, 11);
            pbUsername.Name = "pbUsername";
            pbUsername.Size = new Size(24, 24);
            pbUsername.SizeMode = PictureBoxSizeMode.Zoom;
            pbUsername.TabIndex = 5;
            pbUsername.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(41, 128, 185);
            label5.Location = new Point(38, 101);
            label5.Name = "label5";
            label5.Size = new Size(214, 29);
            label5.TabIndex = 5;
            label5.Text = "Cadastre sua conta";
            // 
            // btnClose
            // 
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Montserrat SemiBold", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.FromArgb(41, 128, 185);
            btnClose.Location = new Point(410, 0);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(40, 40);
            btnClose.TabIndex = 0;
            btnClose.TabStop = false;
            btnClose.Text = "X";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(41, 128, 185);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(300, 530);
            panel1.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Montserrat", 8F, FontStyle.Regular, GraphicsUnit.Point);
            label4.ForeColor = Color.White;
            label4.Location = new Point(192, 473);
            label4.Name = "label4";
            label4.Size = new Size(81, 15);
            label4.TabIndex = 4;
            label4.Text = "Kauan Funaki";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Montserrat", 8F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.White;
            label3.Location = new Point(164, 458);
            label3.Name = "label3";
            label3.Size = new Size(109, 15);
            label3.TabIndex = 3;
            label3.Text = "Desenvolvido por";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.ForeColor = Color.White;
            label2.Location = new Point(58, 237);
            label2.Name = "label2";
            label2.Size = new Size(205, 29);
            label2.TabIndex = 2;
            label2.Text = "Projeto ___________";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Montserrat", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.White;
            label1.Location = new Point(107, 204);
            label1.Name = "label1";
            label1.Size = new Size(161, 29);
            label1.TabIndex = 1;
            label1.Text = "Bem-vindo ao";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(29, 28);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(234, 65);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // FormCadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(750, 530);
            ControlBox = false;
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormCadastro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormCadastro";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panelEmail.ResumeLayout(false);
            panelEmail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbEmail).EndInit();
            panelConfirmPassword.ResumeLayout(false);
            panelConfirmPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbConfirmPassword).EndInit();
            panelPassword.ResumeLayout(false);
            panelPassword.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbPassword).EndInit();
            panelUsername.ResumeLayout(false);
            panelUsername.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbUsername).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private LinkLabel linkEmail;
        private Label label8;
        private Label label7;
        private Label label6;
        private Button btnCadastrar;
        private Panel panelPassword;
        private TextBox tbPassword;
        private PictureBox pbPassword;
        private Panel panelUsername;
        private TextBox tbUsername;
        private PictureBox pbUsername;
        private Label label5;
        private Button btnClose;
        private Panel panel1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private Panel panelEmail;
        private TextBox tbEmail;
        private PictureBox pbEmail;
        private Panel panelConfirmPassword;
        private TextBox tbConfirmPassword;
        private PictureBox pbConfirmPassword;
        private Button btnReturn;
    }
}