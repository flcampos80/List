using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List
{
    class Produto
    {
        private int codigo;
        private string descricao;
        private int quantidade;
        private double preco;

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }
        public int Quantidade
        {
            get { return quantidade; }
            set { quantidade = value; }
        }
        public double Preco
        {
            get { return preco; }
            set { preco = value; }
        }

        public Produto(int c, string d, int q, double p)
        {
            this.codigo = c;
            this.descricao = d;
            this.quantidade = q;
            this.preco = p;
        }

        public Produto()
            : this(0, "", 0, 0.0)
        { }

        public double custo()
        {
            return quantidade * preco;
        }
    }
}
