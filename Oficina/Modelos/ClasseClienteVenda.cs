using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oficina.Modelos
{
    class ClasseClienteVenda
    {
        private int idCliente;
        private int idFuncionario;
        private double valorTotalCompra;
        private DateTime dataVenda;
        private double descontoTotal;
        private string formaPagamento;
        private string tipoCadastroCliente;

        private int idVenda;
        private int qtd;
        private double precoVenda;
        private double desconto;
        private string codigoBarras;
        private string descricao;





        public ClasseClienteVenda(int idCliente, int idFuncionario, double valorTotalCompra, DateTime dataVenda, double descontoTotal, string formaPagamento, string tipoCadastroCliente, int idVenda, int qtd, double precoVenda, double desconto, string codigoBarras, string descricao)
        {
            this.idCliente = idCliente;
            this.idFuncionario = idFuncionario;
            this.valorTotalCompra = valorTotalCompra;
            this.dataVenda = dataVenda;
            this.descontoTotal = descontoTotal;
            this.formaPagamento = formaPagamento;
            this.tipoCadastroCliente = tipoCadastroCliente;
            this.idVenda = idVenda;
            this.qtd = qtd;
            this.precoVenda = precoVenda;
            this.desconto = desconto;
            this.codigoBarras = codigoBarras;
            this.descricao = descricao;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public int IdFuncionario { get => idFuncionario; set => idFuncionario = value; }
        public double ValorTotalCompra { get => valorTotalCompra; set => valorTotalCompra = value; }
        public DateTime DataVenda { get => dataVenda; set => dataVenda = value; }
        public double DescontoTotal { get => descontoTotal; set => descontoTotal = value; }
        public string FormaPagamento { get => formaPagamento; set => formaPagamento = value; }
        public string TipoCadastroCliente { get => tipoCadastroCliente; set => tipoCadastroCliente = value; }
        public int IdVenda { get => idVenda; set => idVenda = value; }
        public int Qtd { get => qtd; set => qtd = value; }
        public double PrecoVenda { get => precoVenda; set => precoVenda = value; }
        public double Desconto { get => desconto; set => desconto = value; }
        public string CodigoBarras { get => codigoBarras; set => codigoBarras = value; }
        public string Descricao { get => descricao; set => descricao = value; }
    }
}
