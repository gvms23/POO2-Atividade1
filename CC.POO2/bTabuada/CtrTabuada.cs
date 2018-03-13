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
    /// Dado um número inteiro qualquer implementar um programa que calcule a respectiva tabuada.
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class CtrTabuada : UserControl
    {
        public CtrTabuada()
        {
            InitializeComponent();
        }

        private void CtrTabuada_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerResultado_Click(object sender, EventArgs e)
        {
            try
            {
                TxtResultado.Text = string.Empty; //Limpando resultados anteriores

                if (ChkRandom.Checked)
                {
                    TxtNumero.Text = new Random().Next(1, 250).ToString();
                    TxtLimite.Text = new Random().Next(10, 25).ToString();
                }


                if (!int.TryParse(TxtNumero.Text, out int numero) || !int.TryParse(TxtLimite.Text, out int limite))
                    throw new Exception("Somente números inteiros e menores que 1 milhão, por gentileza.");

                if (limite > 1000000 || numero > 1000000)
                    throw new Exception("Ops! Vamos com calma... O limite deve ser até 1 milhão.");

                var resultado = string.Empty;
                var construtorResultado = new StringBuilder();
                construtorResultado.Append(resultado);

                for (var i = 0; i <= limite; i++)
                    construtorResultado.Append($"{numero} x {i} = {numero * i}{Environment.NewLine}");

                resultado = construtorResultado.ToString();

                Task.Factory.StartNew(() =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        TxtResultado.Text = resultado;
                    });
                    Thread.Sleep(100);
                });
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
