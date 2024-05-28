using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalarioLiquido
{
    public class OutrosDescontos
    {
        public float valorDescontoValeTransporte { get; set; }
        public float valorDescontoValeAlimentacao { get; set; }
        public float valorDescontoPlanoSaude { get; set; }
        public float valorDescontoContribSindical { get; set; }
        public float valorTotalDescontos { get; set; }

        public OutrosDescontos CalcularDesconto(float salarioBruto, bool valeTransporte, bool valeAlimentacao, bool planoSaude, bool contribuicaoSindical )
        {
            OutrosDescontos resultado = new OutrosDescontos();

            if (valeTransporte)
                resultado.valorDescontoValeTransporte = salarioBruto * 6f / 100;

            if (valeAlimentacao)
                resultado.valorDescontoValeAlimentacao = salarioBruto * 3.5f / 100;

            if (planoSaude)
                resultado.valorDescontoPlanoSaude = 116;

            if (contribuicaoSindical)
                resultado.valorDescontoContribSindical = 143.15f;

            resultado.valorTotalDescontos = resultado.valorDescontoValeTransporte + resultado.valorDescontoValeAlimentacao + resultado.valorDescontoPlanoSaude + resultado.valorDescontoContribSindical;

            return resultado;
        }
    }
}
