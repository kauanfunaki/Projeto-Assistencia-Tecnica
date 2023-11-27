namespace ProjetoAvaliação.UC_s
{
    partial class UC_TrocaDevolucao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_TrocaDevolucao));
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label3 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // label5
            // 
            label5.Location = new Point(0, 238);
            label5.Name = "label5";
            label5.Size = new Size(495, 66);
            label5.TabIndex = 43;
            label5.Text = resources.GetString("label5.Text");
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(0, 218);
            label6.Name = "label6";
            label6.Size = new Size(294, 17);
            label6.TabIndex = 42;
            label6.Text = "4. Produto com defeito após 7 dias da entrega";
            // 
            // label7
            // 
            label7.Location = new Point(-2, 151);
            label7.Name = "label7";
            label7.Size = new Size(495, 62);
            label7.TabIndex = 41;
            label7.Text = resources.GetString("label7.Text");
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(-2, 134);
            label8.Name = "label8";
            label8.Size = new Size(336, 17);
            label8.TabIndex = 40;
            label8.Text = "3. Falta acessórios ou peças móveis / Peças avariadas";
            // 
            // label3
            // 
            label3.Location = new Point(0, 84);
            label3.Name = "label3";
            label3.Size = new Size(495, 47);
            label3.TabIndex = 39;
            label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(-2, 67);
            label4.Name = "label4";
            label4.Size = new Size(239, 17);
            label4.TabIndex = 38;
            label4.Text = "2. Produto diferente do que comprou";
            // 
            // label2
            // 
            label2.Location = new Point(1, 17);
            label2.Name = "label2";
            label2.Size = new Size(495, 47);
            label2.TabIndex = 37;
            label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(1, 0);
            label1.Name = "label1";
            label1.Size = new Size(161, 17);
            label1.TabIndex = 36;
            label1.Text = "1. Devolução de produto";
            // 
            // UC_TrocaDevolucao
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "UC_TrocaDevolucao";
            Size = new Size(495, 316);
            Load += UC_TrocaDevolucao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label3;
        private Label label4;
        private Label label2;
        private Label label1;
    }
}
