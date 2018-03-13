using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace CC.POO2
{
    /// <summary>
    ///
    ///Implemente um programa em C# Windows Form que analisa a seleção de candidatos a uma vaga na área de TI.
    ///
    ///<para>Regra para seleção:</para>
    ///<para>- Conhecer Linux e Android;</para>
    ///<para>- Conhecer C# ou Java;</para>
    ///<para>- Conhecer Mysql e Sql Server</para>
    ///<para>Mostrar uma mensagem "você foi selecionado para a vaga na área de TI", quando o candidato for selecionado.</para>
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class CtrVagaTI : UserControl
    {
        public CtrVagaTI()
        {
            InitializeComponent();
        }

        private void CtrVagaTI_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerResultado_Click(object sender, EventArgs e)
        {
            try
            {
                if (TxtNome.Text == string.Empty)
                    throw new Exception("Preencha seu nome para continuar.");
                
                if (CandidatoSelecionado())
                    MessageBox.Show($"Parabéns, {TxtNome.Text}! Você foi selecionado para a vaga na área de TI", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show($"Poxa, {TxtNome.Text}... Infelizmente você não foi selecionado para a vaga, mas não desista!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        public bool CandidatoSelecionado()
        {
            return ChkSOLinux.Checked &&
                ChkSOAndroid.Checked &&
                (ChkLPCSharp.Checked || ChkLPJava.Checked) &&
                ChkBDMySQL.Checked && ChkBDSQLServer.Checked;
        }
    }
}
