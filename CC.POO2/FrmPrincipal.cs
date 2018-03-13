using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace CC.POO2
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void Btn1aDisciplinas_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn1aDisciplinas.Height;
            SidePanel.Top = Btn1aDisciplinas.Top;
            ctrDisciplina1.BringToFront();
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            SidePanel.Height = BtnInicio.Height;
            SidePanel.Top = BtnInicio.Top;
            ctrInicial1.BringToFront();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            SidePanel.Height = BtnInicio.Height;
            SidePanel.Top = BtnInicio.Top;
            ctrInicial1.BringToFront();
        }

        private void Btn1bTabuada_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn1bTabuada.Height;
            SidePanel.Top = Btn1bTabuada.Top;
            ctrTabuada1.BringToFront();
        }
        private void Btn1cVagaTI_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn1cVagaTI.Height;
            SidePanel.Top = Btn1cVagaTI.Top;
            ctrVagaTI1.BringToFront();
        }

        private void Btn1dAlunosDGV_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn1dAlunosDGV.Height;
            SidePanel.Top = Btn1dAlunosDGV.Top;
            ctrAlunosDGV1.BringToFront();
        }

        private void Btn1eEstoqueDGV_Click(object sender, EventArgs e)
        {
            SidePanel.Height = Btn1eEstoqueDGV.Height;
            SidePanel.Top = Btn1eEstoqueDGV.Top;
            ctrEstoqueDGV1.BringToFront();
        }
        private void BtnSair_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja Realmente sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Application.Exit();

        }

        private void LnkVisitarSite_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            VisitarLink("https://gabrielvicente.ch");
        }

        private void BtnFacebook_Click(object sender, EventArgs e)
        {
            VisitarLink("https://fb.me/gvms23");
        }


        public void VisitarLink(string url)
        {
            if (MessageBox.Show($"Você irá para o site: {url}, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start(url);
        }
    }
}
