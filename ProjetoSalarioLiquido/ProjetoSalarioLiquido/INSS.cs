using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalarioLiquido
{
    public class INSS
    {
        public float valorDescontoFaixa1 { get; set; }
        public float valorDescontoFaixa2 { get; set; }
        public float valorDescontoFaixa3 { get; set; }
        public float valorDescontoFaixa4 { get; set; }
        public float valorTotalDescontos { get; set; }
        public float valorSalarioLiquido { get; set; }

        public INSS CalcularDesconto(float salarioBruto)
        {
            //Objeto de retorno
            INSS resultado = new INSS();

            //Percentual de desconto de cada faixa
            float percentFaixa1 = 7.5f;
            float percentFaixa2 = 9f;
            float percentFaixa3 = 12f;
            float percentFaixa4 = 14f;

            //Valor máximo do salário bruto em cada faixa
            float valorMaxFaixa1 = 1212f;
            float valorMaxFaixa2 = 2427.35f;
            float valorMaxFaixa3 = 3641.03f;
            float valorMaxFaixa4 = 7087.22f;

            //Desconto máximo em cada faixa
            float valorDescMaxFaixa1 = 90.90f;
            float valorDescMaxFaixa2 = 109.38f;
            float valorDescMaxFaixa3 = 145.64f;
            float valorDescMaxFaixa4 = 482.47f;

            //Valor descontado em cada faixa
            float valorDescFaixa1 = 0;
            float valorDescFaixa2 = 0;
            float valorDescFaixa3 = 0;
            float valorDescFaixa4 = 0;

            //Total de descontos em todas as faixas
            float valorTotalDesc = 0;

            //Cálculo da Faixa 1
            if (salarioBruto <= valorMaxFaixa1)
                valorDescFaixa1 = salarioBruto * percentFaixa1 / 100;

            else
            {
                valorDescFaixa1 = valorDescMaxFaixa1;

                //Cálculo da Faixa 2
                if (salarioBruto <= valorMaxFaixa2)
                    valorDescFaixa2 = (salarioBruto - valorMaxFaixa1) * percentFaixa2 / 100;

                else
                {
                    valorDescFaixa2 = valorDescMaxFaixa2;

                    //Cálculo da Faixa 3
                    if (salarioBruto <= valorMaxFaixa3)
                        valorDescFaixa3 = (salarioBruto - valorMaxFaixa2) * percentFaixa3 / 100;

                    else
                    {
                        valorDescFaixa3 = valorDescMaxFaixa3;

                        //Cálculo da Faixa 4
                        if (salarioBruto <= valorMaxFaixa4)
                            valorDescFaixa4 = (salarioBruto - valorMaxFaixa3) * percentFaixa4 / 100;

                        else
                        {
                            valorDescFaixa4 = valorDescMaxFaixa4;
                        }
                    }
                }
            }

            resultado.valorDescontoFaixa1 = valorDescFaixa1;
            resultado.valorDescontoFaixa2 = valorDescFaixa2;
            resultado.valorDescontoFaixa3 = valorDescFaixa3;
            resultado.valorDescontoFaixa4 = valorDescFaixa4;

            valorTotalDesc = valorDescFaixa1 + valorDescFaixa2 + valorDescFaixa3 + valorDescFaixa4;

            resultado.valorTotalDescontos = valorTotalDesc;
            resultado.valorSalarioLiquido = salarioBruto - valorTotalDesc;

            return resultado;
        }

    }
}
