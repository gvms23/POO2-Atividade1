namespace CC.POO2
{
    partial class CtrEstoqueDGV
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
            this.BtnAddProduto = new System.Windows.Forms.Button();
            this.GpbParâmetros = new System.Windows.Forms.GroupBox();
            this.CboProduto = new System.Windows.Forms.ComboBox();
            this.LblProduto = new System.Windows.Forms.Label();
            this.CboCliente = new System.Windows.Forms.ComboBox();
            this.lblCliente = new System.Windows.Forms.Label();
            this.LblQuantidade = new System.Windows.Forms.Label();
            this.TxtQuantidadeProduto = new System.Windows.Forms.TextBox();
            this.GpbOperacao = new System.Windows.Forms.GroupBox();
            this.BtnLimparLista = new System.Windows.Forms.Button();
            this.BtnRemoverProdutoDGV = new System.Windows.Forms.Button();
            this.LblClienteEscolhido = new System.Windows.Forms.Label();
            this.DgvOperacoes = new System.Windows.Forms.DataGridView();
            this.LblQuantidadeTotal = new System.Windows.Forms.Label();
            this.LblValorTotal = new System.Windows.Forms.Label();
            this.GpbParâmetros.SuspendLayout();
            this.GpbOperacao.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperacoes)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnAddProduto
            // 
            this.BtnAddProduto.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnAddProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAddProduto.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.BtnAddProduto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnAddProduto.Location = new System.Drawing.Point(667, 42);
            this.BtnAddProduto.Name = "BtnAddProduto";
            this.BtnAddProduto.Size = new System.Drawing.Size(75, 27);
            this.BtnAddProduto.TabIndex = 38;
            this.BtnAddProduto.Text = "+ Add";
            this.BtnAddProduto.UseVisualStyleBackColor = true;
            this.BtnAddProduto.Click += new System.EventHandler(this.BtnAddProduto_Click);
            // 
            // GpbParâmetros
            // 
            this.GpbParâmetros.Controls.Add(this.BtnAddProduto);
            this.GpbParâmetros.Controls.Add(this.CboProduto);
            this.GpbParâmetros.Controls.Add(this.LblProduto);
            this.GpbParâmetros.Controls.Add(this.CboCliente);
            this.GpbParâmetros.Controls.Add(this.lblCliente);
            this.GpbParâmetros.Controls.Add(this.LblQuantidade);
            this.GpbParâmetros.Controls.Add(this.TxtQuantidadeProduto);
            this.GpbParâmetros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbParâmetros.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbParâmetros.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbParâmetros.Location = new System.Drawing.Point(24, 15);
            this.GpbParâmetros.Name = "GpbParâmetros";
            this.GpbParâmetros.Size = new System.Drawing.Size(756, 96);
            this.GpbParâmetros.TabIndex = 34;
            this.GpbParâmetros.TabStop = false;
            this.GpbParâmetros.Text = "Parâmetros";
            // 
            // CboProduto
            // 
            this.CboProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboProduto.FormattingEnabled = true;
            this.CboProduto.Location = new System.Drawing.Point(290, 42);
            this.CboProduto.Name = "CboProduto";
            this.CboProduto.Size = new System.Drawing.Size(269, 27);
            this.CboProduto.TabIndex = 41;
            // 
            // LblProduto
            // 
            this.LblProduto.AutoSize = true;
            this.LblProduto.Location = new System.Drawing.Point(286, 20);
            this.LblProduto.Name = "LblProduto";
            this.LblProduto.Size = new System.Drawing.Size(67, 19);
            this.LblProduto.TabIndex = 40;
            this.LblProduto.Text = "Produto:";
            // 
            // CboCliente
            // 
            this.CboCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CboCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CboCliente.FormattingEnabled = true;
            this.CboCliente.Location = new System.Drawing.Point(15, 42);
            this.CboCliente.Name = "CboCliente";
            this.CboCliente.Size = new System.Drawing.Size(269, 27);
            this.CboCliente.TabIndex = 39;
            this.CboCliente.SelectedIndexChanged += new System.EventHandler(this.CboCliente_SelectedIndexChanged);
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(11, 20);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(62, 19);
            this.lblCliente.TabIndex = 2;
            this.lblCliente.Text = "Cliente:";
            // 
            // LblQuantidade
            // 
            this.LblQuantidade.AutoSize = true;
            this.LblQuantidade.Location = new System.Drawing.Point(561, 20);
            this.LblQuantidade.Name = "LblQuantidade";
            this.LblQuantidade.Size = new System.Drawing.Size(100, 19);
            this.LblQuantidade.TabIndex = 6;
            this.LblQuantidade.Text = "Quantidade:";
            // 
            // TxtQuantidadeProduto
            // 
            this.TxtQuantidadeProduto.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.TxtQuantidadeProduto.Location = new System.Drawing.Point(565, 42);
            this.TxtQuantidadeProduto.Name = "TxtQuantidadeProduto";
            this.TxtQuantidadeProduto.Size = new System.Drawing.Size(96, 27);
            this.TxtQuantidadeProduto.TabIndex = 1;
            // 
            // GpbOperacao
            // 
            this.GpbOperacao.Controls.Add(this.LblValorTotal);
            this.GpbOperacao.Controls.Add(this.LblQuantidadeTotal);
            this.GpbOperacao.Controls.Add(this.BtnLimparLista);
            this.GpbOperacao.Controls.Add(this.BtnRemoverProdutoDGV);
            this.GpbOperacao.Controls.Add(this.LblClienteEscolhido);
            this.GpbOperacao.Controls.Add(this.DgvOperacoes);
            this.GpbOperacao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GpbOperacao.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.GpbOperacao.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.GpbOperacao.Location = new System.Drawing.Point(24, 117);
            this.GpbOperacao.Name = "GpbOperacao";
            this.GpbOperacao.Size = new System.Drawing.Size(756, 230);
            this.GpbOperacao.TabIndex = 32;
            this.GpbOperacao.TabStop = false;
            this.GpbOperacao.Text = "Operação";
            // 
            // BtnLimparLista
            // 
            this.BtnLimparLista.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnLimparLista.Enabled = false;
            this.BtnLimparLista.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLimparLista.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.BtnLimparLista.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnLimparLista.Location = new System.Drawing.Point(627, 189);
            this.BtnLimparLista.Name = "BtnLimparLista";
            this.BtnLimparLista.Size = new System.Drawing.Size(114, 27);
            this.BtnLimparLista.TabIndex = 40;
            this.BtnLimparLista.Text = "Limpar Lista";
            this.BtnLimparLista.UseVisualStyleBackColor = true;
            this.BtnLimparLista.Click += new System.EventHandler(this.BtnLimparLista_Click);
            // 
            // BtnRemoverProdutoDGV
            // 
            this.BtnRemoverProdutoDGV.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BtnRemoverProdutoDGV.Enabled = false;
            this.BtnRemoverProdutoDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnRemoverProdutoDGV.Font = new System.Drawing.Font("Century Gothic", 10.25F, System.Drawing.FontStyle.Bold);
            this.BtnRemoverProdutoDGV.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.BtnRemoverProdutoDGV.Location = new System.Drawing.Point(444, 189);
            this.BtnRemoverProdutoDGV.Name = "BtnRemoverProdutoDGV";
            this.BtnRemoverProdutoDGV.Size = new System.Drawing.Size(177, 27);
            this.BtnRemoverProdutoDGV.TabIndex = 39;
            this.BtnRemoverProdutoDGV.Text = "- Remover Produto";
            this.BtnRemoverProdutoDGV.UseVisualStyleBackColor = true;
            this.BtnRemoverProdutoDGV.Click += new System.EventHandler(this.BtnRemoverProdutoDGV_Click);
            // 
            // LblClienteEscolhido
            // 
            this.LblClienteEscolhido.AutoSize = true;
            this.LblClienteEscolhido.Location = new System.Drawing.Point(11, 163);
            this.LblClienteEscolhido.Name = "LblClienteEscolhido";
            this.LblClienteEscolhido.Size = new System.Drawing.Size(147, 19);
            this.LblClienteEscolhido.TabIndex = 3;
            this.LblClienteEscolhido.Text = "Cliente Escolhido: @";
            // 
            // DgvOperacoes
            // 
            this.DgvOperacoes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOperacoes.Location = new System.Drawing.Point(15, 32);
            this.DgvOperacoes.Name = "DgvOperacoes";
            this.DgvOperacoes.ReadOnly = true;
            this.DgvOperacoes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DgvOperacoes.Size = new System.Drawing.Size(727, 128);
            this.DgvOperacoes.TabIndex = 0;
            this.DgvOperacoes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOperacoes_CellClick);
            this.DgvOperacoes.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.DgvOperacoes_RowsAdded);
            this.DgvOperacoes.RowsRemoved += new System.Windows.Forms.DataGridViewRowsRemovedEventHandler(this.DgvOperacoes_RowsRemoved);
            // 
            // LblQuantidadeTotal
            // 
            this.LblQuantidadeTotal.AutoSize = true;
            this.LblQuantidadeTotal.Location = new System.Drawing.Point(11, 201);
            this.LblQuantidadeTotal.Name = "LblQuantidadeTotal";
            this.LblQuantidadeTotal.Size = new System.Drawing.Size(152, 19);
            this.LblQuantidadeTotal.TabIndex = 41;
            this.LblQuantidadeTotal.Text = "Quantidade Total: @";
            // 
            // LblValorTotal
            // 
            this.LblValorTotal.AutoSize = true;
            this.LblValorTotal.Location = new System.Drawing.Point(11, 182);
            this.LblValorTotal.Name = "LblValorTotal";
            this.LblValorTotal.Size = new System.Drawing.Size(100, 19);
            this.LblValorTotal.TabIndex = 42;
            this.LblValorTotal.Text = "Valor Total: @";
            // 
            // CtrEstoqueDGV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.GpbParâmetros);
            this.Controls.Add(this.GpbOperacao);
            this.Name = "CtrEstoqueDGV";
            this.Size = new System.Drawing.Size(803, 368);
            this.Load += new System.EventHandler(this.CtrEstoqueDGV_Load);
            this.GpbParâmetros.ResumeLayout(false);
            this.GpbParâmetros.PerformLayout();
            this.GpbOperacao.ResumeLayout(false);
            this.GpbOperacao.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOperacoes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnAddProduto;
        private System.Windows.Forms.GroupBox GpbParâmetros;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.GroupBox GpbOperacao;
        private System.Windows.Forms.TextBox TxtQuantidadeProduto;
        private System.Windows.Forms.Label LblQuantidade;
        private System.Windows.Forms.ComboBox CboCliente;
        private System.Windows.Forms.ComboBox CboProduto;
        private System.Windows.Forms.Label LblProduto;
        private System.Windows.Forms.Label LblClienteEscolhido;
        private System.Windows.Forms.DataGridView DgvOperacoes;
        private System.Windows.Forms.Button BtnRemoverProdutoDGV;
        private System.Windows.Forms.Button BtnLimparLista;
        private System.Windows.Forms.Label LblValorTotal;
        private System.Windows.Forms.Label LblQuantidadeTotal;
    }
}
