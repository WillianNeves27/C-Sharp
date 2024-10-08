using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace SalarioFuncionario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = new Funcionario();
            Console.Write("Nome: ");
            funcionario.Nome = Console.ReadLine();
            Console.Write("Salario: ");
            funcionario.SalarioBruto = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Imposto: ");
            funcionario.Imposto = double.Parse(Console.ReadLine());
            Console.WriteLine("Funcionário: " + funcionario.SaidaDado());
            Console.WriteLine("-------------------------------");
            Console.Write("Aumento de Salário (Porcentagem): ");
            double Porcentagem = double.Parse(Console.ReadLine());
            funcionario.AumentoSalario(Porcentagem);
            Console.WriteLine("-------------------------------");
            Console.WriteLine("Dados Atualizados: " + funcionario.SaidaDado());
        }
    }
}
