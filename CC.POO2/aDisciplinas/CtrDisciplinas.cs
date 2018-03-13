using CC.POO2.aDisciplinas;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CC.POO2
{
    /// <summary>
    /// Dado o nome de uma disciplina, o total de aulas dadas até o momento e as faltas do aluno, calcular a frequência do aluno.
    /// <para>Posterior ao calculo envie uma mensagem informando se o aluno esta abaixo da frequência esperada(inferior a 75%) ou não.</para>
    /// </summary>
    /// <seealso cref="UserControl" />
    public partial class CtrDisciplina : UserControl
    {
        Disciplina disciplina1;
        Disciplina disciplina2;
        Aluno aluno;
        public int DisciplinaAtual;
        public Color COR_AZUL = Color.FromArgb(0, 0, 64);

        public CtrDisciplina()
        {
            InitializeComponent();
        }

        void CtrDisciplina_Load(object sender, EventArgs e)
        {
            DisciplinaAtual = 1;
            IniciarObjetos();
            AtualizarTextosDisciplinaAtual(1);
        }

        private void IniciarObjetos()
        {
            //Atribuo valor as duas disciplinas criadas.
            disciplina1 = new Disciplina { Nome = "1", QuantidadeAulas = 200 };
            disciplina2 = new Disciplina { Nome = "2", QuantidadeAulas = 400 };

            //Atribuo valor ao objeto aluno da classe Aluno.
            //Dentro dele eu coloco as duas disciplinas que criei na linhas anterior;
            aluno = new Aluno
            {
                AlunoDisciplina = new List<AlunoDisciplina> {
                                                new AlunoDisciplina {Disciplina = disciplina1 },
                                                new AlunoDisciplina {Disciplina = disciplina2 }}
            };

            //Atribuo valores no objeto aluno (nome, sobrenome e idade).
            aluno.NovoAluno();

            //Dentro de cada disciplina que coloquei no aluno, dizemos que o aluno é ele mesmo.
            //Referência circular.
            aluno.AlunoDisciplina.ForEach(x => x.Aluno = aluno);

            AtualizarLabel(LblNomeAluno, null, $"Nome: {aluno.Nome} {aluno.Sobrenome}");
        }

        void RadSaque_CheckedChanged(object sender, EventArgs e)
        {
            BtnObterMedia.Text = "Sacar";
        }

        private void RadDeposito_CheckedChanged(object sender, EventArgs e)
        {
            BtnObterMedia.Text = "Depositar";
        }

        private void BtnAcao_Click(object sender, EventArgs e)
        {
            if (!DadosValidados())
            {
                AtualizarLabel(lblInfoUsuario, Color.Red, "Corrija os valores e tente novamente.");
                AtualizarTextosDisciplinaAtual(DisciplinaAtual);
                return;
            }

            if (AtualizarValoresDisciplina())
            {
                AtualizarMedia();

                //Checa presença e média.
                if (aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == DisciplinaAtual.ToString()).Media >= 5 &&
                    AtualizarPresenca(true) >= 75)
                    AtualizarLabel(lblInfoUsuario, null, "Aluno aprovado.");

                else AtualizarLabel(lblInfoUsuario, Color.Red, "Aluno reprovado.");
            }


        }

        public void AtualizarMedia()
        {
            //A média do aluno é dada pela média das atividades somada a nota da avaliação
            //que em seguida é dividida por dois. 

            var atv1 = Convert.ToDouble(TxtNotaAtividade1.Text);
            var atv2 = Convert.ToDouble(TxtNotaAtividade2.Text);
            var aval = Convert.ToDouble(TxtNotaAvaliacao.Text);

            var mediaFinal = (((atv1 + atv2) / 2) + aval) / 2;

            AtualizarLabel(LblMedia, COR_AZUL, $"Média: {mediaFinal}");

            aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == DisciplinaAtual.ToString()).Media = mediaFinal;
            AtualizarTextosDisciplinaAtual(DisciplinaAtual);
        }

        private double AtualizarPresenca(bool atualizarLabel)
        {
            if (!int.TryParse(TxtTotalAulas.Text, out int totalAulas))
            {
                MensagemErro("Verifique a quantidade total de aulas.");
                return 0;
            }

            if (!int.TryParse(TxtFaltas.Text, out int totalFaltas))
            {
                MensagemErro("Verifique a quantidade total de faltas.");
                return 0;
            }

            if (totalFaltas > aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == DisciplinaAtual.ToString()).Disciplina.QuantidadeAulas)
            {
                MensagemErro("Total de faltas não pode ser maior que a qtde. aulas.");
                return 0;
            }

            var perc = 100 - (((double)totalFaltas / (double)totalAulas) * 100);

            if (atualizarLabel) AtualizarLabel(LblPercentualPresenca, COR_AZUL, $"Presença: {perc.ToString()}%");
            return perc;
        }

        public void AtualizarTextosDisciplinaAtual(int numeroDisciplina)
        {
            try
            {
                var nd = numeroDisciplina.ToString();

                if (numeroDisciplina == 1)
                {
                    //BtnDisciplina1.BackColor = Color.Yellow;
                    //BtnDisciplina2.BackColor = SystemColors.ActiveBorder;
                }
                else if (numeroDisciplina == 2)
                {
                    //BtnDisciplina2.BackColor = Color.Yellow;
                    //BtnDisciplina1.BackColor = SystemColors.ActiveBorder;
                }

                AtualizarLabel(LblDisciplinaAtual, Color.FromArgb(0, 0, 64), $"Disciplina {nd}");
                TxtTotalAulas.Text = aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).Disciplina.QuantidadeAulas.ToString();
                TxtNotaAtividade1.Text = aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAtividade1.ToString();
                TxtNotaAtividade2.Text = aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAtividade2.ToString();
                TxtNotaAvaliacao.Text = aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAvaliacao.ToString();
                TxtFaltas.Text = aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).Faltas.ToString();

                AtualizarLabel(LblMedia, COR_AZUL, $"Média: {aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).Media.ToString()}");
                AtualizarPresenca(true);
                DisciplinaAtual = numeroDisciplina;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public bool AtualizarValoresDisciplina()
        {
            try
            {
                var nd = DisciplinaAtual.ToString();

                aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAtividade1 = Convert.ToDouble(TxtNotaAtividade1.Text);
                aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAtividade2 = Convert.ToDouble(TxtNotaAtividade2.Text);
                aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).NotaAvaliacao = Convert.ToDouble(TxtNotaAvaliacao.Text);
                aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == nd).Faltas = Convert.ToInt32(TxtFaltas.Text);

                AtualizarTextosDisciplinaAtual(DisciplinaAtual);

                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
        }

        public bool DadosValidados()
        {
            return Double.TryParse(TxtNotaAtividade1.Text, out double notaAtividade1) &&
                    Double.TryParse(TxtNotaAtividade2.Text, out double notaAtividade2) &&
                    Double.TryParse(TxtNotaAvaliacao.Text, out double notaAvaliacao) &&
                    Double.TryParse(TxtFaltas.Text, out double faltas) &&
                    notaAtividade1 > -1 && notaAtividade1 < 11 &&
                    notaAtividade2 > -1 && notaAtividade2 < 11 &&
                    notaAvaliacao > -1 && notaAvaliacao < 11 &&
                    faltas > -1;
        }

        public void AtualizarLabel(Label label, Color? cor, string valor = "@", bool visivel = true)
        {
            try
            {
                Task.Factory.StartNew(() =>
                {
                    Invoke((MethodInvoker)delegate
                    {
                        label.Text = valor;
                        label.Visible = visivel;
                        label.ForeColor = cor ?? Color.Green;
                    });
                    Thread.Sleep(100);
                });
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void MensagemErro(string mensagem)
        {
            AtualizarLabel(lblInfoUsuario, Color.Red, $"Erro: {mensagem}", true);
        }
        public void MensagemSucesso(string mensagem)
        {
            AtualizarLabel(lblInfoUsuario, Color.Green, mensagem, true);
        }

        public void EsconderMensagemUsuario()
        {

            Task.Factory.StartNew(() =>
            {
                Invoke((MethodInvoker)delegate
                {
                    lblInfoUsuario.Visible = false;
                });
                Thread.Sleep(100);
            });
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter || keyData == Keys.F5)
                BtnObterMedia.PerformClick();

            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void BtnObterMedia_Click(object sender, EventArgs e)
        {
            if (!DadosValidados())
            {
                AtualizarLabel(lblInfoUsuario, Color.Red, "Corrija os valores e tente novamente.");
                AtualizarTextosDisciplinaAtual(DisciplinaAtual);
                return;
            }

            if (AtualizarValoresDisciplina())
            {
                AtualizarMedia();

                //Checa presença e média.
                if (aluno.AlunoDisciplina.FirstOrDefault(x => x.Disciplina.Nome == DisciplinaAtual.ToString()).Media >= 5 &&
                    AtualizarPresenca(true) >= 75)
                    AtualizarLabel(lblInfoUsuario, null, "Aluno aprovado.");

                else AtualizarLabel(lblInfoUsuario, Color.Red, "Aluno reprovado.");
            }

        }

        private void BtnDisciplina1_Click(object sender, EventArgs e)
        {
            AtualizarTextosDisciplinaAtual(1);
            EsconderMensagemUsuario();
        }

        private void BtnDisciplina2_Click(object sender, EventArgs e)
        {
            AtualizarTextosDisciplinaAtual(2);
            EsconderMensagemUsuario();
        }
    }
}
