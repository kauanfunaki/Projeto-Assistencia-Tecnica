namespace ProjetoAvaliação.UC_s
{
    partial class UC_Cadastro
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_Cadastro));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(147, 17);
            label1.TabIndex = 0;
            label1.Text = "1. Esqueci meu e-mail.";
            // 
            // label2
            // 
            label2.Location = new Point(0, 17);
            label2.Name = "label2";
            label2.Size = new Size(495, 33);
            label2.TabIndex = 1;
            label2.Text = "Entre em contato com o nosso setor de atendimento, e informe seus dados como nome e CPF para que possam localizar seu endereço de e-mail e lhe informar.";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.Location = new Point(-3, 70);
            label3.Name = "label3";
            label3.Size = new Size(495, 33);
            label3.TabIndex = 3;
            label3.Text = "Primeiramente, é necessário acessar o nosso site, na parte superior clique em \"Entrar\", nesta tela, clique em “Esqueceu sua senha?” e preencha seu e-mail.";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(0, 53);
            label4.Name = "label4";
            label4.Size = new Size(156, 17);
            label4.TabIndex = 2;
            label4.Text = "2. Esqueci minha senha.";
            // 
            // label5
            // 
            label5.Location = new Point(-3, 178);
            label5.Name = "label5";
            label5.Size = new Size(495, 33);
            label5.TabIndex = 7;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 161);
            label6.Name = "label6";
            label6.Size = new Size(183, 17);
            label6.TabIndex = 6;
            label6.Text = "4. Como alterar meu e-mail?";
            // 
            // label7
            // 
            label7.Location = new Point(0, 123);
            label7.Name = "label7";
            label7.Size = new Size(495, 33);
            label7.TabIndex = 5;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(0, 106);
            label8.Name = "label8";
            label8.Size = new Size(148, 17);
            label8.TabIndex = 4;
            label8.Text = "3. Alterar minha senha";
            // 
            // label9
            // 
            label9.Location = new Point(-3, 283);
            label9.Name = "label9";
            label9.Size = new Size(495, 33);
            label9.TabIndex = 11;
            label9.Text = "Há duas formas de realizar seu cadastro: na parte superior clicando em “Cadastro”, ou, no momento da finalização da sua compra.";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label10.Location = new Point(0, 266);
            label10.Name = "label10";
            label10.Size = new Size(182, 17);
            label10.TabIndex = 10;
            label10.Text = "6. Como faço meu cadastro?";
            // 
            // label11
            // 
            label11.Location = new Point(0, 228);
            label11.Name = "label11";
            label11.Size = new Size(495, 33);
            label11.TabIndex = 9;
            label11.Text = resources.GetString("label11.Text");
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label12.Location = new Point(0, 211);
            label12.Name = "label12";
            label12.Size = new Size(209, 17);
            label12.TabIndex = 8;
            label12.Text = "5. Como atualizar meu cadastro?";
            // 
            // UC_Cadastro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(label11);
            Controls.Add(label12);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_Cadastro";
            Size = new Size(495, 316);
            Load += UC_Cadastro_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
    }
}
