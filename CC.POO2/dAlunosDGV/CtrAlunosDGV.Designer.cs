namespace CC.POO2
{
    partial class CtrAlunosDGV
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
            this.DgvAlunos = new System.Windows.Forms.DataGridView();
            this.BtnAdicionarAluno = new System.Windows.Forms.Button();
            this.GpbParametrosAluno = new System.Windows.Forms.GroupBox();
            this.BtnPreencherListasRandom = new System.Windows.Forms.Button();
            this.TxtNotaAluno = new System.Windows.Forms.TextBox();
            this.LblNotaAluno = new System.Windows.Forms.Label();
            this.TxtNomeAluno = new System.Windows.Forms.TextBox();
            this.LblNomeAluno = new System.Windows.Forms.Label();
            this.GpbAlunos = new System.Windows.Forms.GroupBox();
            this.GpbAlunosFiltrados = new System.Windows.Forms.GroupBox();
            this.DgvAlunosFiltrados = new System.Windows.Forms.DataGridView();
            this.BtnLimparLista = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).BeginInit();
            this.GpbParametrosAluno.SuspendLayout();
            this.GpbAlunos.SuspendLayout();
            this.GpbAlunosFiltrados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunosFiltrados)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvAlunos
            // 
            this.DgvAlunos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlunos.Location = new System.Drawing.Point(22, 28);
            this.DgvAlunos.Name = "DgvAlunos";
            this.DgvAlunos.Size = new System.Drawing.Size(223, 180);
            this.DgvAlunos.TabIndex = 0;
            // 
            // BtnAdicionarAluno
            // 
            this.BtnAdicionarAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAdicionarAluno.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.BtnAdicionarAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAdicionarAluno.Location = new System.Drawing.Point(398, 31);
            this.BtnAdicionarAluno.Name = "BtnAdicionarAluno";
            this.BtnAdicionarAluno.Size = new System.Drawing.Size(89, 24);
            this.BtnAdicionarAluno.TabIndex = 3;
            this.BtnAdicionarAluno.Text = "Add Aluno";
            this.BtnAdicionarAluno.UseVisualStyleBackColor = true;
            this.BtnAdicionarAluno.Click += new System.EventHandler(this.BtnAdicionarAluno_Click);
            // 
            // GpbParametrosAluno
            // 
            this.GpbParametrosAluno.Controls.Add(this.BtnLimparLista);
            this.GpbParametrosAluno.Controls.Add(this.BtnPreencherListasRandom);
            this.GpbParametrosAluno.Controls.Add(this.TxtNotaAluno);
            this.GpbParametrosAluno.Controls.Add(this.LblNotaAluno);
            this.GpbParametrosAluno.Controls.Add(this.TxtNomeAluno);
            this.GpbParametrosAluno.Controls.Add(this.LblNomeAluno);
            this.GpbParametrosAluno.Controls.Add(this.BtnAdicionarAluno);
            this.GpbParametrosAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbParametrosAluno.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbParametrosAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbParametrosAluno.Location = new System.Drawing.Point(18, 14);
            this.GpbParametrosAluno.Name = "GpbParametrosAluno";
            this.GpbParametrosAluno.Size = new System.Drawing.Size(587, 76);
            this.GpbParametrosAluno.TabIndex = 29;
            this.GpbParametrosAluno.TabStop = false;
            this.GpbParametrosAluno.Text = "Parâmetros Aluno";
            // 
            // BtnPreencherListasRandom
            // 
            this.BtnPreencherListasRandom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPreencherListasRandom.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.BtnPreencherListasRandom.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnPreencherListasRandom.Location = new System.Drawing.Point(493, 31);
            this.BtnPreencherListasRandom.Name = "BtnPreencherListasRandom";
            this.BtnPreencherListasRandom.Size = new System.Drawing.Size(30, 24);
            this.BtnPreencherListasRandom.TabIndex = 32;
            this.BtnPreencherListasRandom.Text = "?";
            this.BtnPreencherListasRandom.UseVisualStyleBackColor = true;
            this.BtnPreencherListasRandom.Click += new System.EventHandler(this.BtnPreencherListasRandom_Click);
            // 
            // TxtNotaAluno
            // 
            this.TxtNotaAluno.Location = new System.Drawing.Point(314, 32);
            this.TxtNotaAluno.Name = "TxtNotaAluno";
            this.TxtNotaAluno.Size = new System.Drawing.Size(78, 24);
            this.TxtNotaAluno.TabIndex = 1;
            // 
            // LblNotaAluno
            // 
            this.LblNotaAluno.AutoSize = true;
            this.LblNotaAluno.Location = new System.Drawing.Point(261, 32);
            this.LblNotaAluno.Name = "LblNotaAluno";
            this.LblNotaAluno.Size = new System.Drawing.Size(47, 19);
            this.LblNotaAluno.TabIndex = 31;
            this.LblNotaAluno.Text = "Nota:";
            // 
            // TxtNomeAluno
            // 
            this.TxtNomeAluno.Location = new System.Drawing.Point(74, 31);
            this.TxtNomeAluno.Name = "TxtNomeAluno";
            this.TxtNomeAluno.Size = new System.Drawing.Size(181, 24);
            this.TxtNomeAluno.TabIndex = 0;
            // 
            // LblNomeAluno
            // 
            this.LblNomeAluno.AutoSize = true;
            this.LblNomeAluno.Location = new System.Drawing.Point(18, 32);
            this.LblNomeAluno.Name = "LblNomeAluno";
            this.LblNomeAluno.Size = new System.Drawing.Size(54, 19);
            this.LblNomeAluno.TabIndex = 2;
            this.LblNomeAluno.Text = "Nome:";
            // 
            // GpbAlunos
            // 
            this.GpbAlunos.Controls.Add(this.DgvAlunos);
            this.GpbAlunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbAlunos.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbAlunos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbAlunos.Location = new System.Drawing.Point(18, 96);
            this.GpbAlunos.Name = "GpbAlunos";
            this.GpbAlunos.Size = new System.Drawing.Size(272, 229);
            this.GpbAlunos.TabIndex = 30;
            this.GpbAlunos.TabStop = false;
            this.GpbAlunos.Text = "Alunos";
            // 
            // GpbAlunosFiltrados
            // 
            this.GpbAlunosFiltrados.Controls.Add(this.DgvAlunosFiltrados);
            this.GpbAlunosFiltrados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbAlunosFiltrados.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbAlunosFiltrados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbAlunosFiltrados.Location = new System.Drawing.Point(333, 96);
            this.GpbAlunosFiltrados.Name = "GpbAlunosFiltrados";
            this.GpbAlunosFiltrados.Size = new System.Drawing.Size(272, 229);
            this.GpbAlunosFiltrados.TabIndex = 31;
            this.GpbAlunosFiltrados.TabStop = false;
            this.GpbAlunosFiltrados.Text = "Alunos Filtrados";
            // 
            // DgvAlunosFiltrados
            // 
            this.DgvAlunosFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAlunosFiltrados.Location = new System.Drawing.Point(22, 28);
            this.DgvAlunosFiltrados.Name = "DgvAlunosFiltrados";
            this.DgvAlunosFiltrados.Size = new System.Drawing.Size(223, 180);
            this.DgvAlunosFiltrados.TabIndex = 0;
            // 
            // BtnLimparLista
            // 
            this.BtnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparLista.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.BtnLimparLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnLimparLista.Location = new System.Drawing.Point(529, 31);
            this.BtnLimparLista.Name = "BtnLimparLista";
            this.BtnLimparLista.Size = new System.Drawing.Size(31, 24);
            this.BtnLimparLista.TabIndex = 33;
            this.BtnLimparLista.Text = "*";
            this.BtnLimparLista.UseVisualStyleBackColor = true;
            this.BtnLimparLista.Click += new System.EventHandler(this.BtnLimparLista_Click);
            // 
            // CtrAlunosDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GpbAlunosFiltrados);
            this.Controls.Add(this.GpbAlunos);
            this.Controls.Add(this.GpbParametrosAluno);
            this.Name = "CtrAlunosDGV";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrAlunosDGV_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunos)).EndInit();
            this.GpbParametrosAluno.ResumeLayout(false);
            this.GpbParametrosAluno.PerformLayout();
            this.GpbAlunos.ResumeLayout(false);
            this.GpbAlunosFiltrados.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvAlunosFiltrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvAlunos;
        private System.Windows.Forms.Button BtnAdicionarAluno;
        private System.Windows.Forms.GroupBox GpbParametrosAluno;
        private System.Windows.Forms.TextBox TxtNomeAluno;
        private System.Windows.Forms.Label LblNomeAluno;
        private System.Windows.Forms.GroupBox GpbAlunos;
        private System.Windows.Forms.GroupBox GpbAlunosFiltrados;
        private System.Windows.Forms.DataGridView DgvAlunosFiltrados;
        private System.Windows.Forms.TextBox TxtNotaAluno;
        private System.Windows.Forms.Label LblNotaAluno;
        private System.Windows.Forms.Button BtnPreencherListasRandom;
        private System.Windows.Forms.Button BtnLimparLista;
    }
}
