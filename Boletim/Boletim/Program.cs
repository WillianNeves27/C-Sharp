using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Boletim
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SomatoriaNotas nota = new SomatoriaNotas();
            Console.Write("Nome do Aluno: ");
            nota.nome = Console.ReadLine();
            Console.Write("Nota 1º trimestre: ");
            nota.nota1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 2º trimestre: ");
            nota.nota2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Nota 3º trimestre: ");
            nota.nota3 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Nota Final = " + nota.somatoriaFinal());

            if (nota.somatoriaFinal() > nota.media)
            {
                Console.WriteLine("Aprovado!");
            }
            else
            {
                Console.WriteLine("Reprovado!");
                Console.WriteLine("Faltaram " + nota.diferencaPontos().ToString("F2") + " pontos");
            }
        }
    }
}
