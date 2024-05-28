using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalarioLiquido
{
    public class IRRF
    {

        public float CalcularDesconto(float salarioBruto)
        {
            //Objeto de retorno
            float resultado = 0;

            //Percentual de desconto de cada faixa
            float percentFaixa1 = 7.5f;
            float percentFaixa2 = 15f;
            float percentFaixa3 = 22.5f;
            float percentFaixa4 = 27.5f;

            //Valor máximo de cada faixa
            float valorMaxFaixa0 = 1903.98f;
            float valorMaxFaixa1 = 2826.65f;
            float valorMaxFaixa2 = 3751.05f;
            float valorMaxFaixa3 = 4664.68f;

            //Taxa de cada faixa de valores
            float taxaFaixa1 = 142.8f;
            float taxaFaixa2 = 354.8f;
            float taxaFaixa3 = 636.13f;
            float taxaFaixa4 = 869.36f;

            //Cálculo do desconto IRRF
            if (salarioBruto <= valorMaxFaixa0)
                resultado = 0;

            else if (salarioBruto <= valorMaxFaixa1)
                resultado = (salarioBruto * percentFaixa1 / 100) - taxaFaixa1;
            
            else if (salarioBruto <= valorMaxFaixa2)
                resultado = (salarioBruto * percentFaixa2 / 100) - taxaFaixa2;

            else if (salarioBruto <= valorMaxFaixa3)
                resultado = (salarioBruto * percentFaixa3 / 100) - taxaFaixa3;

            else
                resultado = (salarioBruto * percentFaixa4 / 100) - taxaFaixa4;

            if (resultado < 0)
                resultado = 0;

            return resultado;
        }
    }
}
