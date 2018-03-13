namespace CC.POO2
{
    partial class CtrTabuada
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
            this.GpbParametros = new System.Windows.Forms.GroupBox();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.LblLimite = new System.Windows.Forms.Label();
            this.TxtNumero = new System.Windows.Forms.TextBox();
            this.LblNumero = new System.Windows.Forms.Label();
            this.GpbResultado = new System.Windows.Forms.GroupBox();
            this.TxtResultado = new System.Windows.Forms.TextBox();
            this.BtnVerResultado = new System.Windows.Forms.Button();
            this.ChkRandom = new System.Windows.Forms.CheckBox();
            this.GpbParametros.SuspendLayout();
            this.GpbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // GpbParametros
            // 
            this.GpbParametros.Controls.Add(this.ChkRandom);
            this.GpbParametros.Controls.Add(this.TxtLimite);
            this.GpbParametros.Controls.Add(this.LblLimite);
            this.GpbParametros.Controls.Add(this.TxtNumero);
            this.GpbParametros.Controls.Add(this.LblNumero);
            this.GpbParametros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbParametros.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbParametros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbParametros.Location = new System.Drawing.Point(47, 80);
            this.GpbParametros.Name = "GpbParametros";
            this.GpbParametros.Size = new System.Drawing.Size(272, 134);
            this.GpbParametros.TabIndex = 26;
            this.GpbParametros.TabStop = false;
            this.GpbParametros.Text = "Parâmetros";
            // 
            // TxtLimite
            // 
            this.TxtLimite.Location = new System.Drawing.Point(91, 61);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(147, 24);
            this.TxtLimite.TabIndex = 5;
            // 
            // LblLimite
            // 
            this.LblLimite.AutoSize = true;
            this.LblLimite.Location = new System.Drawing.Point(33, 64);
            this.LblLimite.Name = "LblLimite";
            this.LblLimite.Size = new System.Drawing.Size(52, 19);
            this.LblLimite.TabIndex = 4;
            this.LblLimite.Text = "Limite:";
            // 
            // TxtNumero
            // 
            this.TxtNumero.Location = new System.Drawing.Point(91, 31);
            this.TxtNumero.Name = "TxtNumero";
            this.TxtNumero.Size = new System.Drawing.Size(147, 24);
            this.TxtNumero.TabIndex = 3;
            // 
            // LblNumero
            // 
            this.LblNumero.AutoSize = true;
            this.LblNumero.Location = new System.Drawing.Point(18, 34);
            this.LblNumero.Name = "LblNumero";
            this.LblNumero.Size = new System.Drawing.Size(67, 19);
            this.LblNumero.TabIndex = 2;
            this.LblNumero.Text = "Número:";
            // 
            // GpbResultado
            // 
            this.GpbResultado.Controls.Add(this.TxtResultado);
            this.GpbResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbResultado.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbResultado.Location = new System.Drawing.Point(344, 80);
            this.GpbResultado.Name = "GpbResultado";
            this.GpbResultado.Size = new System.Drawing.Size(395, 201);
            this.GpbResultado.TabIndex = 27;
            this.GpbResultado.TabStop = false;
            this.GpbResultado.Text = "Resultado";
            // 
            // TxtResultado
            // 
            this.TxtResultado.Location = new System.Drawing.Point(23, 29);
            this.TxtResultado.Multiline = true;
            this.TxtResultado.Name = "TxtResultado";
            this.TxtResultado.ReadOnly = true;
            this.TxtResultado.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.TxtResultado.Size = new System.Drawing.Size(349, 150);
            this.TxtResultado.TabIndex = 6;
            // 
            // BtnVerResultado
            // 
            this.BtnVerResultado.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnVerResultado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnVerResultado.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.BtnVerResultado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnVerResultado.Location = new System.Drawing.Point(149, 220);
            this.BtnVerResultado.Name = "BtnVerResultado";
            this.BtnVerResultado.Size = new System.Drawing.Size(170, 39);
            this.BtnVerResultado.TabIndex = 28;
            this.BtnVerResultado.Text = "Ver Resultado";
            this.BtnVerResultado.UseVisualStyleBackColor = true;
            this.BtnVerResultado.Click += new System.EventHandler(this.BtnVerResultado_Click);
            // 
            // ChkRandom
            // 
            this.ChkRandom.AutoSize = true;
            this.ChkRandom.Checked = true;
            this.ChkRandom.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ChkRandom.Font = new System.Drawing.Font("Century Gothic", 8.25F);
            this.ChkRandom.Location = new System.Drawing.Point(6, 108);
            this.ChkRandom.Name = "ChkRandom";
            this.ChkRandom.Size = new System.Drawing.Size(74, 20);
            this.ChkRandom.TabIndex = 29;
            this.ChkRandom.Text = "Random";
            this.ChkRandom.UseVisualStyleBackColor = true;
            // 
            // CtrTabuada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnVerResultado);
            this.Controls.Add(this.GpbResultado);
            this.Controls.Add(this.GpbParametros);
            this.Name = "CtrTabuada";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrTabuada_Load);
            this.GpbParametros.ResumeLayout(false);
            this.GpbParametros.PerformLayout();
            this.GpbResultado.ResumeLayout(false);
            this.GpbResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GpbParametros;
        private System.Windows.Forms.TextBox TxtLimite;
        private System.Windows.Forms.Label LblLimite;
        private System.Windows.Forms.TextBox TxtNumero;
        private System.Windows.Forms.Label LblNumero;
        private System.Windows.Forms.GroupBox GpbResultado;
        private System.Windows.Forms.TextBox TxtResultado;
        private System.Windows.Forms.Button BtnVerResultado;
        private System.Windows.Forms.CheckBox ChkRandom;
    }
}
