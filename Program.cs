using System;
using System.Linq;
using ProjetoLINQ.LojaDominio.Entidades;

namespace ProjetoLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            // int[] numeros = {1, 2, 3, 4, 5, 6, 7, 8, 9, 10};
            // int[] numeros2 = {1, 7, 8, 9, 2, 3, 4, 5, 6, 10};

            // var resultado = from num in numeros
            //                 where num > 4
            //                 select num;

            // var resultado2 = from num in numeros2   
            //                  where num > 4
            //                  orderby num
            //                  select num; 

            // var resultadoOrdenado = numeros2
            //                         .Where(x => x > 4).OrderBy(n => n);

            // foreach (var n in resultadoOrdenado)
            // {
            //     Console.WriteLine(n);
            // }

            // // foreach (var n in numeros.Where(x => x > 4))
            // // {
            // //     Console.WriteLine(n);                
            // // }

            // Console.ReadKey();

            // string[] cores = {"Preto", "Branco", "Verde", "Vermelho", "Azul"};

            // var resultadoCores = cores.Where(x => x.Contains("e") || x.Contains("z"));

            // foreach (var c in resultadoCores)
            // {
            //     Console.WriteLine(c);
            // }

            // var produto = new Produto();

            // var produtos = produto.Listar().Where(p => p.Valor > 4).OrderBy(x => x.Valor);

            // foreach (var itemP in produtos)
            // {
            //     Console.WriteLine(itemP.Nome);
            // }

            new Produto().Listar().Where(p => p.Valor > 4).ToList().ForEach(i => 
            {
                Console.WriteLine(i.Nome);
                Console.WriteLine(i.Valor);
            });

            Console.ReadKey();
        }
    }
}
