using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace AtividadeProduto
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalemEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdicaoEstoque(int quantidade)
        {
            Quantidade += quantidade;
        }

        public void RemoverEstoque(int remocao)
        {
            Quantidade -= remocao;
        }

        public string saidaDado()
        {
            return this.Nome + ", R$ " + this.Preco.ToString("N2") + ", " + this.Quantidade + " unidades, R$ " + this.ValorTotalemEstoque().ToString("N2");
        }
    }
}

