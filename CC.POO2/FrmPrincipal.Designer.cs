namespace CC.POO2
{
    partial class FrmPrincipal
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.lblInfoGlobal = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.LnkVisitarSite = new System.Windows.Forms.LinkLabel();
            this.LblAutor = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panLateral = new System.Windows.Forms.Panel();
            this.Btn1cVagaTI = new System.Windows.Forms.Button();
            this.Btn1bTabuada = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.SidePanel = new System.Windows.Forms.Panel();
            this.BtnInicio = new System.Windows.Forms.Button();
            this.Btn1dAlunosDGV = new System.Windows.Forms.Button();
            this.Btn1eEstoqueDGV = new System.Windows.Forms.Button();
            this.Btn1aDisciplinas = new System.Windows.Forms.Button();
            this.BtnSair = new System.Windows.Forms.Button();
            this.BtnConfiguracoes = new System.Windows.Forms.Button();
            this.BtnLinkedin = new System.Windows.Forms.Button();
            this.BtnFacebook = new System.Windows.Forms.Button();
            this.ctrAlunosDGV1 = new CC.POO2.CtrAlunosDGV();
            this.ctrVagaTI1 = new CC.POO2.CtrVagaTI();
            this.ctrTabuada1 = new CC.POO2.CtrTabuada();
            this.ctrInicial1 = new CC.POO2.CtrInicial();
            this.ctrDisciplina1 = new CC.POO2.CtrDisciplina();
            this.ctrEstoqueDGV1 = new CC.POO2.CtrEstoqueDGV();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblInfoGlobal
            // 
            this.lblInfoGlobal.AutoSize = true;
            this.lblInfoGlobal.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Bold);
            this.lblInfoGlobal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.lblInfoGlobal.Location = new System.Drawing.Point(461, 99);
            this.lblInfoGlobal.Name = "lblInfoGlobal";
            this.lblInfoGlobal.Size = new System.Drawing.Size(356, 26);
            this.lblInfoGlobal.TabIndex = 18;
            this.lblInfoGlobal.Text = "Atividades POO2 | Aulas 1, 2 e 3";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel3.Controls.Add(this.LnkVisitarSite);
            this.panel3.Controls.Add(this.LblAutor);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Location = new System.Drawing.Point(234, 1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(142, 173);
            this.panel3.TabIndex = 17;
            // 
            // LnkVisitarSite
            // 
            this.LnkVisitarSite.ActiveLinkColor = System.Drawing.Color.WhiteSmoke;
            this.LnkVisitarSite.AutoSize = true;
            this.LnkVisitarSite.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.LnkVisitarSite.Cursor = System.Windows.Forms.Cursors.Hand;
            this.LnkVisitarSite.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.LnkVisitarSite.LinkColor = System.Drawing.Color.White;
            this.LnkVisitarSite.Location = new System.Drawing.Point(36, 145);
            this.LnkVisitarSite.Name = "LnkVisitarSite";
            this.LnkVisitarSite.Size = new System.Drawing.Size(71, 17);
            this.LnkVisitarSite.TabIndex = 6;
            this.LnkVisitarSite.TabStop = true;
            this.LnkVisitarSite.Text = "Visitar Site";
            this.LnkVisitarSite.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LnkVisitarSite_LinkClicked);
            // 
            // LblAutor
            // 
            this.LblAutor.AutoSize = true;
            this.LblAutor.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold);
            this.LblAutor.ForeColor = System.Drawing.Color.White;
            this.LblAutor.Location = new System.Drawing.Point(8, 126);
            this.LblAutor.Name = "LblAutor";
            this.LblAutor.Size = new System.Drawing.Size(130, 19);
            this.LblAutor.TabIndex = 5;
            this.LblAutor.Text = "Gabriel Vicente";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::CC.POO2.Properties.Resources.mascote_gv;
            this.pictureBox2.Location = new System.Drawing.Point(14, 9);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(117, 116);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(214, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(804, 10);
            this.panel2.TabIndex = 16;
            // 
            // panLateral
            // 
            this.panLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(39)))), ((int)(((byte)(40)))));
            this.panLateral.Controls.Add(this.Btn1cVagaTI);
            this.panLateral.Controls.Add(this.Btn1bTabuada);
            this.panLateral.Controls.Add(this.button14);
            this.panLateral.Controls.Add(this.SidePanel);
            this.panLateral.Controls.Add(this.BtnInicio);
            this.panLateral.Controls.Add(this.Btn1dAlunosDGV);
            this.panLateral.Controls.Add(this.Btn1eEstoqueDGV);
            this.panLateral.Controls.Add(this.Btn1aDisciplinas);
            this.panLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panLateral.Location = new System.Drawing.Point(0, 0);
            this.panLateral.Name = "panLateral";
            this.panLateral.Size = new System.Drawing.Size(214, 556);
            this.panLateral.TabIndex = 15;
            // 
            // Btn1cVagaTI
            // 
            this.Btn1cVagaTI.FlatAppearance.BorderSize = 0;
            this.Btn1cVagaTI.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1cVagaTI.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1cVagaTI.ForeColor = System.Drawing.Color.White;
            this.Btn1cVagaTI.Image = ((System.Drawing.Image)(resources.GetObject("Btn1cVagaTI.Image")));
            this.Btn1cVagaTI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1cVagaTI.Location = new System.Drawing.Point(12, 248);
            this.Btn1cVagaTI.Name = "Btn1cVagaTI";
            this.Btn1cVagaTI.Size = new System.Drawing.Size(197, 54);
            this.Btn1cVagaTI.TabIndex = 17;
            this.Btn1cVagaTI.Text = "     1-c) Vaga TI";
            this.Btn1cVagaTI.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1cVagaTI.UseVisualStyleBackColor = true;
            this.Btn1cVagaTI.Click += new System.EventHandler(this.Btn1cVagaTI_Click);
            // 
            // Btn1bTabuada
            // 
            this.Btn1bTabuada.FlatAppearance.BorderSize = 0;
            this.Btn1bTabuada.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1bTabuada.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1bTabuada.ForeColor = System.Drawing.Color.White;
            this.Btn1bTabuada.Image = ((System.Drawing.Image)(resources.GetObject("Btn1bTabuada.Image")));
            this.Btn1bTabuada.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1bTabuada.Location = new System.Drawing.Point(12, 188);
            this.Btn1bTabuada.Name = "Btn1bTabuada";
            this.Btn1bTabuada.Size = new System.Drawing.Size(197, 54);
            this.Btn1bTabuada.TabIndex = 16;
            this.Btn1bTabuada.Text = "     1-b) Tabuada";
            this.Btn1bTabuada.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1bTabuada.UseVisualStyleBackColor = true;
            this.Btn1bTabuada.Click += new System.EventHandler(this.Btn1bTabuada_Click);
            // 
            // button14
            // 
            this.button14.FlatAppearance.BorderSize = 0;
            this.button14.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button14.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button14.ForeColor = System.Drawing.Color.White;
            this.button14.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button14.Location = new System.Drawing.Point(3, 546);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(36, 34);
            this.button14.TabIndex = 15;
            this.button14.Text = "?";
            this.button14.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button14.UseVisualStyleBackColor = true;
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(178)))), ((int)(((byte)(8)))), ((int)(((byte)(55)))));
            this.SidePanel.Location = new System.Drawing.Point(1, 68);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(10, 54);
            this.SidePanel.TabIndex = 7;
            // 
            // BtnInicio
            // 
            this.BtnInicio.FlatAppearance.BorderSize = 0;
            this.BtnInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnInicio.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnInicio.ForeColor = System.Drawing.Color.White;
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnInicio.Location = new System.Drawing.Point(12, 66);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(197, 54);
            this.BtnInicio.TabIndex = 14;
            this.BtnInicio.Text = "       Início";
            this.BtnInicio.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnInicio.UseVisualStyleBackColor = true;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // Btn1dAlunosDGV
            // 
            this.Btn1dAlunosDGV.FlatAppearance.BorderSize = 0;
            this.Btn1dAlunosDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1dAlunosDGV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1dAlunosDGV.ForeColor = System.Drawing.Color.White;
            this.Btn1dAlunosDGV.Image = ((System.Drawing.Image)(resources.GetObject("Btn1dAlunosDGV.Image")));
            this.Btn1dAlunosDGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1dAlunosDGV.Location = new System.Drawing.Point(12, 308);
            this.Btn1dAlunosDGV.Name = "Btn1dAlunosDGV";
            this.Btn1dAlunosDGV.Size = new System.Drawing.Size(197, 54);
            this.Btn1dAlunosDGV.TabIndex = 12;
            this.Btn1dAlunosDGV.Text = "     1-d) Alunos DGV";
            this.Btn1dAlunosDGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1dAlunosDGV.UseVisualStyleBackColor = true;
            this.Btn1dAlunosDGV.Click += new System.EventHandler(this.Btn1dAlunosDGV_Click);
            // 
            // Btn1eEstoqueDGV
            // 
            this.Btn1eEstoqueDGV.FlatAppearance.BorderSize = 0;
            this.Btn1eEstoqueDGV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1eEstoqueDGV.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1eEstoqueDGV.ForeColor = System.Drawing.Color.White;
            this.Btn1eEstoqueDGV.Image = ((System.Drawing.Image)(resources.GetObject("Btn1eEstoqueDGV.Image")));
            this.Btn1eEstoqueDGV.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1eEstoqueDGV.Location = new System.Drawing.Point(12, 368);
            this.Btn1eEstoqueDGV.Name = "Btn1eEstoqueDGV";
            this.Btn1eEstoqueDGV.Size = new System.Drawing.Size(197, 54);
            this.Btn1eEstoqueDGV.TabIndex = 11;
            this.Btn1eEstoqueDGV.Text = "     1-e) Estoque DGV";
            this.Btn1eEstoqueDGV.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1eEstoqueDGV.UseVisualStyleBackColor = true;
            this.Btn1eEstoqueDGV.Click += new System.EventHandler(this.Btn1eEstoqueDGV_Click);
            // 
            // Btn1aDisciplinas
            // 
            this.Btn1aDisciplinas.FlatAppearance.BorderSize = 0;
            this.Btn1aDisciplinas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn1aDisciplinas.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn1aDisciplinas.ForeColor = System.Drawing.Color.White;
            this.Btn1aDisciplinas.Image = ((System.Drawing.Image)(resources.GetObject("Btn1aDisciplinas.Image")));
            this.Btn1aDisciplinas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Btn1aDisciplinas.Location = new System.Drawing.Point(12, 128);
            this.Btn1aDisciplinas.Name = "Btn1aDisciplinas";
            this.Btn1aDisciplinas.Size = new System.Drawing.Size(197, 54);
            this.Btn1aDisciplinas.TabIndex = 8;
            this.Btn1aDisciplinas.Text = "     1-a) Disciplinas";
            this.Btn1aDisciplinas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Btn1aDisciplinas.UseVisualStyleBackColor = true;
            this.Btn1aDisciplinas.Click += new System.EventHandler(this.Btn1aDisciplinas_Click);
            // 
            // BtnSair
            // 
            this.BtnSair.FlatAppearance.BorderSize = 0;
            this.BtnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnSair.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnSair.ForeColor = System.Drawing.Color.White;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnSair.Location = new System.Drawing.Point(969, 12);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(35, 35);
            this.BtnSair.TabIndex = 19;
            this.BtnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnSair.UseVisualStyleBackColor = true;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
            // 
            // BtnConfiguracoes
            // 
            this.BtnConfiguracoes.FlatAppearance.BorderSize = 0;
            this.BtnConfiguracoes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnConfiguracoes.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConfiguracoes.ForeColor = System.Drawing.Color.White;
            this.BtnConfiguracoes.Image = ((System.Drawing.Image)(resources.GetObject("BtnConfiguracoes.Image")));
            this.BtnConfiguracoes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnConfiguracoes.Location = new System.Drawing.Point(902, 12);
            this.BtnConfiguracoes.Name = "BtnConfiguracoes";
            this.BtnConfiguracoes.Size = new System.Drawing.Size(36, 36);
            this.BtnConfiguracoes.TabIndex = 20;
            this.BtnConfiguracoes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnConfiguracoes.UseVisualStyleBackColor = true;
            this.BtnConfiguracoes.Visible = false;
            // 
            // BtnLinkedin
            // 
            this.BtnLinkedin.FlatAppearance.BorderSize = 0;
            this.BtnLinkedin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnLinkedin.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnLinkedin.ForeColor = System.Drawing.Color.White;
            this.BtnLinkedin.Image = ((System.Drawing.Image)(resources.GetObject("BtnLinkedin.Image")));
            this.BtnLinkedin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnLinkedin.Location = new System.Drawing.Point(860, 12);
            this.BtnLinkedin.Name = "BtnLinkedin";
            this.BtnLinkedin.Size = new System.Drawing.Size(36, 36);
            this.BtnLinkedin.TabIndex = 21;
            this.BtnLinkedin.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnLinkedin.UseVisualStyleBackColor = true;
            this.BtnLinkedin.Visible = false;
            // 
            // BtnFacebook
            // 
            this.BtnFacebook.FlatAppearance.BorderSize = 0;
            this.BtnFacebook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnFacebook.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnFacebook.ForeColor = System.Drawing.Color.White;
            this.BtnFacebook.Image = ((System.Drawing.Image)(resources.GetObject("BtnFacebook.Image")));
            this.BtnFacebook.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnFacebook.Location = new System.Drawing.Point(382, 11);
            this.BtnFacebook.Name = "BtnFacebook";
            this.BtnFacebook.Size = new System.Drawing.Size(36, 36);
            this.BtnFacebook.TabIndex = 22;
            this.BtnFacebook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnFacebook.UseVisualStyleBackColor = true;
            this.BtnFacebook.Click += new System.EventHandler(this.BtnFacebook_Click);
            // 
            // ctrAlunosDGV1
            // 
            this.ctrAlunosDGV1.Location = new System.Drawing.Point(214, 188);
            this.ctrAlunosDGV1.Name = "ctrAlunosDGV1";
            this.ctrAlunosDGV1.Size = new System.Drawing.Size(803, 368);
            this.ctrAlunosDGV1.TabIndex = 27;
            // 
            // ctrVagaTI1
            // 
            this.ctrVagaTI1.Location = new System.Drawing.Point(214, 188);
            this.ctrVagaTI1.Name = "ctrVagaTI1";
            this.ctrVagaTI1.Size = new System.Drawing.Size(803, 368);
            this.ctrVagaTI1.TabIndex = 26;
            // 
            // ctrTabuada1
            // 
            this.ctrTabuada1.Location = new System.Drawing.Point(214, 188);
            this.ctrTabuada1.Name = "ctrTabuada1";
            this.ctrTabuada1.Size = new System.Drawing.Size(803, 368);
            this.ctrTabuada1.TabIndex = 25;
            // 
            // ctrInicial1
            // 
            this.ctrInicial1.Location = new System.Drawing.Point(214, 188);
            this.ctrInicial1.Name = "ctrInicial1";
            this.ctrInicial1.Size = new System.Drawing.Size(803, 368);
            this.ctrInicial1.TabIndex = 24;
            // 
            // ctrDisciplina1
            // 
            this.ctrDisciplina1.Location = new System.Drawing.Point(214, 188);
            this.ctrDisciplina1.Name = "ctrDisciplina1";
            this.ctrDisciplina1.Size = new System.Drawing.Size(803, 368);
            this.ctrDisciplina1.TabIndex = 23;
            // 
            // ctrEstoqueDGV1
            // 
            this.ctrEstoqueDGV1.Location = new System.Drawing.Point(214, 188);
            this.ctrEstoqueDGV1.Name = "ctrEstoqueDGV1";
            this.ctrEstoqueDGV1.Size = new System.Drawing.Size(803, 368);
            this.ctrEstoqueDGV1.TabIndex = 28;
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 556);
            this.Controls.Add(this.ctrEstoqueDGV1);
            this.Controls.Add(this.ctrAlunosDGV1);
            this.Controls.Add(this.ctrVagaTI1);
            this.Controls.Add(this.ctrTabuada1);
            this.Controls.Add(this.ctrInicial1);
            this.Controls.Add(this.ctrDisciplina1);
            this.Controls.Add(this.lblInfoGlobal);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.BtnConfiguracoes);
            this.Controls.Add(this.BtnLinkedin);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.BtnFacebook);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panLateral);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panLateral.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfoGlobal;
        private System.Windows.Forms.Button BtnSair;
        private System.Windows.Forms.Button BtnConfiguracoes;
        private System.Windows.Forms.Button BtnLinkedin;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.LinkLabel LnkVisitarSite;
        private System.Windows.Forms.Label LblAutor;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button BtnFacebook;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panLateral;
        private System.Windows.Forms.Button Btn1cVagaTI;
        private System.Windows.Forms.Button Btn1bTabuada;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Button BtnInicio;
        private System.Windows.Forms.Button Btn1dAlunosDGV;
        private System.Windows.Forms.Button Btn1eEstoqueDGV;
        private System.Windows.Forms.Button Btn1aDisciplinas;
        private CtrDisciplina ctrDisciplina1;
        private CtrInicial ctrInicial1;
        private CtrTabuada ctrTabuada1;
        private CtrVagaTI ctrVagaTI1;
        private CtrAlunosDGV ctrAlunosDGV1;
        private CtrEstoqueDGV ctrEstoqueDGV1;
    }
}

