//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Oficina.Modelos
{
    using System;
    using System.Collections.Generic;
    
    public partial class view_itens_venda
    {
        public int idvenda { get; set; }
        public int cliente_idcliente { get; set; }
        public int funcionario_idfuncionario { get; set; }
        public Nullable<double> valor_total_compra { get; set; }
        public Nullable<System.DateTime> data_venda { get; set; }
        public Nullable<double> desconto_total { get; set; }
        public string forma_pagamento { get; set; }
        public string tipo_cliente { get; set; }
        public int itemvendido { get; set; }
        public int venda_idvenda { get; set; }
        public Nullable<int> qtd { get; set; }
        public Nullable<double> preco_venda { get; set; }
        public Nullable<double> desconto { get; set; }
        public string codigo_barras { get; set; }
        public string descricao { get; set; }
    }
}
