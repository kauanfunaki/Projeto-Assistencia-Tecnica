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
            panel1 = new Panel();
            pictureBox2 = new PictureBox();
            btnMinus1 = new Button();
            lblNome1 = new Label();
            lblPreco1 = new Label();
            lblDescricao1 = new Label();
            btnAdd1 = new Button();
            btnRemover1 = new Button();
            lblQuantidade1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            btnMinus2 = new Button();
            lblNome2 = new Label();
            lblPreco2 = new Label();
            lblDescricao2 = new Label();
            btnAdd2 = new Button();
            btnRemover2 = new Button();
            lblQuantidade2 = new Label();
            panel3 = new Panel();
            pictureBox3 = new PictureBox();
            btnMinus3 = new Button();
            lblNome3 = new Label();
            lblPreco3 = new Label();
            lblDescricao3 = new Label();
            btnAdd3 = new Button();
            btnRemover3 = new Button();
            lblQuantidade3 = new Label();
            panel4 = new Panel();
            pictureBox4 = new PictureBox();
            btnMinus4 = new Button();
            lblNome4 = new Label();
            lblPreco4 = new Label();
            lblDescricao4 = new Label();
            btnAdd4 = new Button();
            btnRemover4 = new Button();
            lblQuantidade4 = new Label();
            panel5 = new Panel();
            pictureBox5 = new PictureBox();
            btnMinus5 = new Button();
            lblNome5 = new Label();
            lblPreco5 = new Label();
            lblDescricao5 = new Label();
            btnAdd5 = new Button();
            btnRemover5 = new Button();
            lblQuantidade5 = new Label();
            panelTitleBar = new Panel();
            btnCloseCart = new Button();
            lblTitle = new Label();
            btnMinimize = new Button();
            btnMaximize = new Button();
            btnClose = new Button();
            panelComprar = new Panel();
            btnComprar = new Button();
            lblPrecoTotal = new Label();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).BeginInit();
            panelTitleBar.SuspendLayout();
            panelComprar.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Controls.Add(panel1, 0, 0);
            tableLayoutPanel1.Controls.Add(panel2, 0, 1);
            tableLayoutPanel1.Controls.Add(panel3, 0, 2);
            tableLayoutPanel1.Controls.Add(panel4, 0, 3);
            tableLayoutPanel1.Controls.Add(panel5, 0, 4);
            tableLayoutPanel1.Location = new Point(1, 194);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(846, 511);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(btnMinus1);
            panel1.Controls.Add(lblNome1);
            panel1.Controls.Add(lblPreco1);
            panel1.Controls.Add(lblDescricao1);
            panel1.Controls.Add(btnAdd1);
            panel1.Controls.Add(btnRemover1);
            panel1.Controls.Add(lblQuantidade1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(840, 96);
            panel1.TabIndex = 3;
            // 
            // pictureBox2
            // 
            pictureBox2.Location = new Point(16, 11);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(78, 75);
            pictureBox2.TabIndex = 7;
            pictureBox2.TabStop = false;
            // 
            // btnMinus1
            // 
            btnMinus1.FlatAppearance.BorderSize = 0;
            btnMinus1.FlatStyle = FlatStyle.Flat;
            btnMinus1.Image = (Image)resources.GetObject("btnMinus1.Image");
            btnMinus1.Location = new Point(499, 29);
            btnMinus1.Name = "btnMinus1";
            btnMinus1.Size = new Size(32, 28);
            btnMinus1.TabIndex = 6;
            btnMinus1.UseVisualStyleBackColor = true;
            btnMinus1.Click += RemoverQuantidade;
            // 
            // lblNome1
            // 
            lblNome1.Location = new Point(103, 29);
            lblNome1.Name = "lblNome1";
            lblNome1.Size = new Size(98, 46);
            lblNome1.TabIndex = 1;
            lblNome1.Text = "nome";
            lblNome1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco1
            // 
            lblPreco1.AutoSize = true;
            lblPreco1.Location = new Point(735, 45);
            lblPreco1.Name = "lblPreco1";
            lblPreco1.Size = new Size(37, 15);
            lblPreco1.TabIndex = 3;
            lblPreco1.Text = "preço";
            // 
            // lblDescricao1
            // 
            lblDescricao1.Location = new Point(240, 29);
            lblDescricao1.Name = "lblDescricao1";
            lblDescricao1.Size = new Size(217, 46);
            lblDescricao1.TabIndex = 5;
            lblDescricao1.Text = "descrição";
            lblDescricao1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd1
            // 
            btnAdd1.FlatAppearance.BorderSize = 0;
            btnAdd1.FlatStyle = FlatStyle.Flat;
            btnAdd1.Image = (Image)resources.GetObject("btnAdd1.Image");
            btnAdd1.Location = new Point(603, 29);
            btnAdd1.Name = "btnAdd1";
            btnAdd1.Size = new Size(32, 28);
            btnAdd1.TabIndex = 5;
            btnAdd1.UseVisualStyleBackColor = true;
            btnAdd1.Click += AdicionarQuantidade;
            // 
            // btnRemover1
            // 
            btnRemover1.FlatAppearance.BorderSize = 0;
            btnRemover1.FlatStyle = FlatStyle.Flat;
            btnRemover1.Location = new Point(532, 63);
            btnRemover1.Name = "btnRemover1";
            btnRemover1.Size = new Size(75, 23);
            btnRemover1.TabIndex = 0;
            btnRemover1.Text = "Remover";
            btnRemover1.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade1
            // 
            lblQuantidade1.Location = new Point(555, 34);
            lblQuantidade1.Name = "lblQuantidade1";
            lblQuantidade1.Size = new Size(28, 21);
            lblQuantidade1.TabIndex = 3;
            lblQuantidade1.Text = "1";
            lblQuantidade1.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(btnMinus2);
            panel2.Controls.Add(lblNome2);
            panel2.Controls.Add(lblPreco2);
            panel2.Controls.Add(lblDescricao2);
            panel2.Controls.Add(btnAdd2);
            panel2.Controls.Add(btnRemover2);
            panel2.Controls.Add(lblQuantidade2);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(3, 105);
            panel2.Name = "panel2";
            panel2.Size = new Size(840, 96);
            panel2.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(16, 11);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(78, 75);
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // btnMinus2
            // 
            btnMinus2.FlatAppearance.BorderSize = 0;
            btnMinus2.FlatStyle = FlatStyle.Flat;
            btnMinus2.Image = (Image)resources.GetObject("btnMinus2.Image");
            btnMinus2.Location = new Point(499, 29);
            btnMinus2.Name = "btnMinus2";
            btnMinus2.Size = new Size(32, 28);
            btnMinus2.TabIndex = 14;
            btnMinus2.UseVisualStyleBackColor = true;
            // 
            // lblNome2
            // 
            lblNome2.Location = new Point(103, 29);
            lblNome2.Name = "lblNome2";
            lblNome2.Size = new Size(98, 46);
            lblNome2.TabIndex = 9;
            lblNome2.Text = "nome";
            lblNome2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco2
            // 
            lblPreco2.AutoSize = true;
            lblPreco2.Location = new Point(735, 45);
            lblPreco2.Name = "lblPreco2";
            lblPreco2.Size = new Size(37, 15);
            lblPreco2.TabIndex = 10;
            lblPreco2.Text = "preço";
            // 
            // lblDescricao2
            // 
            lblDescricao2.Location = new Point(240, 29);
            lblDescricao2.Name = "lblDescricao2";
            lblDescricao2.Size = new Size(217, 46);
            lblDescricao2.TabIndex = 12;
            lblDescricao2.Text = "descrição";
            lblDescricao2.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd2
            // 
            btnAdd2.FlatAppearance.BorderSize = 0;
            btnAdd2.FlatStyle = FlatStyle.Flat;
            btnAdd2.Image = (Image)resources.GetObject("btnAdd2.Image");
            btnAdd2.Location = new Point(603, 29);
            btnAdd2.Name = "btnAdd2";
            btnAdd2.Size = new Size(32, 28);
            btnAdd2.TabIndex = 13;
            btnAdd2.UseVisualStyleBackColor = true;
            // 
            // btnRemover2
            // 
            btnRemover2.FlatAppearance.BorderSize = 0;
            btnRemover2.FlatStyle = FlatStyle.Flat;
            btnRemover2.Location = new Point(532, 63);
            btnRemover2.Name = "btnRemover2";
            btnRemover2.Size = new Size(75, 23);
            btnRemover2.TabIndex = 8;
            btnRemover2.Text = "Remover";
            btnRemover2.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade2
            // 
            lblQuantidade2.Location = new Point(555, 33);
            lblQuantidade2.Name = "lblQuantidade2";
            lblQuantidade2.Size = new Size(28, 21);
            lblQuantidade2.TabIndex = 11;
            lblQuantidade2.Text = "1";
            lblQuantidade2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            panel3.Controls.Add(pictureBox3);
            panel3.Controls.Add(btnMinus3);
            panel3.Controls.Add(lblNome3);
            panel3.Controls.Add(lblPreco3);
            panel3.Controls.Add(lblDescricao3);
            panel3.Controls.Add(btnAdd3);
            panel3.Controls.Add(btnRemover3);
            panel3.Controls.Add(lblQuantidade3);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(3, 207);
            panel3.Name = "panel3";
            panel3.Size = new Size(840, 96);
            panel3.TabIndex = 5;
            // 
            // pictureBox3
            // 
            pictureBox3.Location = new Point(16, 11);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(78, 75);
            pictureBox3.TabIndex = 15;
            pictureBox3.TabStop = false;
            // 
            // btnMinus3
            // 
            btnMinus3.FlatAppearance.BorderSize = 0;
            btnMinus3.FlatStyle = FlatStyle.Flat;
            btnMinus3.Image = (Image)resources.GetObject("btnMinus3.Image");
            btnMinus3.Location = new Point(499, 29);
            btnMinus3.Name = "btnMinus3";
            btnMinus3.Size = new Size(32, 28);
            btnMinus3.TabIndex = 14;
            btnMinus3.UseVisualStyleBackColor = true;
            // 
            // lblNome3
            // 
            lblNome3.Location = new Point(103, 29);
            lblNome3.Name = "lblNome3";
            lblNome3.Size = new Size(98, 46);
            lblNome3.TabIndex = 9;
            lblNome3.Text = "nome";
            lblNome3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco3
            // 
            lblPreco3.AutoSize = true;
            lblPreco3.Location = new Point(735, 45);
            lblPreco3.Name = "lblPreco3";
            lblPreco3.Size = new Size(37, 15);
            lblPreco3.TabIndex = 10;
            lblPreco3.Text = "preço";
            // 
            // lblDescricao3
            // 
            lblDescricao3.Location = new Point(240, 29);
            lblDescricao3.Name = "lblDescricao3";
            lblDescricao3.Size = new Size(217, 46);
            lblDescricao3.TabIndex = 12;
            lblDescricao3.Text = "descrição";
            lblDescricao3.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd3
            // 
            btnAdd3.FlatAppearance.BorderSize = 0;
            btnAdd3.FlatStyle = FlatStyle.Flat;
            btnAdd3.Image = (Image)resources.GetObject("btnAdd3.Image");
            btnAdd3.Location = new Point(603, 29);
            btnAdd3.Name = "btnAdd3";
            btnAdd3.Size = new Size(32, 28);
            btnAdd3.TabIndex = 13;
            btnAdd3.UseVisualStyleBackColor = true;
            // 
            // btnRemover3
            // 
            btnRemover3.FlatAppearance.BorderSize = 0;
            btnRemover3.FlatStyle = FlatStyle.Flat;
            btnRemover3.Location = new Point(532, 63);
            btnRemover3.Name = "btnRemover3";
            btnRemover3.Size = new Size(75, 23);
            btnRemover3.TabIndex = 8;
            btnRemover3.Text = "Remover";
            btnRemover3.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade3
            // 
            lblQuantidade3.Location = new Point(555, 33);
            lblQuantidade3.Name = "lblQuantidade3";
            lblQuantidade3.Size = new Size(28, 21);
            lblQuantidade3.TabIndex = 11;
            lblQuantidade3.Text = "1";
            lblQuantidade3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            panel4.Controls.Add(pictureBox4);
            panel4.Controls.Add(btnMinus4);
            panel4.Controls.Add(lblNome4);
            panel4.Controls.Add(lblPreco4);
            panel4.Controls.Add(lblDescricao4);
            panel4.Controls.Add(btnAdd4);
            panel4.Controls.Add(btnRemover4);
            panel4.Controls.Add(lblQuantidade4);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(3, 309);
            panel4.Name = "panel4";
            panel4.Size = new Size(840, 96);
            panel4.TabIndex = 6;
            // 
            // pictureBox4
            // 
            pictureBox4.Location = new Point(16, 11);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(78, 75);
            pictureBox4.TabIndex = 15;
            pictureBox4.TabStop = false;
            // 
            // btnMinus4
            // 
            btnMinus4.FlatAppearance.BorderSize = 0;
            btnMinus4.FlatStyle = FlatStyle.Flat;
            btnMinus4.Image = (Image)resources.GetObject("btnMinus4.Image");
            btnMinus4.Location = new Point(499, 30);
            btnMinus4.Name = "btnMinus4";
            btnMinus4.Size = new Size(32, 28);
            btnMinus4.TabIndex = 14;
            btnMinus4.UseVisualStyleBackColor = true;
            // 
            // lblNome4
            // 
            lblNome4.Location = new Point(103, 29);
            lblNome4.Name = "lblNome4";
            lblNome4.Size = new Size(98, 46);
            lblNome4.TabIndex = 9;
            lblNome4.Text = "nome";
            lblNome4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco4
            // 
            lblPreco4.AutoSize = true;
            lblPreco4.Location = new Point(735, 45);
            lblPreco4.Name = "lblPreco4";
            lblPreco4.Size = new Size(37, 15);
            lblPreco4.TabIndex = 10;
            lblPreco4.Text = "preço";
            // 
            // lblDescricao4
            // 
            lblDescricao4.Location = new Point(240, 29);
            lblDescricao4.Name = "lblDescricao4";
            lblDescricao4.Size = new Size(217, 46);
            lblDescricao4.TabIndex = 12;
            lblDescricao4.Text = "descrição";
            lblDescricao4.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd4
            // 
            btnAdd4.FlatAppearance.BorderSize = 0;
            btnAdd4.FlatStyle = FlatStyle.Flat;
            btnAdd4.Image = (Image)resources.GetObject("btnAdd4.Image");
            btnAdd4.Location = new Point(603, 30);
            btnAdd4.Name = "btnAdd4";
            btnAdd4.Size = new Size(32, 28);
            btnAdd4.TabIndex = 13;
            btnAdd4.UseVisualStyleBackColor = true;
            // 
            // btnRemover4
            // 
            btnRemover4.FlatAppearance.BorderSize = 0;
            btnRemover4.FlatStyle = FlatStyle.Flat;
            btnRemover4.Location = new Point(532, 63);
            btnRemover4.Name = "btnRemover4";
            btnRemover4.Size = new Size(75, 23);
            btnRemover4.TabIndex = 8;
            btnRemover4.Text = "Remover";
            btnRemover4.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade4
            // 
            lblQuantidade4.Location = new Point(555, 34);
            lblQuantidade4.Name = "lblQuantidade4";
            lblQuantidade4.Size = new Size(28, 21);
            lblQuantidade4.TabIndex = 11;
            lblQuantidade4.Text = "1";
            lblQuantidade4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            panel5.Controls.Add(pictureBox5);
            panel5.Controls.Add(btnMinus5);
            panel5.Controls.Add(lblNome5);
            panel5.Controls.Add(lblPreco5);
            panel5.Controls.Add(lblDescricao5);
            panel5.Controls.Add(btnAdd5);
            panel5.Controls.Add(btnRemover5);
            panel5.Controls.Add(lblQuantidade5);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 411);
            panel5.Name = "panel5";
            panel5.Size = new Size(840, 97);
            panel5.TabIndex = 7;
            // 
            // pictureBox5
            // 
            pictureBox5.Location = new Point(16, 11);
            pictureBox5.Name = "pictureBox5";
            pictureBox5.Size = new Size(78, 75);
            pictureBox5.TabIndex = 15;
            pictureBox5.TabStop = false;
            // 
            // btnMinus5
            // 
            btnMinus5.FlatAppearance.BorderSize = 0;
            btnMinus5.FlatStyle = FlatStyle.Flat;
            btnMinus5.Image = (Image)resources.GetObject("btnMinus5.Image");
            btnMinus5.Location = new Point(499, 32);
            btnMinus5.Name = "btnMinus5";
            btnMinus5.Size = new Size(32, 28);
            btnMinus5.TabIndex = 14;
            btnMinus5.UseVisualStyleBackColor = true;
            // 
            // lblNome5
            // 
            lblNome5.Location = new Point(103, 29);
            lblNome5.Name = "lblNome5";
            lblNome5.Size = new Size(98, 46);
            lblNome5.TabIndex = 9;
            lblNome5.Text = "nome";
            lblNome5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblPreco5
            // 
            lblPreco5.AutoSize = true;
            lblPreco5.Location = new Point(735, 45);
            lblPreco5.Name = "lblPreco5";
            lblPreco5.Size = new Size(37, 15);
            lblPreco5.TabIndex = 10;
            lblPreco5.Text = "preço";
            // 
            // lblDescricao5
            // 
            lblDescricao5.Location = new Point(240, 29);
            lblDescricao5.Name = "lblDescricao5";
            lblDescricao5.Size = new Size(217, 46);
            lblDescricao5.TabIndex = 12;
            lblDescricao5.Text = "descrição";
            lblDescricao5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnAdd5
            // 
            btnAdd5.FlatAppearance.BorderSize = 0;
            btnAdd5.FlatStyle = FlatStyle.Flat;
            btnAdd5.Image = (Image)resources.GetObject("btnAdd5.Image");
            btnAdd5.Location = new Point(603, 32);
            btnAdd5.Name = "btnAdd5";
            btnAdd5.Size = new Size(32, 28);
            btnAdd5.TabIndex = 13;
            btnAdd5.UseVisualStyleBackColor = true;
            // 
            // btnRemover5
            // 
            btnRemover5.FlatAppearance.BorderSize = 0;
            btnRemover5.FlatStyle = FlatStyle.Flat;
            btnRemover5.Location = new Point(532, 63);
            btnRemover5.Name = "btnRemover5";
            btnRemover5.Size = new Size(75, 23);
            btnRemover5.TabIndex = 8;
            btnRemover5.Text = "Remover";
            btnRemover5.UseVisualStyleBackColor = true;
            // 
            // lblQuantidade5
            // 
            lblQuantidade5.Location = new Point(555, 36);
            lblQuantidade5.Name = "lblQuantidade5";
            lblQuantidade5.Size = new Size(28, 21);
            lblQuantidade5.TabIndex = 11;
            lblQuantidade5.Text = "1";
            lblQuantidade5.TextAlign = ContentAlignment.MiddleCenter;
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
            panelTitleBar.Size = new Size(847, 80);
            panelTitleBar.TabIndex = 2;
            panelTitleBar.MouseDown += panelTitleBar_MouseDown;
            // 
            // btnCloseCart
            // 
            btnCloseCart.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnCloseCart.Cursor = Cursors.Hand;
            btnCloseCart.FlatAppearance.BorderSize = 0;
            btnCloseCart.FlatStyle = FlatStyle.Flat;
            btnCloseCart.Font = new Font("Microsoft Sans Serif", 15F, FontStyle.Bold, GraphicsUnit.Point);
            btnCloseCart.ForeColor = Color.White;
            btnCloseCart.Location = new Point(812, 0);
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
            lblTitle.Location = new Point(107, 2);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(628, 77);
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
            btnMinimize.Location = new Point(1391, 3);
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
            btnMaximize.Location = new Point(1418, 3);
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
            btnClose.Location = new Point(1445, 3);
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
            panelComprar.Size = new Size(847, 108);
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
            Load += FormPurchase_Load;
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox5).EndInit();
            panelTitleBar.ResumeLayout(false);
            panelComprar.ResumeLayout(false);
            panelComprar.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Panel panelTitleBar;
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        private Button btnCloseCart;
        private Label lblTitle;
        private Panel panelComprar;
        private Label lblPrecoTotal;
        private Button btnComprar;
        private Panel panel1;
        private PictureBox pictureBox2;
        private Button btnMinus1;
        private Label lblNome1;
        private Label lblPreco1;
        private Label lblDescricao1;
        private Button btnAdd1;
        private Button btnRemover1;
        private Label lblQuantidade1;
        private Panel panel2;
        private Panel panel3;
        private Panel panel4;
        private Panel panel5;
        private PictureBox pictureBox1;
        private Button btnMinus2;
        private Label lblNome2;
        private Label lblPreco2;
        private Label lblDescricao2;
        private Button btnAdd2;
        private Button btnRemover2;
        private Label lblQuantidade2;
        private PictureBox pictureBox3;
        private Button btnMinus3;
        private Label lblNome3;
        private Label lblPreco3;
        private Label lblDescricao3;
        private Button btnAdd3;
        private Button btnRemover3;
        private Label lblQuantidade3;
        private PictureBox pictureBox4;
        private Button btnMinus4;
        private Label lblNome4;
        private Label lblPreco4;
        private Label lblDescricao4;
        private Button btnAdd4;
        private Button btnRemover4;
        private Label lblQuantidade4;
        private PictureBox pictureBox5;
        private Button btnMinus5;
        private Label lblNome5;
        private Label lblPreco5;
        private Label lblDescricao5;
        private Button btnAdd5;
        private Button btnRemover5;
        private Label lblQuantidade5;
    }
}