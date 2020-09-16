using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    class ClienteVenda
    {
        //CLIENTE
        private string tipoCliente;
        private string formaPagamento;
        private string nomeCliente;
        //VENDA
        private string descricao;
        private string codigoBarras;
        private Double valorUnitario;
        private Double qtd;
        private Double desconto;

        public ClienteVenda(string tipoCliente, string formaPagamento, string nomeCliente, string descricao, string codigoBarras, Double valorUnitario, Double qtd, Double desconto)
        {
            this.tipoCliente = tipoCliente;
            this.formaPagamento = formaPagamento;
            this.nomeCliente = nomeCliente;
            this.descricao = descricao;
            this.codigoBarras = codigoBarras;
            this.valorUnitario = valorUnitario;
            this.qtd = qtd;
            this.desconto = desconto;
        }

        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public Double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public Double Qtd { get => qtd; set => qtd = value; }
        public Double Desconto { get => desconto; set => desconto = value; }
    }
}
