using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    class ClienteVendaServico
    {
        //PRODUTO
        private string descricao;
        private string codigoBarras;
        private double valorUnitario;
        private double qtd;
        private double desconto;
        //CLIENTE
        private string tipoCliente;
        private string formaPagamento;
        private string nomeCliente;
        //SERVIÇO
        private string servicoMecanico;
        private string servicoDescricao;
        private double servicoValor;
        private DateTime data;

        public ClienteVendaServico(string descricao, string codigoBarras, double valorUnitario, double qtd, double desconto, string tipoCliente, string formaPagamento, string nomeCliente, string servicoMecanico, string servicoDescricao, double servicoValor, DateTime data)
        {
            this.descricao = descricao;
            this.codigoBarras = codigoBarras;
            this.valorUnitario = valorUnitario;
            this.qtd = qtd;
            this.desconto = desconto;
            this.tipoCliente = tipoCliente;
            this.formaPagamento = formaPagamento;
            this.nomeCliente = nomeCliente;
            this.servicoMecanico = servicoMecanico;
            this.servicoDescricao = servicoDescricao;
            this.servicoValor = servicoValor;
            this.data = data;
        }

        public string Descricao { get => descricao; set => descricao = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public double ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public double Qtd { get => qtd; set => qtd = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string ServicoMecanico { get => servicoMecanico; set => servicoMecanico = value; }
        public string ServicoDescricao { get => servicoDescricao; set => servicoDescricao = value; }
        public double ServicoValor { get => servicoValor; set => servicoValor = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
