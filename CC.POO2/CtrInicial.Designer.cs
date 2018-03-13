namespace CC.POO2
{
    partial class CtrInicial
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
            this.BtnIrSitePessoal = new System.Windows.Forms.Button();
            this.LblOla = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblRA = new System.Windows.Forms.Label();
            this.LblDescricaoTrabalho = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnIrSitePessoal
            // 
            this.BtnIrSitePessoal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(182)))), ((int)(((byte)(172)))), ((int)(((byte)(0)))));
            this.BtnIrSitePessoal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIrSitePessoal.FlatAppearance.BorderSize = 0;
            this.BtnIrSitePessoal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnIrSitePessoal.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnIrSitePessoal.ForeColor = System.Drawing.Color.White;
            this.BtnIrSitePessoal.Location = new System.Drawing.Point(54, 284);
            this.BtnIrSitePessoal.Name = "BtnIrSitePessoal";
            this.BtnIrSitePessoal.Size = new System.Drawing.Size(254, 29);
            this.BtnIrSitePessoal.TabIndex = 8;
            this.BtnIrSitePessoal.Text = "Ir para o Site Pessoal";
            this.BtnIrSitePessoal.UseVisualStyleBackColor = false;
            this.BtnIrSitePessoal.Click += new System.EventHandler(this.BtnIrSitePessoal_Click);
            // 
            // LblOla
            // 
            this.LblOla.AutoSize = true;
            this.LblOla.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblOla.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.LblOla.Location = new System.Drawing.Point(32, 15);
            this.LblOla.Name = "LblOla";
            this.LblOla.Size = new System.Drawing.Size(137, 18);
            this.LblOla.TabIndex = 3;
            this.LblOla.Text = "Olá! Meu nome é";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Elephant", 71.99999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(174)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 123);
            this.label2.TabIndex = 4;
            this.label2.Text = "(:";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(47, 136);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(282, 41);
            this.LblNome.TabIndex = 5;
            this.LblNome.Text = "Gabriel Vicente";
            // 
            // LblRA
            // 
            this.LblRA.AutoSize = true;
            this.LblRA.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblRA.Location = new System.Drawing.Point(57, 181);
            this.LblRA.Name = "LblRA";
            this.LblRA.Size = new System.Drawing.Size(145, 20);
            this.LblRA.TabIndex = 6;
            this.LblRA.Text = "RA: 192 907 612 775";
            // 
            // LblDescricaoTrabalho
            // 
            this.LblDescricaoTrabalho.AutoSize = true;
            this.LblDescricaoTrabalho.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDescricaoTrabalho.Location = new System.Drawing.Point(58, 216);
            this.LblDescricaoTrabalho.Name = "LblDescricaoTrabalho";
            this.LblDescricaoTrabalho.Size = new System.Drawing.Size(180, 51);
            this.LblDescricaoTrabalho.TabIndex = 7;
            this.LblDescricaoTrabalho.Text = "Trabalho para a Disciplina de\r\nProgramação Orientada a\r\nObjetos 2 | Profº Rogério" +
    "";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CC.POO2.Properties.Resources.programador;
            this.pictureBox1.Location = new System.Drawing.Point(394, 102);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(377, 228);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // CtrInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnIrSitePessoal);
            this.Controls.Add(this.LblOla);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LblNome);
            this.Controls.Add(this.LblRA);
            this.Controls.Add(this.LblDescricaoTrabalho);
            this.Name = "CtrInicial";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button BtnIrSitePessoal;
        private System.Windows.Forms.Label LblOla;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblRA;
        private System.Windows.Forms.Label LblDescricaoTrabalho;
    }
}
