using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Boletim
{
    internal class SomatoriaNotas
    {
        public string nome;
        public double nota1;
        public double nota2;
        public double nota3;
        public double media = 60.00;

        public double somatoriaFinal()
        {
            return nota1 + nota2 + nota3;
        }

        public double diferencaPontos()
        {
            return media - somatoriaFinal();
        }
    }
}
