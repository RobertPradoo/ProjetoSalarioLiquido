using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoSalarioLiquido
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                if (ValidateForm())
                {
                    float salarioBruto = float.Parse(txtSalarioBruto.Text);
                    float salarioLiquido = 0;
                    float totalDescontos = 0;

                    //Cálculo do desconto do INSS
                    INSS inss = new INSS();
                    inss = inss.CalcularDesconto(salarioBruto);
                    lblDescFaixa1.Text = inss.valorDescontoFaixa1.ToString("n2");
                    lblDescFaixa2.Text = inss.valorDescontoFaixa2.ToString("n2");
                    lblDescFaixa3.Text = inss.valorDescontoFaixa3.ToString("n2");
                    lblDescFaixa4.Text = inss.valorDescontoFaixa4.ToString("n2");
                    lblTotalINSS.Text = inss.valorTotalDescontos.ToString("n2");

                    //Cálulo de outros descontos
                    OutrosDescontos outrosDescontos = new OutrosDescontos();
                    outrosDescontos = outrosDescontos.CalcularDesconto(salarioBruto, cbValeTransporte.Checked, cbValeAlimentacao.Checked, cbPlanoSaude.Checked, cbContribuicaoSindical.Checked);
                    lblDescValeTransporte.Text = outrosDescontos.valorDescontoValeTransporte.ToString("n2");
                    lblDescValeAlimentacao.Text = outrosDescontos.valorDescontoValeAlimentacao.ToString("n2");
                    lblDescPlanoSaude.Text = outrosDescontos.valorDescontoPlanoSaude.ToString("n2");
                    lblDescContribSindical.Text = outrosDescontos.valorDescontoContribSindical.ToString("n2");

                    //Cálculo do desconto do IRRF
                    IRRF irrf = new IRRF();
                    float descontoIRRF = irrf.CalcularDesconto(salarioBruto);
                    lblDescIRRF.Text = descontoIRRF.ToString("n2");

                    //Total de descontos
                    totalDescontos = inss.valorTotalDescontos + outrosDescontos.valorTotalDescontos + descontoIRRF;

                    //Cálculo de acréscimo por tempo de serviço
                    TempoServico tempoServico = new TempoServico();
                    float valorTempoServico = tempoServico.Calcular(salarioBruto, Convert.ToDateTime(txtAdmissao.Text), rbTrienio.Checked, rbQuinquenio.Checked);

                    //Cálculo final do salário líquido
                    salarioLiquido = salarioBruto + valorTempoServico - totalDescontos;

                    txtDescontos.Text = totalDescontos.ToString("n2");
                    txtSalarioLiquido.Text = salarioLiquido.ToString("n2");
                }
                else
                    MessageBox.Show("Salário Bruto inválido, verifique o valor informado e tente novamente");
            }
            catch
            {
                MessageBox.Show("Erro ao tentar calcular");
            }
        }

        private bool ValidateForm()
        {
            bool resultado = true;

            try
            {
                float valorTemp = 0;
                DateTime admissaoTemp;

                if (string.IsNullOrEmpty(txtSalarioBruto.Text))
                    resultado = false;

                else if (!float.TryParse(txtSalarioBruto.Text, out valorTemp))
                    resultado = false;

                else if (valorTemp <= 0)
                    resultado = false;

                else if (string.IsNullOrEmpty(txtAdmissao.Text))
                    resultado = false;

                else if (!DateTime.TryParse(txtAdmissao.Text, out admissaoTemp))
                    resultado = false;

                else if (admissaoTemp > DateTime.Now)
                    resultado = false;
            }
            catch
            {
                resultado = false;
            }

            return resultado;
        }

    }
}
