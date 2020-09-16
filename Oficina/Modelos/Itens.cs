using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    class Itens
    {
        //PRODUTO
        private string descricao;
        private string codigoBarras;
        private string valorUnitario;
        private string qtd;
        private string desconto;
        //CLIENTE
        private string tipoCliente;
        private string formaPagamento;
        private string nomeCliente;
        //SERVIÇO
        private string servicoMecanico;
        private string servicoDescricao;
        private double servicoValor;
        private DateTime data;

        private int tipoVenda;

        //Construtor de produtos
        public Itens(string descricao, string codigoBarras, string valorUnitario, string qtd, string desconto, DateTime data)
        {
            this.descricao = descricao;
            this.codigoBarras = codigoBarras;
            this.valorUnitario = valorUnitario;
            this.qtd = qtd;
            this.desconto = desconto;
        }

        public Itens(string descricao, string codigoBarras, string valorUnitario, string qtd, string desconto, string tipoCliente, string formaPagamento)
        {
            this.descricao = descricao;
            this.codigoBarras = codigoBarras;
            this.valorUnitario = valorUnitario;
            this.qtd = qtd;
            this.desconto = desconto;
            this.tipoCliente = tipoCliente;
            this.formaPagamento = formaPagamento;
        }

        //Construtor de produtos e cliente
        public Itens(string descricao, string codigoBarras, string valorUnitario, string qtd, string desconto, string tipoCliente, string formaPagamento, string nomeCliente)
        {
            this.descricao = descricao;
            this.codigoBarras = codigoBarras;
            this.valorUnitario = valorUnitario;
            this.qtd = qtd;
            this.desconto = desconto;
            this.tipoCliente = tipoCliente;
            this.formaPagamento = formaPagamento;
            this.nomeCliente = nomeCliente;
        }

        //Construtor de produtos, cliente e serviço
        //public Itens(string descricao, string codigoBarras, string valorUnitario, string qtd, string desconto, string tipoCliente, string formaPagamento, string nomeCliente)
        //{
        //    this.descricao = descricao;
        //    this.codigoBarras = codigoBarras;
        //    this.valorUnitario = valorUnitario;
        //    this.qtd = qtd;
        //    this.desconto = desconto;
        //    this.tipoCliente = tipoCliente;
        //    this.formaPagamento = formaPagamento;
        //    this.nomeCliente = nomeCliente;
        //}

        public string Descricao { get => descricao; set => descricao = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public string ValorUnitario { get => valorUnitario; set => valorUnitario = value; }
        public string Qtd { get => qtd; set => qtd = value; }
        public string Desconto { get => desconto; set => desconto = value; }
        public string TipoCliente { get => tipoCliente; set => tipoCliente = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string ServicoMecanico { get => servicoMecanico; set => servicoMecanico = value; }
        public string ServicoDescricao { get => servicoDescricao; set => servicoDescricao = value; }
        public double ServicoValor { get => servicoValor; set => servicoValor = value; }
        public DateTime Data { get => data; set => data = value; }
    }
}
