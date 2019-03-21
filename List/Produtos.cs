using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Produtos
    {
        List<Produto> listaProdutos = new List<Produto>();

        internal List<Produto> ListaProdutos
        {
            get { return listaProdutos; }
            set { listaProdutos = value; }
        }

        public void adicionar(Produto p)
        {
            listaProdutos.Add(p);
        }
        public bool remover(Produto p)
        {
            return (listaProdutos.Remove(p));
        }
        public Produto pesquisar(Produto p)
        {
            Produto resultado = new Produto();
            foreach (Produto prod in this.ListaProdutos)
            {
                if (prod.Equals(p))
                    resultado = p;
            }

            return resultado;
        }

        public double custoTotal()
        {
            double cTotal = 0.0;
            foreach (Produto p in ListaProdutos)
            {
                cTotal += p.custo();
            }

            return cTotal;
        }
    }
}
