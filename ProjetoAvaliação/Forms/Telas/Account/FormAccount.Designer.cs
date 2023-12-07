namespace ProjetoAvaliação
{
    partial class FormAccount
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAccount));
            tableLayoutPanel2 = new TableLayoutPanel();
            button3 = new Button();
            btnSair = new Button();
            btnPedidos = new Button();
            btnCompleteCadastro = new Button();
            panelMain = new Panel();
            pictureBox1 = new PictureBox();
            lblUsuario = new Label();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.Controls.Add(button3, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSair, 0, 3);
            tableLayoutPanel2.Controls.Add(btnPedidos, 0, 2);
            tableLayoutPanel2.Controls.Add(btnCompleteCadastro, 0, 1);
            tableLayoutPanel2.Dock = DockStyle.Left;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 4;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(245, 500);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.None;
            button3.AutoSize = true;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(30, 47);
            button3.Name = "button3";
            button3.Size = new Size(184, 31);
            button3.TabIndex = 3;
            button3.Text = "?";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            btnSair.Anchor = AnchorStyles.None;
            btnSair.AutoSize = true;
            btnSair.FlatAppearance.BorderSize = 0;
            btnSair.FlatStyle = FlatStyle.Flat;
            btnSair.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnSair.Location = new Point(30, 422);
            btnSair.Name = "btnSair";
            btnSair.Size = new Size(184, 31);
            btnSair.TabIndex = 1;
            btnSair.Text = "Sair";
            btnSair.UseVisualStyleBackColor = true;
            btnSair.Click += btnSair_Click;
            // 
            // btnPedidos
            // 
            btnPedidos.Anchor = AnchorStyles.None;
            btnPedidos.AutoSize = true;
            btnPedidos.FlatAppearance.BorderSize = 0;
            btnPedidos.FlatStyle = FlatStyle.Flat;
            btnPedidos.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnPedidos.Location = new Point(30, 297);
            btnPedidos.Name = "btnPedidos";
            btnPedidos.Size = new Size(184, 31);
            btnPedidos.TabIndex = 2;
            btnPedidos.Text = "Meus Pedidos";
            btnPedidos.UseVisualStyleBackColor = true;
            // 
            // btnCompleteCadastro
            // 
            btnCompleteCadastro.Anchor = AnchorStyles.None;
            btnCompleteCadastro.AutoSize = true;
            btnCompleteCadastro.FlatAppearance.BorderSize = 0;
            btnCompleteCadastro.FlatStyle = FlatStyle.Flat;
            btnCompleteCadastro.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            btnCompleteCadastro.Location = new Point(30, 172);
            btnCompleteCadastro.Name = "btnCompleteCadastro";
            btnCompleteCadastro.Size = new Size(184, 31);
            btnCompleteCadastro.TabIndex = 0;
            btnCompleteCadastro.Text = "Atualizar Cadastro";
            btnCompleteCadastro.UseVisualStyleBackColor = true;
            btnCompleteCadastro.Click += btnCompleteCadastro_Click;
            // 
            // panelMain
            // 
            panelMain.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            panelMain.Location = new Point(331, 62);
            panelMain.Name = "panelMain";
            panelMain.Size = new Size(619, 439);
            panelMain.TabIndex = 3;
            // 
            // pictureBox1
            // 
            pictureBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(898, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(40, 40);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // lblUsuario
            // 
            lblUsuario.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point);
            lblUsuario.Location = new Point(815, 20);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(77, 25);
            lblUsuario.TabIndex = 4;
            lblUsuario.Text = "Usuario";
            // 
            // FormAccount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(934, 462);
            Controls.Add(lblUsuario);
            Controls.Add(pictureBox1);
            Controls.Add(panelMain);
            Controls.Add(tableLayoutPanel2);
            FormBorderStyle = FormBorderStyle.None;
            MinimumSize = new Size(950, 500);
            Name = "FormAccount";
            Text = "MINHA CONTA";
            Load += FormAccount_Load;
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TableLayoutPanel tableLayoutPanel2;
        private Button btnCompleteCadastro;
        private Panel panelMain;
        private Button button3;
        private Button btnSair;
        private Button btnPedidos;
        private PictureBox pictureBox1;
        private Label lblUsuario;
    }
}