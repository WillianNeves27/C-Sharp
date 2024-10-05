using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace ExFixacaoClasseAtributosMetodo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Retangulo retangulo = new Retangulo();
            Console.WriteLine("Ente com a largura e altura do Retangulo: ");
            Console.Write("Largura: ");
            retangulo.Largura = double.Parse(Console.ReadLine());
            Console.Write("Altura: ");
            retangulo.Altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Área = " + retangulo.Area().ToString("N2", CultureInfo.InvariantCulture));
            Console.WriteLine("Perímetro = " + retangulo.Perimetro().ToString("N2", CultureInfo.InvariantCulture));
            Console.WriteLine("Diagonal = " + retangulo.Diagonal().ToString("N2", CultureInfo.InvariantCulture)) ;
            Console.ReadKey();
        }
    }
}
