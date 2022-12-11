using Loja;
using System;
using System.Globalization;
namespace Lojinha
{
    class Program
    {
        static void Main(string[] args)
        {

            Produto p = new Produto();
            Console.WriteLine("Insira o Nome do produto");
            Console.Write("Nome: ");
            p.Nome = Console.ReadLine();
            Console.WriteLine("Insira o preço do produto ");
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Insira a Quantidade no Estoque: ");
            Console.Write("Quantidade: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            Console.WriteLine("Dados do produto: " + p);

            Console.WriteLine("Digite a Quantidade de Produtos a serem adicionados ao estoque");
            int estoque2 = int.Parse(Console.ReadLine());
            p.AdcProd(estoque2);
            Console.WriteLine("Dados Atualizados" + p);

            Console.WriteLine("Digite a quantidade a ser retirada de estoque: ");
            int removerEstoque = int.Parse(Console.ReadLine()); 
            p.RemoverProd(removerEstoque);
            Console.WriteLine("Dados atualizados " + p);

        }
    }
}   