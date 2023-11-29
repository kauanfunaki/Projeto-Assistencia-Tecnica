namespace ProjetoAvaliação
{
    partial class FormPurchase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPurchase));
            tableLayoutPanel1 = new TableLayoutPanel();
            panelTitleBar = new Panel();
            btnMinimizeCart = new Button();
            btnMaximizeCart = new Button();
            btnCloseCart = new Button();
            lblTitle = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelComprar = new Panel();
            btnComprar = new Button();
            lblPrecoTotal = new Label();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            button2 = new Button();
            button3 = new Button();
            label4 = new Label();
            tableLayoutPanel1.SuspendLayout();
            panelTitleBar.SuspendLayout();
            panelComprar.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel2, 0, 0);
            tableLayoutPanel1.Location = new Point(1, 194);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(851, 514);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panelTitleBar
            // 
            panelTitleBar.BackColor = Color.FromArgb(0, 150, 136);
            panelTitleBar.Controls.Add(btnMinimizeCart);
            panelTitleBar.Controls.Add(btnMaximizeCart);
            panelTitleBar.Controls.Add(btnCloseCart);
            panelTitleBar.Controls.Add(lblTitle);
            panelTitleBar.Controls.Add(btnMinimize);
            panelTitleBar.Controls.Add(btnMaximize);
            panelTitleBar.Controls.Add(btnClose);
            panelTitleBar.Dock = DockStyle.Top;
            panelTitleBar.Location = new Point(0, 0);
            panelTitleBar.Name = "panelTitleBar";
            panelTitleBar.Size = new Size(852, 80);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnMinimizeCart
            // 
            btnMinimizeCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimizeCart.Cursor = Cursors.Hand;
            btnMinimizeCart.FlatAppearance.BorderSize = 0;
            btnMinimizeCart.FlatStyle = FlatStyle.Flat;
            btnMinimizeCart.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimizeCart.ForeColor = Color.White;
            btnMinimizeCart.Location = new Point(734, 0);
            btnMinimizeCart.Name = "btnMinimizeCart";
            btnMinimizeCart.Padding = new Padding(2, 0, 0, 0);
            btnMinimizeCart.Size = new Size(30, 30);
            btnMinimizeCart.TabIndex = 9;
            btnMinimizeCart.Text = "O";
            btnMinimizeCart.UseVisualStyleBackColor = true;
            btnMinimizeCart.Click += btnMinimizeCart_Click;
            // 
            // btnMaximizeCart
            // 
            btnMaximizeCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximizeCart.Cursor = Cursors.Hand;
            btnMaximizeCart.FlatAppearance.BorderSize = 0;
            btnMaximizeCart.FlatStyle = FlatStyle.Flat;
            btnMaximizeCart.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMaximizeCart.ForeColor = Color.White;
            btnMaximizeCart.Location = new Point(760, 0);
            btnMaximizeCart.Name = "btnMaximizeCart";
            btnMaximizeCart.Padding = new Padding(5, 0, 0, 0);
            btnMaximizeCart.Size = new Size(30, 30);
            btnMaximizeCart.TabIndex = 8;
            btnMaximizeCart.Text = "O";
            btnMaximizeCart.UseVisualStyleBackColor = true;
            btnMaximizeCart.Click += btnMaximizeCart_Click;
            // 
            // btnCloseCart
            // 
            btnCloseCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseCart.Cursor = Cursors.Hand;
            btnCloseCart.FlatAppearance.BorderSize = 0;
            btnCloseCart.FlatStyle = FlatStyle.Flat;
            btnCloseCart.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseCart.ForeColor = Color.White;
            btnCloseCart.Location = new Point(786, 0);
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
            lblTitle.Location = new Point(72, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(666, 77);
            lblTitle.TabIndex = 6;
            lblTitle.Text = "MEU CARRINHO";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            lblTitle.MouseDown += lblTitle_MouseDown;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.Cursor = Cursors.Hand;
            btnMinimize.FlatAppearance.BorderSize = 0;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1396, 3);
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
            btnMaximize.Location = new Point(1423, 3);
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
            btnClose.Location = new Point(1450, 3);
            btnClose.Name = "btnClose";
            btnClose.Padding = new Padding(7, 0, 0, 0);
            btnClose.Size = new Size(30, 30);
            btnClose.TabIndex = 3;
            btnClose.Text = "O";
            btnClose.UseVisualStyleBackColor = true;
            // 
            // panelComprar
            // 
            panelComprar.Controls.Add(btnComprar);
            panelComprar.Controls.Add(lblPrecoTotal);
            panelComprar.Dock = DockStyle.Top;
            panelComprar.Location = new Point(0, 80);
            panelComprar.Name = "panelComprar";
            panelComprar.Size = new Size(852, 108);
            panelComprar.TabIndex = 3;
            // 
            // btnComprar
            // 
            btnComprar.BackColor = Color.FromArgb(0, 150, 136);
            btnComprar.FlatAppearance.BorderSize = 0;
            btnComprar.FlatStyle = FlatStyle.Flat;
            btnComprar.Font = new Font("Montserrat", 9F, FontStyle.Bold, GraphicsUnit.Point);
            btnComprar.ForeColor = Color.White;
            btnComprar.Location = new Point(345, 34);
            btnComprar.Name = "btnComprar";
            btnComprar.Size = new Size(148, 41);
            btnComprar.TabIndex = 1;
            btnComprar.Text = "Comprar";
            btnComprar.UseVisualStyleBackColor = false;
            btnComprar.Click += btnComprar_Click;
            // 
            // lblPrecoTotal
            // 
            lblPrecoTotal.AutoSize = true;
            lblPrecoTotal.Location = new Point(633, 47);
            lblPrecoTotal.Name = "lblPrecoTotal";
            lblPrecoTotal.Size = new Size(64, 15);
            lblPrecoTotal.TabIndex = 0;
            lblPrecoTotal.Text = "preco total";
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label4);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(845, 96);
            panel2.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(13, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 75);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(499, 29);
            button1.Name = "button1";
            button1.Size = new Size(32, 28);
            button1.TabIndex = 6;
            button1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.Location = new Point(97, 29);
            label1.Name = "label1";
            label1.Size = new Size(98, 46);
            label1.TabIndex = 1;
            label1.Text = "nome";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(742, 45);
            label2.Name = "label2";
            label2.Size = new Size(37, 15);
            label2.TabIndex = 3;
            label2.Text = "preço";
            // 
            // label3
            // 
            label3.Location = new Point(235, 29);
            label3.Name = "label3";
            label3.Size = new Size(217, 46);
            label3.TabIndex = 5;
            label3.Text = "descrição";
            label3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // button2
            // 
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(603, 29);
            button2.Name = "button2";
            button2.Size = new Size(32, 28);
            button2.TabIndex = 5;
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Location = new Point(532, 63);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 0;
            button3.Text = "Remover";
            button3.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.Location = new Point(555, 34);
            label4.Name = "label4";
            label4.Size = new Size(28, 21);
            label4.TabIndex = 3;
            label4.Text = "1";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormPurchase
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(864, 543);
            Controls.Add(panelComprar);
            Controls.Add(panelTitleBar);
            Controls.Add(tableLayoutPanel1);
            Name = "FormPurchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FormPurchase";
            TopMost = true;
            tableLayoutPanel1.ResumeLayout(false);
            panelTitleBar.ResumeLayout(false);
            panelComprar.ResumeLayout(false);
            panelComprar.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTitleBar;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnMinimizeCart;
        private Button btnMaximizeCart;
        private Button btnCloseCart;
        private Label lblTitle;
        private Panel panelComprar;
        private Label lblPrecoTotal;
        private Button btnComprar;
        private Panel panel2;
        private PictureBox pictureBox2;
        private Button button1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button button2;
        private Button button3;
        private Label label4;
    }
}