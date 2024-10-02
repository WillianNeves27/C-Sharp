using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadeProduto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            Console.WriteLine("Entre os dados do Produto:");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine());
            Console.Write("Quantidade no Estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());
            Console.Write("Dados do Produto: " + p.saidaDado());
            Console.WriteLine("-----------------------------");
            Console.Write("Digite o número de produtos a serem adicionados ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.AdicaoEstoque(qte);
            Console.WriteLine("Dados atualizados: " + p.saidaDado());
            Console.WriteLine("-----------------------------");
            Console.Write("Digite o número de produtos a serem removidos do estoque: ");
            int retiradaEtq = int.Parse(Console.ReadLine());
            p.RemoverEstoque(retiradaEtq);
            Console.WriteLine("Dados atualizados: " + p.saidaDado());
        }
    }
}
