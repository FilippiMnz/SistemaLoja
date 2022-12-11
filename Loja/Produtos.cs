using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace Loja
{
    class Produto
    {
        
            public string Nome;
            public double Preco;
            public int Quantidade;

        public double ValorTotalEstoque()
        {
            return Preco * Quantidade;
        }

        public void AdcProd(int quantidade)
        {
            Quantidade = Quantidade + quantidade;
        }

        public void RemoverProd(int removedor)
        {
            Quantidade = Quantidade - removedor;
        }

        public override string ToString()
        {
           return Nome 
                + ", $ " 
                + Preco.ToString("F2", CultureInfo.InvariantCulture) 
                + ", " 
                + Quantidade 
                + " Unidadades em estoque, Total: $ " 
                + ValorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
