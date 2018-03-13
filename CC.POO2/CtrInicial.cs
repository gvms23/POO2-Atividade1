using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace CC.POO2
{
    public partial class CtrInicial : UserControl
    {
        public CtrInicial()
        {
            InitializeComponent();
        }

        private void CtrInicial_Load(object sender, EventArgs e)
        {

        }

        private void BtnIrSitePessoal_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Você irá para o site: https://gabrielvicente.ch, deseja continuar?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                Process.Start("https://gabrielvicente.ch");
        }
    }
}
