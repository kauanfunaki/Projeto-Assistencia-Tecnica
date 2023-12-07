namespace ProjetoAvaliação.Forms.Telas.Account
{
    partial class FormProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProfile));
            panelTitleBar = new Panel();
            btnCloseCart = new Button();
            lblTitle = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            bttCancelar = new Button();
            bttSalvar = new Button();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnCloseCart);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(376, 80);
            panelTitleBar.TabIndex = 3;
            // 
            // btnCloseCart
            // 
            btnCloseCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseCart.Cursor = Cursors.Hand;
            btnCloseCart.FlatAppearance.BorderSize = 0;
            btnCloseCart.FlatStyle = FlatStyle.Flat;
            btnCloseCart.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseCart.ForeColor = Color.White;
            btnCloseCart.Location = new Point(341, 0);
            btnCloseCart.Name = "btnCloseCart";
            btnCloseCart.Padding = new Padding(7, 0, 0, 0);
            btnCloseCart.Size = new Size(30, 30);
            btnCloseCart.TabIndex = 7;
            btnCloseCart.Text = "O";
            btnCloseCart.UseVisualStyleBackColor = true;
            btnCloseCart.Click += btnCloseCart_Click;
            // 
            // lblTitle
            // 
            lblTitle.Anchor = AnchorStyles.None;
            lblTitle.Font = new Font("Microsoft Sans Serif", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            lblTitle.ForeColor = Color.White;
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(376, 77);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "MEU PERFIL";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(901, 3);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Padding = new Padding(2, 0, 0, 0);
            btnMinimize.Size = new Size(30, 30);
            btnMinimize.TabIndex = 5;
            btnMinimize.Text = "O";
            btnMinimize.UseVisualStyleBackColor = true;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.Cursor = Cursors.Hand;
            btnMaximize.FlatAppearance.BorderSize = 0;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(928, 3);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Padding = new Padding(5, 0, 0, 0);
            btnMaximize.Size = new Size(30, 30);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "O";
            btnMaximize.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.Cursor = Cursors.Hand;
            btnClose.FlatAppearance.BorderSize = 0;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(955, 3);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(7, 0, 0, 0);
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // bttCancelar
            // 
            bttCancelar.Location = new Point(12, 455);
            bttCancelar.Name = "bttCancelar";
            bttCancelar.Size = new Size(84, 37);
            bttCancelar.TabIndex = 4;
            bttCancelar.Text = "Cancelar";
            bttCancelar.UseVisualStyleBackColor = true;
            bttCancelar.Click += bttCancelar_Click;
            // 
            // bttSalvar
            // 
            bttSalvar.Location = new Point(280, 455);
            bttSalvar.Name = "bttSalvar";
            bttSalvar.Size = new Size(84, 37);
            bttSalvar.TabIndex = 5;
            bttSalvar.Text = "Salvar";
            bttSalvar.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(67, 133);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(243, 239);
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Cursor = Cursors.Hand;
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(274, 339);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(36, 33);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // FormProfile
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 504);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(bttSalvar);
            Controls.Add(bttCancelar);
            Controls.Add(panelTitleBar);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormProfile";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormProfile";
            panelTitleBar.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTitleBar;
        private Button btnCloseCart;
        private Label lblTitle;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button bttCancelar;
        private Button bttSalvar;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
    }
}