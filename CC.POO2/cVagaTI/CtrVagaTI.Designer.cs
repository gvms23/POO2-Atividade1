namespace CC.POO2
{
    partial class CtrVagaTI
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
            this.GpbParametrosPessoais = new System.Windows.Forms.GroupBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.LblNome = new System.Windows.Forms.Label();
            this.gpbCurso = new System.Windows.Forms.GroupBox();
            this.radCursoEngenhariaComputacao = new System.Windows.Forms.RadioButton();
            this.radCursoCienciaComputacao = new System.Windows.Forms.RadioButton();
            this.gpbSO = new System.Windows.Forms.GroupBox();
            this.ChkSOAndroid = new System.Windows.Forms.CheckBox();
            this.ChkSOLinux = new System.Windows.Forms.CheckBox();
            this.ChkSOWindows = new System.Windows.Forms.CheckBox();
            this.gpbLinguagensProgramacao = new System.Windows.Forms.GroupBox();
            this.ChkLPJava = new System.Windows.Forms.CheckBox();
            this.ChkLPPHP = new System.Windows.Forms.CheckBox();
            this.ChkLPCSharp = new System.Windows.Forms.CheckBox();
            this.GpbBancoDados = new System.Windows.Forms.GroupBox();
            this.ChkBDPostgreSQL = new System.Windows.Forms.CheckBox();
            this.ChkBDSQLServer = new System.Windows.Forms.CheckBox();
            this.ChkBDMySQL = new System.Windows.Forms.CheckBox();
            this.BtnVerResultado = new System.Windows.Forms.Button();
            this.GpbParametrosPessoais.SuspendLayout();
            this.gpbCurso.SuspendLayout();
            this.gpbSO.SuspendLayout();
            this.gpbLinguagensProgramacao.SuspendLayout();
            this.GpbBancoDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbParametrosPessoais
            // 
            this.GpbParametrosPessoais.Controls.Add(this.TxtNome);
            this.GpbParametrosPessoais.Controls.Add(this.LblNome);
            this.GpbParametrosPessoais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbParametrosPessoais.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbParametrosPessoais.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbParametrosPessoais.Location = new System.Drawing.Point(22, 11);
            this.GpbParametrosPessoais.Name = "GpbParametrosPessoais";
            this.GpbParametrosPessoais.Size = new System.Drawing.Size(397, 75);
            this.GpbParametrosPessoais.TabIndex = 27;
            this.GpbParametrosPessoais.TabStop = false;
            this.GpbParametrosPessoais.Text = "Informações Pessoais";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(72, 31);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(293, 24);
            this.TxtNome.TabIndex = 3;
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Location = new System.Drawing.Point(12, 34);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(54, 19);
            this.LblNome.TabIndex = 2;
            this.LblNome.Text = "Nome:";
            // 
            // gpbCurso
            // 
            this.gpbCurso.Controls.Add(this.radCursoEngenhariaComputacao);
            this.gpbCurso.Controls.Add(this.radCursoCienciaComputacao);
            this.gpbCurso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbCurso.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.gpbCurso.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gpbCurso.Location = new System.Drawing.Point(22, 92);
            this.gpbCurso.Name = "gpbCurso";
            this.gpbCurso.Size = new System.Drawing.Size(481, 61);
            this.gpbCurso.TabIndex = 28;
            this.gpbCurso.TabStop = false;
            this.gpbCurso.Text = "Curso Matriculado";
            // 
            // radCursoEngenhariaComputacao
            // 
            this.radCursoEngenhariaComputacao.AutoSize = true;
            this.radCursoEngenhariaComputacao.Location = new System.Drawing.Point(236, 23);
            this.radCursoEngenhariaComputacao.Name = "radCursoEngenhariaComputacao";
            this.radCursoEngenhariaComputacao.Size = new System.Drawing.Size(230, 23);
            this.radCursoEngenhariaComputacao.TabIndex = 1;
            this.radCursoEngenhariaComputacao.TabStop = true;
            this.radCursoEngenhariaComputacao.Text = "Engenharia da Computação";
            this.radCursoEngenhariaComputacao.UseVisualStyleBackColor = true;
            // 
            // radCursoCienciaComputacao
            // 
            this.radCursoCienciaComputacao.AutoSize = true;
            this.radCursoCienciaComputacao.Location = new System.Drawing.Point(26, 23);
            this.radCursoCienciaComputacao.Name = "radCursoCienciaComputacao";
            this.radCursoCienciaComputacao.Size = new System.Drawing.Size(204, 23);
            this.radCursoCienciaComputacao.TabIndex = 0;
            this.radCursoCienciaComputacao.TabStop = true;
            this.radCursoCienciaComputacao.Text = "Ciência da Computação";
            this.radCursoCienciaComputacao.UseVisualStyleBackColor = true;
            // 
            // gpbSO
            // 
            this.gpbSO.Controls.Add(this.ChkSOAndroid);
            this.gpbSO.Controls.Add(this.ChkSOLinux);
            this.gpbSO.Controls.Add(this.ChkSOWindows);
            this.gpbSO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbSO.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.gpbSO.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gpbSO.Location = new System.Drawing.Point(22, 159);
            this.gpbSO.Name = "gpbSO";
            this.gpbSO.Size = new System.Drawing.Size(481, 61);
            this.gpbSO.TabIndex = 29;
            this.gpbSO.TabStop = false;
            this.gpbSO.Text = "SO que tem conhecimentos";
            // 
            // ChkSOAndroid
            // 
            this.ChkSOAndroid.AutoSize = true;
            this.ChkSOAndroid.Location = new System.Drawing.Point(334, 23);
            this.ChkSOAndroid.Name = "ChkSOAndroid";
            this.ChkSOAndroid.Size = new System.Drawing.Size(82, 23);
            this.ChkSOAndroid.TabIndex = 2;
            this.ChkSOAndroid.Text = "Android";
            this.ChkSOAndroid.UseVisualStyleBackColor = true;
            // 
            // ChkSOLinux
            // 
            this.ChkSOLinux.AutoSize = true;
            this.ChkSOLinux.Location = new System.Drawing.Point(196, 23);
            this.ChkSOLinux.Name = "ChkSOLinux";
            this.ChkSOLinux.Size = new System.Drawing.Size(62, 23);
            this.ChkSOLinux.TabIndex = 1;
            this.ChkSOLinux.Text = "Linux";
            this.ChkSOLinux.UseVisualStyleBackColor = true;
            // 
            // ChkSOWindows
            // 
            this.ChkSOWindows.AutoSize = true;
            this.ChkSOWindows.Location = new System.Drawing.Point(26, 23);
            this.ChkSOWindows.Name = "ChkSOWindows";
            this.ChkSOWindows.Size = new System.Drawing.Size(91, 23);
            this.ChkSOWindows.TabIndex = 0;
            this.ChkSOWindows.Text = "Windows";
            this.ChkSOWindows.UseVisualStyleBackColor = true;
            // 
            // gpbLinguagensProgramacao
            // 
            this.gpbLinguagensProgramacao.Controls.Add(this.ChkLPJava);
            this.gpbLinguagensProgramacao.Controls.Add(this.ChkLPPHP);
            this.gpbLinguagensProgramacao.Controls.Add(this.ChkLPCSharp);
            this.gpbLinguagensProgramacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gpbLinguagensProgramacao.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.gpbLinguagensProgramacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.gpbLinguagensProgramacao.Location = new System.Drawing.Point(22, 226);
            this.gpbLinguagensProgramacao.Name = "gpbLinguagensProgramacao";
            this.gpbLinguagensProgramacao.Size = new System.Drawing.Size(481, 61);
            this.gpbLinguagensProgramacao.TabIndex = 30;
            this.gpbLinguagensProgramacao.TabStop = false;
            this.gpbLinguagensProgramacao.Text = "Linguagens de Programação que tem conhecimento";
            // 
            // ChkLPJava
            // 
            this.ChkLPJava.AutoSize = true;
            this.ChkLPJava.Location = new System.Drawing.Point(334, 23);
            this.ChkLPJava.Name = "ChkLPJava";
            this.ChkLPJava.Size = new System.Drawing.Size(63, 23);
            this.ChkLPJava.TabIndex = 2;
            this.ChkLPJava.Text = "Java";
            this.ChkLPJava.UseVisualStyleBackColor = true;
            // 
            // ChkLPPHP
            // 
            this.ChkLPPHP.AutoSize = true;
            this.ChkLPPHP.Location = new System.Drawing.Point(196, 23);
            this.ChkLPPHP.Name = "ChkLPPHP";
            this.ChkLPPHP.Size = new System.Drawing.Size(54, 23);
            this.ChkLPPHP.TabIndex = 1;
            this.ChkLPPHP.Text = "PHP";
            this.ChkLPPHP.UseVisualStyleBackColor = true;
            // 
            // ChkLPCSharp
            // 
            this.ChkLPCSharp.AutoSize = true;
            this.ChkLPCSharp.Location = new System.Drawing.Point(26, 23);
            this.ChkLPCSharp.Name = "ChkLPCSharp";
            this.ChkLPCSharp.Size = new System.Drawing.Size(49, 23);
            this.ChkLPCSharp.TabIndex = 0;
            this.ChkLPCSharp.Text = "C#";
            this.ChkLPCSharp.UseVisualStyleBackColor = true;
            // 
            // GpbBancoDados
            // 
            this.GpbBancoDados.Controls.Add(this.ChkBDPostgreSQL);
            this.GpbBancoDados.Controls.Add(this.ChkBDSQLServer);
            this.GpbBancoDados.Controls.Add(this.ChkBDMySQL);
            this.GpbBancoDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbBancoDados.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbBancoDados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbBancoDados.Location = new System.Drawing.Point(425, 11);
            this.GpbBancoDados.Name = "GpbBancoDados";
            this.GpbBancoDados.Size = new System.Drawing.Size(328, 75);
            this.GpbBancoDados.TabIndex = 31;
            this.GpbBancoDados.TabStop = false;
            this.GpbBancoDados.Text = "Bancos de Dados que tem conhecimento";
            // 
            // ChkBDPostgreSQL
            // 
            this.ChkBDPostgreSQL.AutoSize = true;
            this.ChkBDPostgreSQL.Location = new System.Drawing.Point(151, 23);
            this.ChkBDPostgreSQL.Name = "ChkBDPostgreSQL";
            this.ChkBDPostgreSQL.Size = new System.Drawing.Size(102, 23);
            this.ChkBDPostgreSQL.TabIndex = 2;
            this.ChkBDPostgreSQL.Text = "PostgreSQL";
            this.ChkBDPostgreSQL.UseVisualStyleBackColor = true;
            // 
            // ChkBDSQLServer
            // 
            this.ChkBDSQLServer.AutoSize = true;
            this.ChkBDSQLServer.Location = new System.Drawing.Point(26, 46);
            this.ChkBDSQLServer.Name = "ChkBDSQLServer";
            this.ChkBDSQLServer.Size = new System.Drawing.Size(98, 23);
            this.ChkBDSQLServer.TabIndex = 1;
            this.ChkBDSQLServer.Text = "SQL Server";
            this.ChkBDSQLServer.UseVisualStyleBackColor = true;
            // 
            // ChkBDMySQL
            // 
            this.ChkBDMySQL.AutoSize = true;
            this.ChkBDMySQL.Location = new System.Drawing.Point(26, 23);
            this.ChkBDMySQL.Name = "ChkBDMySQL";
            this.ChkBDMySQL.Size = new System.Drawing.Size(74, 23);
            this.ChkBDMySQL.TabIndex = 0;
            this.ChkBDMySQL.Text = "MySQL";
            this.ChkBDMySQL.UseVisualStyleBackColor = true;
            // 
            // BtnVerResultado
            // 
            this.BtnVerResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVerResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerResultado.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnVerResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnVerResultado.Location = new System.Drawing.Point(258, 293);
            this.BtnVerResultado.Name = "BtnVerResultado";
            this.BtnVerResultado.Size = new System.Drawing.Size(244, 54);
            this.BtnVerResultado.TabIndex = 32;
            this.BtnVerResultado.Text = "Ver Resultado";
            this.BtnVerResultado.UseVisualStyleBackColor = true;
            this.BtnVerResultado.Click += new System.EventHandler(this.BtnVerResultado_Click);
            // 
            // CtrVagaTI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVerResultado);
            this.Controls.Add(this.GpbBancoDados);
            this.Controls.Add(this.gpbLinguagensProgramacao);
            this.Controls.Add(this.gpbSO);
            this.Controls.Add(this.gpbCurso);
            this.Controls.Add(this.GpbParametrosPessoais);
            this.Name = "CtrVagaTI";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrVagaTI_Load);
            this.GpbParametrosPessoais.ResumeLayout(false);
            this.GpbParametrosPessoais.PerformLayout();
            this.gpbCurso.ResumeLayout(false);
            this.gpbCurso.PerformLayout();
            this.gpbSO.ResumeLayout(false);
            this.gpbSO.PerformLayout();
            this.gpbLinguagensProgramacao.ResumeLayout(false);
            this.gpbLinguagensProgramacao.PerformLayout();
            this.GpbBancoDados.ResumeLayout(false);
            this.GpbBancoDados.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbParametrosPessoais;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.GroupBox gpbCurso;
        private System.Windows.Forms.RadioButton radCursoEngenhariaComputacao;
        private System.Windows.Forms.RadioButton radCursoCienciaComputacao;
        private System.Windows.Forms.GroupBox gpbSO;
        private System.Windows.Forms.CheckBox ChkSOAndroid;
        private System.Windows.Forms.CheckBox ChkSOLinux;
        private System.Windows.Forms.CheckBox ChkSOWindows;
        private System.Windows.Forms.GroupBox gpbLinguagensProgramacao;
        private System.Windows.Forms.CheckBox ChkLPJava;
        private System.Windows.Forms.CheckBox ChkLPPHP;
        private System.Windows.Forms.CheckBox ChkLPCSharp;
        private System.Windows.Forms.GroupBox GpbBancoDados;
        private System.Windows.Forms.CheckBox ChkBDPostgreSQL;
        private System.Windows.Forms.CheckBox ChkBDSQLServer;
        private System.Windows.Forms.CheckBox ChkBDMySQL;
        private System.Windows.Forms.Button BtnVerResultado;
    }
}
