using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioFuncionario
{
    internal class Funcionario
    {
        public string Nome;
        public double SalarioBruto;
        public double Imposto;

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }

        public void AumentoSalario(double Porcentagem)
        {
            SalarioBruto = SalarioBruto + (SalarioBruto * Porcentagem / 100);
        }

        public string SaidaDado()
        {
            return this.Nome + ", " + "R$" + this.SalarioLiquido().ToString("N2");
        }
    }
}
