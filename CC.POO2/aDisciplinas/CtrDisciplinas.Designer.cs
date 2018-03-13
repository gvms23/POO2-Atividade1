namespace CC.POO2
{
    partial class CtrDisciplina
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
            this.lblInfoUsuario = new System.Windows.Forms.Label();
            this.GpbAluno = new System.Windows.Forms.GroupBox();
            this.LblNomeAluno = new System.Windows.Forms.Label();
            this.LblAulasTotais = new System.Windows.Forms.Label();
            this.TxtTotalAulas = new System.Windows.Forms.TextBox();
            this.GpbFinal = new System.Windows.Forms.GroupBox();
            this.LblPercentualPresenca = new System.Windows.Forms.Label();
            this.LblMedia = new System.Windows.Forms.Label();
            this.LblDisciplinaAtual = new System.Windows.Forms.Label();
            this.GpbNotas = new System.Windows.Forms.GroupBox();
            this.TxtFaltas = new System.Windows.Forms.TextBox();
            this.LblFaltasDisciplina = new System.Windows.Forms.Label();
            this.TxtNotaAvaliacao = new System.Windows.Forms.TextBox();
            this.LblNotaAvaliacao = new System.Windows.Forms.Label();
            this.BtnObterMedia = new System.Windows.Forms.Button();
            this.TxtNotaAtividade2 = new System.Windows.Forms.TextBox();
            this.LblNotaAtividade2 = new System.Windows.Forms.Label();
            this.TxtNotaAtividade1 = new System.Windows.Forms.TextBox();
            this.LblNotaAtividade1 = new System.Windows.Forms.Label();
            this.BtnDisciplina1 = new System.Windows.Forms.Button();
            this.BtnDisciplina2 = new System.Windows.Forms.Button();
            this.GpbAluno.SuspendLayout();
            this.GpbFinal.SuspendLayout();
            this.GpbNotas.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoUsuario
            // 
            this.lblInfoUsuario.AutoSize = true;
            this.lblInfoUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblInfoUsuario.Font = new System.Drawing.Font("Century Gothic", 12.25F, System.Drawing.FontStyle.Bold);
            this.lblInfoUsuario.ForeColor = System.Drawing.Color.Green;
            this.lblInfoUsuario.Location = new System.Drawing.Point(25, 320);
            this.lblInfoUsuario.Name = "lblInfoUsuario";
            this.lblInfoUsuario.Size = new System.Drawing.Size(225, 19);
            this.lblInfoUsuario.TabIndex = 28;
            this.lblInfoUsuario.Text = "Mensagem para o Usuário";
            this.lblInfoUsuario.Visible = false;
            // 
            // GpbAluno
            // 
            this.GpbAluno.Controls.Add(this.LblNomeAluno);
            this.GpbAluno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbAluno.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbAluno.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbAluno.Location = new System.Drawing.Point(18, 50);
            this.GpbAluno.Name = "GpbAluno";
            this.GpbAluno.Size = new System.Drawing.Size(347, 72);
            this.GpbAluno.TabIndex = 25;
            this.GpbAluno.TabStop = false;
            this.GpbAluno.Text = "Aluno";
            // 
            // LblNomeAluno
            // 
            this.LblNomeAluno.AutoSize = true;
            this.LblNomeAluno.Location = new System.Drawing.Point(18, 34);
            this.LblNomeAluno.Name = "LblNomeAluno";
            this.LblNomeAluno.Size = new System.Drawing.Size(70, 19);
            this.LblNomeAluno.TabIndex = 2;
            this.LblNomeAluno.Text = "Nome: @";
            // 
            // LblAulasTotais
            // 
            this.LblAulasTotais.AutoSize = true;
            this.LblAulasTotais.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.LblAulasTotais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblAulasTotais.Location = new System.Drawing.Point(222, 29);
            this.LblAulasTotais.Name = "LblAulasTotais";
            this.LblAulasTotais.Size = new System.Drawing.Size(68, 16);
            this.LblAulasTotais.TabIndex = 27;
            this.LblAulasTotais.Text = "Total Aulas:";
            // 
            // TxtTotalAulas
            // 
            this.TxtTotalAulas.Enabled = false;
            this.TxtTotalAulas.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.TxtTotalAulas.Location = new System.Drawing.Point(296, 26);
            this.TxtTotalAulas.Name = "TxtTotalAulas";
            this.TxtTotalAulas.Size = new System.Drawing.Size(65, 21);
            this.TxtTotalAulas.TabIndex = 26;
            // 
            // GpbFinal
            // 
            this.GpbFinal.Controls.Add(this.LblPercentualPresenca);
            this.GpbFinal.Controls.Add(this.LblMedia);
            this.GpbFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbFinal.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbFinal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbFinal.Location = new System.Drawing.Point(385, 50);
            this.GpbFinal.Name = "GpbFinal";
            this.GpbFinal.Size = new System.Drawing.Size(219, 267);
            this.GpbFinal.TabIndex = 23;
            this.GpbFinal.TabStop = false;
            this.GpbFinal.Text = "Média";
            // 
            // LblPercentualPresenca
            // 
            this.LblPercentualPresenca.AutoSize = true;
            this.LblPercentualPresenca.Location = new System.Drawing.Point(18, 78);
            this.LblPercentualPresenca.Name = "LblPercentualPresenca";
            this.LblPercentualPresenca.Size = new System.Drawing.Size(99, 19);
            this.LblPercentualPresenca.TabIndex = 3;
            this.LblPercentualPresenca.Text = "Presença: 0%";
            // 
            // LblMedia
            // 
            this.LblMedia.AutoSize = true;
            this.LblMedia.Location = new System.Drawing.Point(18, 43);
            this.LblMedia.Name = "LblMedia";
            this.LblMedia.Size = new System.Drawing.Size(70, 19);
            this.LblMedia.TabIndex = 2;
            this.LblMedia.Text = "Média: 0";
            // 
            // LblDisciplinaAtual
            // 
            this.LblDisciplinaAtual.AutoSize = true;
            this.LblDisciplinaAtual.Font = new System.Drawing.Font("Century Gothic", 20.25F);
            this.LblDisciplinaAtual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.LblDisciplinaAtual.Location = new System.Drawing.Point(12, 11);
            this.LblDisciplinaAtual.Name = "LblDisciplinaAtual";
            this.LblDisciplinaAtual.Size = new System.Drawing.Size(168, 33);
            this.LblDisciplinaAtual.TabIndex = 10;
            this.LblDisciplinaAtual.Text = "Disciplina @";
            // 
            // GpbNotas
            // 
            this.GpbNotas.Controls.Add(this.TxtFaltas);
            this.GpbNotas.Controls.Add(this.LblFaltasDisciplina);
            this.GpbNotas.Controls.Add(this.TxtNotaAvaliacao);
            this.GpbNotas.Controls.Add(this.LblNotaAvaliacao);
            this.GpbNotas.Controls.Add(this.BtnObterMedia);
            this.GpbNotas.Controls.Add(this.TxtNotaAtividade2);
            this.GpbNotas.Controls.Add(this.LblNotaAtividade2);
            this.GpbNotas.Controls.Add(this.TxtNotaAtividade1);
            this.GpbNotas.Controls.Add(this.LblNotaAtividade1);
            this.GpbNotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbNotas.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbNotas.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbNotas.Location = new System.Drawing.Point(18, 128);
            this.GpbNotas.Name = "GpbNotas";
            this.GpbNotas.Size = new System.Drawing.Size(347, 189);
            this.GpbNotas.TabIndex = 22;
            this.GpbNotas.TabStop = false;
            this.GpbNotas.Text = "Notas";
            // 
            // TxtFaltas
            // 
            this.TxtFaltas.Location = new System.Drawing.Point(183, 102);
            this.TxtFaltas.Name = "TxtFaltas";
            this.TxtFaltas.Size = new System.Drawing.Size(140, 24);
            this.TxtFaltas.TabIndex = 3;
            // 
            // LblFaltasDisciplina
            // 
            this.LblFaltasDisciplina.AutoSize = true;
            this.LblFaltasDisciplina.Location = new System.Drawing.Point(179, 76);
            this.LblFaltasDisciplina.Name = "LblFaltasDisciplina";
            this.LblFaltasDisciplina.Size = new System.Drawing.Size(53, 19);
            this.LblFaltasDisciplina.TabIndex = 10;
            this.LblFaltasDisciplina.Text = "Faltas:";
            // 
            // TxtNotaAvaliacao
            // 
            this.TxtNotaAvaliacao.Location = new System.Drawing.Point(22, 102);
            this.TxtNotaAvaliacao.Name = "TxtNotaAvaliacao";
            this.TxtNotaAvaliacao.Size = new System.Drawing.Size(140, 24);
            this.TxtNotaAvaliacao.TabIndex = 2;
            // 
            // LblNotaAvaliacao
            // 
            this.LblNotaAvaliacao.AutoSize = true;
            this.LblNotaAvaliacao.Location = new System.Drawing.Point(18, 76);
            this.LblNotaAvaliacao.Name = "LblNotaAvaliacao";
            this.LblNotaAvaliacao.Size = new System.Drawing.Size(84, 19);
            this.LblNotaAvaliacao.TabIndex = 8;
            this.LblNotaAvaliacao.Text = "Avaliação:";
            // 
            // BtnObterMedia
            // 
            this.BtnObterMedia.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnObterMedia.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnObterMedia.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnObterMedia.Location = new System.Drawing.Point(22, 132);
            this.BtnObterMedia.Name = "BtnObterMedia";
            this.BtnObterMedia.Size = new System.Drawing.Size(301, 39);
            this.BtnObterMedia.TabIndex = 4;
            this.BtnObterMedia.Text = "Salvar e Obter Média";
            this.BtnObterMedia.UseVisualStyleBackColor = true;
            this.BtnObterMedia.Click += new System.EventHandler(this.BtnObterMedia_Click);
            // 
            // TxtNotaAtividade2
            // 
            this.TxtNotaAtividade2.Location = new System.Drawing.Point(183, 49);
            this.TxtNotaAtividade2.Name = "TxtNotaAtividade2";
            this.TxtNotaAtividade2.Size = new System.Drawing.Size(140, 24);
            this.TxtNotaAtividade2.TabIndex = 1;
            // 
            // LblNotaAtividade2
            // 
            this.LblNotaAtividade2.AutoSize = true;
            this.LblNotaAtividade2.Location = new System.Drawing.Point(179, 23);
            this.LblNotaAtividade2.Name = "LblNotaAtividade2";
            this.LblNotaAtividade2.Size = new System.Drawing.Size(92, 19);
            this.LblNotaAtividade2.TabIndex = 6;
            this.LblNotaAtividade2.Text = "Atividade 2:";
            // 
            // TxtNotaAtividade1
            // 
            this.TxtNotaAtividade1.Location = new System.Drawing.Point(22, 49);
            this.TxtNotaAtividade1.Name = "TxtNotaAtividade1";
            this.TxtNotaAtividade1.Size = new System.Drawing.Size(140, 24);
            this.TxtNotaAtividade1.TabIndex = 0;
            // 
            // LblNotaAtividade1
            // 
            this.LblNotaAtividade1.AutoSize = true;
            this.LblNotaAtividade1.Location = new System.Drawing.Point(18, 23);
            this.LblNotaAtividade1.Name = "LblNotaAtividade1";
            this.LblNotaAtividade1.Size = new System.Drawing.Size(92, 19);
            this.LblNotaAtividade1.TabIndex = 2;
            this.LblNotaAtividade1.Text = "Atividade 1:";
            // 
            // BtnDisciplina1
            // 
            this.BtnDisciplina1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDisciplina1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisciplina1.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnDisciplina1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDisciplina1.Location = new System.Drawing.Point(609, 57);
            this.BtnDisciplina1.Name = "BtnDisciplina1";
            this.BtnDisciplina1.Size = new System.Drawing.Size(170, 39);
            this.BtnDisciplina1.TabIndex = 11;
            this.BtnDisciplina1.Text = "Disciplina 1";
            this.BtnDisciplina1.UseVisualStyleBackColor = true;
            this.BtnDisciplina1.Click += new System.EventHandler(this.BtnDisciplina1_Click);
            // 
            // BtnDisciplina2
            // 
            this.BtnDisciplina2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnDisciplina2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnDisciplina2.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnDisciplina2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnDisciplina2.Location = new System.Drawing.Point(609, 102);
            this.BtnDisciplina2.Name = "BtnDisciplina2";
            this.BtnDisciplina2.Size = new System.Drawing.Size(170, 39);
            this.BtnDisciplina2.TabIndex = 29;
            this.BtnDisciplina2.Text = "Disciplina 2";
            this.BtnDisciplina2.UseVisualStyleBackColor = true;
            this.BtnDisciplina2.Click += new System.EventHandler(this.BtnDisciplina2_Click);
            // 
            // CtrDisciplina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDisciplina2);
            this.Controls.Add(this.BtnDisciplina1);
            this.Controls.Add(this.LblDisciplinaAtual);
            this.Controls.Add(this.lblInfoUsuario);
            this.Controls.Add(this.GpbAluno);
            this.Controls.Add(this.LblAulasTotais);
            this.Controls.Add(this.TxtTotalAulas);
            this.Controls.Add(this.GpbFinal);
            this.Controls.Add(this.GpbNotas);
            this.Name = "CtrDisciplina";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrDisciplina_Load);
            this.GpbAluno.ResumeLayout(false);
            this.GpbAluno.PerformLayout();
            this.GpbFinal.ResumeLayout(false);
            this.GpbFinal.PerformLayout();
            this.GpbNotas.ResumeLayout(false);
            this.GpbNotas.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoUsuario;
        private System.Windows.Forms.GroupBox GpbAluno;
        private System.Windows.Forms.Label LblNomeAluno;
        private System.Windows.Forms.Label LblAulasTotais;
        private System.Windows.Forms.TextBox TxtTotalAulas;
        private System.Windows.Forms.GroupBox GpbFinal;
        private System.Windows.Forms.Label LblPercentualPresenca;
        private System.Windows.Forms.Label LblMedia;
        private System.Windows.Forms.Label LblDisciplinaAtual;
        private System.Windows.Forms.GroupBox GpbNotas;
        private System.Windows.Forms.TextBox TxtFaltas;
        private System.Windows.Forms.Label LblFaltasDisciplina;
        private System.Windows.Forms.TextBox TxtNotaAvaliacao;
        private System.Windows.Forms.Label LblNotaAvaliacao;
        private System.Windows.Forms.Button BtnObterMedia;
        private System.Windows.Forms.TextBox TxtNotaAtividade2;
        private System.Windows.Forms.Label LblNotaAtividade2;
        private System.Windows.Forms.TextBox TxtNotaAtividade1;
        private System.Windows.Forms.Label LblNotaAtividade1;
        private System.Windows.Forms.Button BtnDisciplina1;
        private System.Windows.Forms.Button BtnDisciplina2;
    }
}
