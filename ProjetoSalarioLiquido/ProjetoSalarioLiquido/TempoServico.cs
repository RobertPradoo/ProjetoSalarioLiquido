using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoSalarioLiquido
{
    public class TempoServico
    {
        public float Calcular(float salarioBruto, DateTime admissao, bool trienio, bool quinquenio)
        {
            float resultado = 0;
            int baseTempo = 0;

            if (trienio)
                baseTempo = 3;
            else if (quinquenio)
                baseTempo = 5;

            int anosTrabalhados = (DateTime.Now - admissao).Days / 365;
            int multiplicador = anosTrabalhados / baseTempo;

            if (multiplicador > 0)
            {
                float percentual = 5 * multiplicador;

                if (percentual > 50)
                    percentual = 50;

                resultado = salarioBruto * percentual / 100;
            }

            return resultado;
        }
    }
}
