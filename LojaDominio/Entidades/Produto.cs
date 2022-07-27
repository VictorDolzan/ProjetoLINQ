using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoLINQ.LojaDominio.Entidades
{
    public class Produto
    {
        private List<Produto> _produtos;
        public Produto()
        {
            _produtos = new List<Produto>();
        }

        public List<Produto> Listar()
        {
            _produtos.Add(new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Banana",
                Quantidade = 5,
                Valor = 2,
                DataVencimento = DateTime.Now.AddDays(5)
            });
            _produtos.Add(new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Morango",
                Quantidade = 25,
                Valor = 5,
                DataVencimento = DateTime.Now.AddDays(2)
            });
            _produtos.Add(new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Pera",
                Quantidade = 12,
                Valor = 5,
                DataVencimento = DateTime.Now.AddDays(3)
            });
            _produtos.Add(new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Abacaxi",
                Quantidade = 4,
                Valor = 5,
                DataVencimento = DateTime.Now.AddDays(4)
            });
            _produtos.Add(new Produto()
            {
                Id = Guid.NewGuid(),
                Nome = "Melão",
                Quantidade = 35,
                Valor = 5,
                DataVencimento = DateTime.Now.AddDays(10)
            });

            return _produtos;
        }

        public Guid Id { get; set; }
        public string Nome { get; set; }
        public int Quantidade { get; set; }
        public decimal Valor { get; set; }
        public DateTime DataVencimento { get; set; }
    }
}