using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    class ItensVenda
    {
        private int venda_idvenda;
        private int qtd;
        private double preco_venda;
        private double desconto;

        public ItensVenda(int venda_idvenda, int qtd, double preco_venda, double desconto)
        {
            this.venda_idvenda = venda_idvenda;
            this.qtd = qtd;
            this.preco_venda = preco_venda;
            this.desconto = desconto;
        }

        public int Venda_idvenda { get => venda_idvenda; set => venda_idvenda = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public double Preco_venda { get => preco_venda; set => preco_venda = value; }
        public double Desconto { get => desconto; set => desconto = value; }
    }
}
