using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Oficina.Modelos;

//TESTE 220420201355 - GERANDO
//ESSAS SAO AS BIBLIOTECAS QUE DEVEREMOS ADICIONAR EM NOSSO PROJETO
using System.IO;// A BIBLIOTECA DE ENTRADA E SAIDA DE ARQUIVOS
using iTextSharp;//E A BIBLIOTECA ITEXTSHARP E SUAS EXTENÇÕES
using iTextSharp.text;//ESTENSAO 1 (TEXT)
using iTextSharp.text.pdf;//ESTENSAO 2 (PDF)

namespace Oficina
{
    public partial class FrmVenda : Form
    {
        private string codigoDeBarrasAuxiliar = "";
        private string codigoDeBarrasDataGrid = "";
        private List<ClasseServico> cs = new List<ClasseServico>();
        private List<ClasseClienteVenda> ccv = new List<ClasseClienteVenda>();
        private List<ClasseClienteVendaServico> ccvs = new List<ClasseClienteVendaServico>();

        //VARIÁVEL GLOBAL
        itens_vendidos iv = new itens_vendidos();
        venda v = new venda();

        //VARIÁVEIS ESPECIAIS PARA CONTABILIZAÇÃO
        private double valorTotalCompra;         //
        private double descontoTotaldaCompra;   //
        private int controleEstoque = 0;

        private int flagVenda = -1;
        private int codigoVenda = -1;
        int qtd, qtdCompra;
        bool vendaLiberada = true;

        //SELEÇÃO DE USUÁRIO
        private int idUsuarioSelecionado = 0;
        cliente clienteSel;
         
        public FrmVenda()
        {
            InitializeComponent();
            ListarMecanicos();
        }

        private void txtCodigoBarras_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCodigoBarras.Text != "")
                {
                    using (var bd = new oficinaEntities())
                    {
                        string codigoComparacao = txtCodigoBarras.Text;
                        produto p = (from pr in bd.produto
                                     where pr.codigo_barras == codigoComparacao
                                     select pr).FirstOrDefault();

                        //var idEstoque = p.estoque_idestoque;
                        //MessageBox.Show(idEstoque.ToString());

                        //estoque etq = (from et in bd.estoque
                        //             where et.idestoque == p.estoque_idestoque
                        //             select et).FirstOrDefault();

                        //var qtd = etq.qtd_estoque;

                        //MessageBox.Show(qtd.ToString());

                        if (p != null && p.estado == "Disponível")
                        {
                            codigoDeBarrasDataGrid = txtCodigoBarras.Text;
                            var idEstoque = p.estoque_idestoque;
                            //MessageBox.Show(idEstoque.ToString());

                            estoque etq = (from et in bd.estoque
                                           where et.idestoque == p.estoque_idestoque
                                           select et).FirstOrDefault();

                            var qtd = etq.qtd_estoque;

                            txtQtdEmEstoque.Text = qtd.ToString();

                            DesbloquearLabels();

                            if (radAVista.Checked)
                            {
                                txtProduto.Text = p.descricao;
                                txtValorUnitario.Text = p.valor_avista.ToString();
                                txtQtd.Text = 1.ToString();
                                txtQtd.Focus();
                            }
                            else
                            {
                                txtDesconto.Enabled = false;
                                txtProduto.Text = p.descricao;
                                txtValorUnitario.Text = p.valor_prazo.ToString();
                                txtQtd.Text = 1.ToString();
                                txtQtd.Focus();
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não há informações sobre o objeto desejado. Por favor, entre em contato com o programador.");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Código do produto não informado.");
                }
            }
        }

        private void ListarMecanicos()
        {
            using (var bd = new oficinaEntities())
            {
                cmbMecanico.DataSource = bd.mecanico.ToList();
            }
            cmbMecanico.SelectedIndex = -1;
        }
        private void DesbloquearLabels()
        {
            txtProduto.Enabled = true;
            txtValorUnitario.Enabled = true;
            txtQtd.Enabled = true;
            txtDesconto.Enabled = true;
        }

        //private void ListarMecanicos()
        //{
        //    using (var bd = new oficinaEntities())
        //    {
        //        cmbMecanico.DataSource = bd.mecanico.ToList();
        //    }
        //}

        private void btnInserir_Click(object sender, EventArgs e)
        {
            InserirItemVenda();
        }
        private void InserirItemVenda()
        {
            using (var bd = new oficinaEntities())
            {
                if (ValidarServico() && !ValidarCliente() && !ValidarVenda())
                {
                    servico s = new servico();
                    Servico(s);
                    //bd.servico.Add(s);
                    //bd.SaveChanges();
                    //itens.Add(new Itens(cmbMecanico.Text, richTxtBoxDescricao.Text, double.Parse(txtValorServico.Text), DateTime.Now));
                    cs.Add(new ClasseServico(cmbMecanico.Text, richTxtBoxDescricao.Text, double.Parse(txtValorServico.Text), DateTime.Now));
                    dgvVenda.DataSource = cs.ToList();
                    //MessageBox.Show("Entrou no Serviço!");

                }
                else  if (!ValidarServico() && ValidarCliente() && ValidarVenda())
                {
                    VendaProdutos(bd);
                    //bd.SaveChanges();
                    if (vendaLiberada)
                    {
                        //produto p = (from pr in bd.produto
                        //             where pr.codigo_barras == txtCodigoBarras.Text
                        //             select pr).FirstOrDefault();

                        //var idEstoque = p.estoque_idestoque;
                        //MessageBox.Show(idEstoque.ToString());

                        //estoque etq = (from et in bd.estoque
                        //             where et.idestoque == p.estoque_idestoque
                        //             select et).FirstOrDefault();

                        //var qtd = etq.qtd_estoque;

                        //MessageBox.Show(qtd.ToString());

                        string pagamento, tipoCliente;
                        if (radAPrazo.Checked)
                        {
                            pagamento = "À Vista";
                        }
                        else
                        {
                            pagamento = "A Prazo";
                        }
                        if (radCadastrado.Checked)
                        {
                            tipoCliente = "Cadastrado";
                        }
                        else
                        {
                            tipoCliente = "Não Cadastrado";
                        }


                        //MessageBox.Show("Data de Venda: "+v.data_venda.ToString()); 21/04/2020
                        //MessageBox.Show("Quantidade: "+iv.qtd.ToString()); 21/04/2020
                        //MessageBox.Show("Código de Barra: " + codigoDeBarrasDataGrid); 21/04/2020
                        //MessageBox.Show("Id Cliente: " + v.cliente_idcliente);




                        ccv.Add(new ClasseClienteVenda(v.cliente_idcliente, v.funcionario_idfuncionario,(double)v.valor_total_compra,(DateTime)v.data_venda, (double)v.desconto_total, v.forma_pagamento, v.tipo_cliente, iv.venda_idvenda, (int)1, (int)iv.preco_venda, (int)iv.desconto, codigoDeBarrasDataGrid, iv.descricao));
                        dgvVenda.DataSource = ccv.ToList();
                        //itens.Add(new Itens(txtProduto.Text, codigoDeBarrasDataGrid, txtValorUnitario.Text, txtQtd.Text, txtDesconto.Text, tipoCliente, pagamento, comboBoxNomeCliente.Text));
                        //Variável Global
                        //cv.Add(new ClienteVenda(tipoCliente, pagamento, comboBoxNomeCliente.Text, richTxtBoxDescricao.Text, txtCodigoBarras.Text, double.Parse(txtValorUnitario.Text), double.Parse(txtQtd.Text), double.Parse(txtDesconto.Text)));
                        //dgvVenda.DataSource = cv.ToList();

                        //CÓDIGO TESTE
                        string codigoComparacao = codigoDeBarrasDataGrid;
                        produto p = (from pr in bd.produto
                                     where pr.codigo_barras == codigoComparacao
                                     select pr).FirstOrDefault();

                        //MessageBox.Show("Código Comparação: "+codigoComparacao+"Código Barra Datagrid: "+codigoDeBarrasDataGrid);

                        var idEstoque = p.estoque_idestoque;
                        //MessageBox.Show(idEstoque.ToString()); 21/04/2020

                        estoque etq = (from et in bd.estoque
                                       where et.idestoque == p.estoque_idestoque
                                       select et).FirstOrDefault();

                        //CÓDIGO TESTE
                        if (controleEstoque == 0) {
                            controleEstoque = (int)etq.qtd_estoque;
                        }

                        controleEstoque = (int)etq.qtd_estoque - 1;
                        txtQtdEmEstoque.Text = controleEstoque.ToString();
                        //etq.qtd_estoque = etq.qtd_estoque - 1;
                        //txtQtdEmEstoque.Text = etq.qtd_estoque.ToString();
                        //p.estado = "Indisponível";

                        //bd.SaveChanges();

                        codigoDeBarrasDataGrid = "";
                        //MessageBox.Show("Entrou no cliente e venda"); 21/04/2020
                        if (int.Parse(txtQtd.Text) == 0)
                        {
                            //LimparCampusVenda();
                        }
                    }
                }
                else if (ValidarServico() && ValidarCliente() && ValidarVenda()){
                    servico s = new servico();
                    VendaProdutos(bd);
                    Servico(s);
                    bd.servico.Add(s);
                    bd.SaveChanges();

                    string pagamento, tipoCliente;
                    if (radAPrazo.Checked)
                    {
                        pagamento = "À Vista";
                    }
                    else
                    {
                        pagamento = "A Prazo";
                    }
                    if (radCadastrado.Checked)
                    {
                        tipoCliente = "Cadastrado";
                    }
                    else
                    {
                        tipoCliente = "Não Cadastrado";
                    }



                    //itens.Add(new Itens(txtProduto.Text, txtCodigoBarras.Text, txtValorUnitario.Text, txtQtd.Text, txtDesconto.Text, tipoCliente, pagamento, comboBoxNomeCliente.Text));
                    ccvs.Add(new ClasseClienteVendaServico(v.cliente_idcliente, v.funcionario_idfuncionario, (double)v.valor_total_compra, (DateTime)v.data_venda, (double)v.desconto_total, v.forma_pagamento, v.tipo_cliente, iv.venda_idvenda, (int)1, (int)iv.preco_venda, (int)iv.desconto, codigoDeBarrasDataGrid, iv.descricao, cmbMecanico.Text,s.descricao, (double)s.valor, (DateTime)s.data_servico));
                    dgvVenda.DataSource = ccvs.ToList();
                    //MessageBox.Show("Entrou no Serviço, cliente e venda!"); 21/04/2020
                } else {
                    MessageBox.Show("Para Concluir à venda, informe todos os dados necessários!");
                }
            }
        }

        private void Servico(servico s)
        {
            if (cmbMecanico.Text == "")
            {
                MessageBox.Show("Informe qual foi o Mecânico que realizou o serviço!");
            }
            s.mecanico_idmecanico = 0;
            s.descricao = richTxtBoxDescricao.Text;
            s.valor = double.Parse(txtValorServico.Text);
            s.data_servico = DateTime.Now;
        }

        private void VendaProdutos(oficinaEntities bd)
        {
            if (txtQtdEmEstoque.Text != "")
            {
                qtd = int.Parse(txtQtdEmEstoque.Text);
            }
            if (txtQtd.Text != "")
            {
                qtdCompra = int.Parse(txtQtd.Text);
            }

            BloquearLabels();


            if (qtd >= qtdCompra)
            {
                if (int.Parse(txtQtd.Text) == 0)
                {
                    LimparCampusVenda();
                }
                
                txtQtd.Text = (qtdCompra - 1).ToString();
                qtdCompra = int.Parse(txtQtd.Text);
                
                if (qtdCompra >= 0)
                {
                    txtCodigoBarras.Text = "";
                    //itens_vendidos iv = new itens_vendidos(); Criei como Variável GLOBAL
                    if (flagVenda == -1)
                    {
                        Venda(bd);

                        //MessageBox.Show(codigoVenda.ToString()); 21/04/2020
                        //bd.venda.Add(v);
                        //bd.SaveChanges();

                        ItensDaVenda(iv, bd);
                        //bd.SaveChanges(); COMENTEI PQ TORNEI VARIÁVEL GLOBAL
                        txtCodigoBarras.Focus();
                        //ListarItensVendidos();
                        vendaLiberada = true;
                        
                    }

                }
                else
                {
                    DesbloquearLabels();

                    LimparCampusVenda();
                    //Teste
                    //
                    //
                    //
                }


            }
            else
            {
                MessageBox.Show("Não há produtos suficientes no estoque. estoque máximo de " + qtd + " produtos.");
                vendaLiberada = false;
            }
        }

        private void LimparCampusVenda()
        {
            codigoDeBarrasAuxiliar = txtCodigoBarras.Text;
            txtCodigoBarras.Text = "";
            txtProduto.Text = "";
            txtValorUnitario.Text = "";
            txtQtd.Text = "";
            txtDesconto.Text = "";
            txtValorTotal.Text = "";
            txtQtdEmEstoque.Text = "";
            comboBoxNomeCliente.Text = "";
            txtContaCliente.Text = "";
            cmbMecanico.Text = "";
            richTxtBoxDescricao.Text = "";
            txtValorServico.Text = "";
        }

        private void BloquearLabels()
        {
            txtProduto.Enabled = false;
            txtValorUnitario.Enabled = false;
            txtQtdEmEstoque.Enabled = false;
            txtDesconto.Enabled = false;
            txtValorTotal.Enabled = false;
        }

        private void ItensDaVenda(itens_vendidos iv, oficinaEntities bd)
        {
            iv.venda_idvenda = codigoVenda;
            //MessageBox.Show(codigoVenda.ToString()); 21/04/2020
            iv.qtd = int.Parse(txtQtd.Text);
            iv.preco_venda = double.Parse(txtValorUnitario.Text);
            if (txtDesconto.Text == "")
            {
                iv.desconto = 0;
            }
            else
            {
                iv.desconto = double.Parse(txtDesconto.Text);
            }
            /////itvendidos.Add(new ItensVenda(codigoVenda, int.Parse(txtQtd.Text), double.Parse(txtValorUnitario.Text), double.Parse(txtDesconto.Text)));
            ////dgvVenda.DataSource = itvendidos.ToList();
            //bd.itens_vendidos.Add(iv); COMENTEI PQ TORNEI VARIÁVEL GLOBAL
        }

        private void Venda(oficinaEntities bd)
        {
            double desconto = 0;

            //venda v = new venda(); criei como variável GLOBAL
            if (comboBoxNomeCliente.Text != "")
            {
                //ANÁLISE
                //v.cliente_idcliente = comboBoxNomeCliente.SelectedIndex;
                v.cliente_idcliente = 1;
            }
            v.funcionario_idfuncionario = 0;
            if (txtValorTotal.Text == "")
            {
                v.valor_total_compra = 0;
            }
            else
            {
                v.valor_total_compra = double.Parse(txtValorTotal.Text);
            }
            v.data_venda = DateTime.Now;
            if (txtDesconto.Text == "")
            {
                v.desconto_total = 0;
            } else {
                desconto = double.Parse(txtDesconto.Text);
                v.desconto_total = desconto;
            }

            if (radAVista.Checked)
            {
                v.forma_pagamento = "A Vista";
            }
            else
            {
                v.forma_pagamento = "A Prazo";
            }
            if (radCadastrado.Checked)
            {
                v.tipo_cliente = "Cadastrado";
            }
            else
            {
                v.tipo_cliente = "Não Cadastrado";
            }
            double valorUnitario = double.Parse(txtValorUnitario.Text);
            valorTotalCompra = valorUnitario - valorUnitario * (desconto / 100);
            v.valor_total_compra = v.valor_total_compra + valorTotalCompra;
            //MessageBox.Show("Desconto do Produto: "+v.valor_total_compra.ToString()); 21/04/2020

            //v.desconto_total = v.desconto_total - v.desconto_total*

            ////cv.Add(new ClienteVenda(v.tipo_cliente, v.forma_pagamento, comboBoxNomeCliente.Text, richTxtBoxDescricao.Text, txtCodigoBarras.Text, double.Parse(txtValorUnitario.Text), double.Parse(txtQtd.Text), double.Parse(txtDesconto.Text)));

            //bd.venda.Add(v); COMENTEI PQ TORNEI VARIÁVEL GLOBAL
            //bd.SaveChanges(); COMENTEI PQ TORNEI VARIÁVEL GLOBAL




            //codigoVenda = v.idvenda; COMENTEI PQ TORNEI VARIÁVEL GLOBAL
            //MessageBox.Show(codigoVenda.ToString());
        }

        private bool ValidarServico()
        {
            if (cmbMecanico.Text == "")
            {
                return false;
            }
            if (txtValorServico.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool ValidarCliente()
        {
            if (comboBoxNomeCliente.Text == "")
            {
                return false;
            }
            return true;
        }

        private bool ValidarVenda()
        {
            if (txtCodigoBarras.Text == "")
            {
                return false;
            }
            return true;
        }

        private void ListarItensVendidos()
        {
            using (var bd = new oficinaEntities())
            {
                dgvVenda.DataSource = bd.view_itens_venda.ToList();
            }
        }

        private void txtQtd_KeyPress(object sender, KeyPressEventArgs e)
        {
        }

        private void comboBoxNomeCliente_TextChanged(object sender, EventArgs e)
        {
            if (txtCodigoBarras.Text == "") {
                PesquisaCliente();
            }
        }

        private void PesquisaCliente()
        {
            using (var bd = new oficinaEntities())
            {
                if (comboBoxNomeCliente.Text != "")
                {
                    dgvVenda.DataSource = bd.usuario.Where(x => x.nome.Contains(comboBoxNomeCliente.Text)).ToList();
                }
                else
                {
                    LimparPesquisaClienteDataGrid();
                }
            }
        }

        private void LimparPesquisaClienteDataGrid()
        {
            dgvVenda.DataSource = null; //Remover a datasource
            dgvVenda.Columns.Clear(); //Remover as colunas
            dgvVenda.Rows.Clear();    //Remover as linhas
            dgvVenda.Refresh();    //Para a grid se actualizar
        }

        private void btnBuscarCliente_Click(object sender, EventArgs e)
        {
            ListarClientes();
        }

        private void ListarClientes()
        {
            PesquisaCliente();
            //using (var bd = new oficinaEntities())
            //{
            //    dgvVenda.DataSource = bd.usuario.ToList();
            //}
        }

        private void dgvVenda_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarCliente(e);
        }

        private void SelecionarCliente(DataGridViewCellEventArgs e)
        {
            idUsuarioSelecionado = int.Parse(dgvVenda.Rows[e.RowIndex].Cells[0].Value.ToString());

            radCadastrado.Checked = true;

            using (var bd = new oficinaEntities()) {
                cliente clienteSelecionado = (from cl in bd.cliente
                             where cl.idusuario == idUsuarioSelecionado
                             select cl).FirstOrDefault();
                if (clienteSelecionado != null) {
                    clienteSel = clienteSelecionado;
                    comboBoxNomeCliente.Text = dgvVenda.Rows[e.RowIndex].Cells[1].Value.ToString();
                    if(clienteSel.divida != null)
                    {
                        txtContaCliente.Text = clienteSel.divida.ToString();
                    } else {
                        txtContaCliente.Text = 0.ToString();
                    }
                    //if (radCadastrado.Checked)
                    //{
                    //    if(comboBoxNomeCliente.Text != "") {

                    //    } else {
                    //        MessageBox.Show("Por favor, selecione o cliente!");
                    //    }
                    //}
                    //LimparPesquisaClienteDataGrid();
                } else {
                    //MessageBox.Show(idUsuarioSelecionado.ToString()); 21/04/2020
                    LimparPesquisaClienteDataGrid();
                    MessageBox.Show("Cliente não encontrado na base de dados. Por favor, consulte o programador(Cliente e Usuário).");
                }
            }
        }

        private void btnPagar_Click(object sender, EventArgs e)
        {
            //pagamento_conta pagamentoConta = new pagamento_conta();
            if(comboBoxNomeCliente.Text != "" && double.Parse(txtContaCliente.Text) > 0) {
                if (txtPagamento.Text == "") {
                    txtPagamento.Text = 0.ToString();
                }
                double pagamento, contaCliente;
                pagamento = double.Parse(txtPagamento.Text);
                contaCliente = double.Parse(txtContaCliente.Text);
                if ( pagamento <= contaCliente && txtPagamento.Text != ""){
                    //DESCONTO NA CONTA
                    using (var bd = new oficinaEntities())
                    {
                        cliente pagamentoCliente = (from ct in bd.cliente
                                          where ct.idusuario == idUsuarioSelecionado
                                          select ct).FirstOrDefault();
                        pagamentoCliente.divida = pagamentoCliente.divida - pagamento;
                        bd.SaveChanges();
                        MessageBox.Show("Pagamento Realizado com Sucesso!");
                        txtPagamento.Text = "";
                        txtContaCliente.Text = pagamentoCliente.divida.ToString();
                    }
                    //MessageBox.Show(idUsuarioSelecionado.ToString()); 21/04/2020
                }
                else {
                    MessageBox.Show("Verifique se o valor digitado é menor ou igual a conta do cliente.");
                }
            } else {
                MessageBox.Show("Por favor, verifique se o nome do cliente foi digitado e se o mesmo possui uma dívida.");
            }
        }

        private void btnLimparPagamento_Click(object sender, EventArgs e)
        {
            LimparPesquisaClienteDataGrid();
            txtPagamento.Text = "";
            comboBoxNomeCliente.Text = "";
            txtContaCliente.Text = "";
        }
        

        //private void IniciarVendas()
        //{
        //    using (var bd = new oficinaEntities())
        //    {
        //        venda v = new venda();
        //        v.cliente_idcliente = 0;
        //        v.valor_total_compra = double.Parse(txtValorTotal.Text);
        //        v.data_venda = DateTime.Now;
        //        v.desconto_total = 0;
        //        if (radAVista.Checked)
        //        {
        //            v.forma_pagamento = "À Vista";
        //        }
        //        else
        //        {
        //            v.forma_pagamento = "A Prazo"; 
        //        }
        //        bd.venda.Add(v);

        //    }
        //}

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            using (var bd = new oficinaEntities()){
                //SÓ O SERVIÇO É CADASTRADO
                if (cs != null && cs.Count > 0)
                {
                    //cs.Cast<Object>().ToArray();
                    foreach (ClasseServico classeServico in cs)
                    {
                        servico sv = new servico();
                        sv.descricao = classeServico.ServicoDescricao;
                        sv.valor = classeServico.ServicoValor;
                        sv.data_servico = classeServico.Data;
                        bd.servico.Add(sv);
                        bd.SaveChanges();
                    }
                    MessageBox.Show("Operação realizada com Sucesso!");
                }
                //REALIZA A VENDA COM O CLIENTE CADASTRADO -> SALVA DADOS DA VENDA E DO CLIENTE
                if (ccv != null && ccv.Count > 0 && ccvs.Count == 0)
                {
                    ClienteVenda(bd);
                    MessageBox.Show("Operação realizada com Sucesso!");
                }

                if (ccvs.Count > 0) {
                    ClienteVenda(bd);
                    foreach (ClasseClienteVendaServico classeClienteVendaServico in ccvs)//LEMBRAR DE CRIAR UMA TABELA EM VENDA RELACIONADA A SERVICO
                    {
                        servico sv = new servico();
                        sv.descricao = classeClienteVendaServico.ServicoDescricao;
                        sv.valor = classeClienteVendaServico.ServicoValor;
                        sv.data_servico = classeClienteVendaServico.Data;
                        bd.servico.Add(sv);
                        bd.SaveChanges();
                    }

                    MessageBox.Show("Operação realizada com Sucesso!");
                }
            }

            codigoVenda = -1;
            v = new venda();
            cs.Clear();
            ccv.Clear();
            ccvs.Clear();
            dgvVenda.DataSource = null; //Remover a datasource
            dgvVenda.Columns.Clear(); //Remover as colunas
            dgvVenda.Rows.Clear();    //Remover as linhas
            dgvVenda.Refresh();    //Para a grid se actualizar
            LimparCampusVenda();
        }

        private void ClienteVenda(oficinaEntities bd)
        {
            //PEGANDO O ID DO ÚLTIMO OBJETO VENDA
            var pvendido = bd.venda.OrderByDescending(obj => obj.idvenda).FirstOrDefault();
            int codigoProduto;
            if (pvendido != null)
            {
                codigoProduto = pvendido.idvenda;
            }
            //CONTADORES
            valorTotalCompra = 0;
            //Teste 210120202319
            //bool flagVenda = false;
            double valor = 0;
            foreach (ClasseClienteVenda classeClienteVenda in ccv)
            {
                Document doc = new Document(PageSize.A4);
                //SE NÃO EXISTIR
                if (codigoVenda <= 0)
                //if (v.idvenda <= 0)
                {
                    v.cliente_idcliente = classeClienteVenda.IdCliente;
                    v.funcionario_idfuncionario = classeClienteVenda.IdFuncionario;
                    v.valor_total_compra = classeClienteVenda.ValorTotalCompra;
                    v.data_venda = classeClienteVenda.DataVenda;
                    v.desconto_total = classeClienteVenda.DescontoTotal;
                    v.forma_pagamento = classeClienteVenda.FormaPagamento;
                    v.tipo_cliente = classeClienteVenda.TipoCadastroCliente;
                    bd.venda.Add(v);
                    bd.SaveChanges();
                    codigoVenda = v.idvenda;
                    //Teste 210120202319
                    //flagVenda = true;
                    //MessageBox.Show("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA: " + v.idvenda.ToString()); 21/04/2020
                }
                if (ccv != null && ccv.Count >= 1)
                {
                    valorTotalCompra = valorTotalCompra + (double)v.valor_total_compra;
                    descontoTotaldaCompra = descontoTotaldaCompra + (double)v.desconto_total;

                    //if(codigoProduto >= 1|| pvendido == null){
                    //    iv.venda_idvenda = codigoProduto + 1;
                    //} else {
                    //    iv.venda_idvenda = 1;
                    //}
                    iv.venda_idvenda = codigoVenda;
                    iv.qtd = classeClienteVenda.Qtd;
                    iv.preco_venda = classeClienteVenda.PrecoVenda;
                    iv.desconto = classeClienteVenda.Desconto;
                    iv.codigo_barras = classeClienteVenda.CodigoBarras;
                    valor = valor + (double)iv.preco_venda;
                    //MessageBox.Show("Valor a pagar: "+valor);
                    //CÓDIGO TESTE
                    string codigoComparacao = codigoDeBarrasDataGrid;
                    produto p = (from pr in bd.produto
                                 where pr.codigo_barras == classeClienteVenda.CodigoBarras
                                 select pr).FirstOrDefault();

                    //MessageBox.Show("Código Comparação: "+codigoComparacao+"Código Barra Datagrid: "+codigoDeBarrasDataGrid);

                    var idEstoque = p.estoque_idestoque;
                    //MessageBox.Show(idEstoque.ToString()); 21/04/2020

                    estoque etq = (from et in bd.estoque
                                   where et.idestoque == p.estoque_idestoque
                                   select et).FirstOrDefault();

                    //CÓDIGO TESTE
                    if (controleEstoque == 0)
                    {
                        controleEstoque = (int)etq.qtd_estoque;
                    }

                    etq.qtd_estoque = etq.qtd_estoque - 1;
                    p.estado = "Indisponível";


                    //TESTE PDF 220420201407
                    //Document doc = new Document(PageSize.A4);//criando e estipulando o tipo da folha usada
                    doc.SetMargins(40, 40, 40, 80);//estibulando o espaçamento das margens que queremos
                    doc.AddCreationDate();//adicionando as configuracoes

                    //caminho onde sera criado o pdf + nome desejado
                    //OBS: o nome sempre deve ser terminado com .pdf
                    string caminho = @"C:\Users\Giliarde\Desktop" + "xxx.pdf";

                    //criando o arquivo pdf embranco, passando como parametro a variavel doc criada acima e a variavel caminho
                    //tambem criada acima.
                    PdfWriter writer = PdfWriter.GetInstance(doc, new
                    FileStream(caminho, FileMode.Create));

                    doc.Open();

                    //criando uma string vazia
                    string dados = "";

                    //criando a variavel para paragrafo
                    Paragraph paragrafo = new Paragraph(dados);
                    //etipulando o alinhamneto
                    paragrafo.Alignment = Element.ALIGN_JUSTIFIED;
                    //Alinhamento Justificado
                    //adicioando texto
                    //paragrafo.Add(paragrafo + "\n" + "Produto: " + p.descricao + " Valor: " + iv.preco_venda);
                    paragrafo.Add("Produto: " + p.descricao + " Valor: " + iv.preco_venda);
                    //acidionado paragrafo ao documento
                    doc.Add(paragrafo);
                    
                    //Teste 210120202319




                    if (radAPrazo.Checked)
                    {
                        if (radCadastrado.Checked)
                        {
                            if (comboBoxNomeCliente.Text != "")
                            {
                                cliente client = (from ct in bd.cliente
                                                  where ct.idusuario == clienteSel.idusuario
                                                  select ct).FirstOrDefault();
                                //venda vendaRealizada = (from vd in bd.venda
                                //                        where vd.idvenda == v.idvenda
                                //                        select vd).FirstOrDefault();



                                //if (radCadastrado.Checked)
                                //{
                                //    vendaRealizada.cliente_idcliente = client.idcliente;

                                //    MessageBox.Show("Venda Id: " + vendaRealizada.cliente_idcliente);
                                //    MessageBox.Show("Venda Id: " + client.idcliente);
                                //}
                                if (client.divida == null)
                                {
                                    client.divida = 0;
                                }
                                //MessageBox.Show(client.idcliente.ToString()); 21/04/2020

                                //TESTE
                                double precoProduto = (double)iv.preco_venda;
                                double dividaCliente = (double)client.divida;
                                double conta = dividaCliente + precoProduto;
                                client.divida = conta;
                                bd.SaveChanges();
                            }
                            else
                            {
                                MessageBox.Show("Por favor, selecione o cliente que fez a compra!");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Não é possível realizar a venda a prazo se o cliente não estiver cadastrado.");
                        }

                    }
                    //if (flagVenda) {
                    //    venda vend = (from vd in bd.venda
                    //                 where vd.idvenda == v.idvenda
                    //                 select vd).FirstOrDefault();

                    //    vend.valor_total_compra = vend.valor_total_compra + iv.preco_venda;
                    //    flagVenda = false;
                    //}

                    bd.itens_vendidos.Add(iv);
                    iv = new itens_vendidos();
                    bd.SaveChanges();
                }
                else
                {

                }
                //fechando documento para que seja salva as alteraçoes.
                doc.Close();
                //    sv.descricao = classeServico.ServicoDescricao;
                //    sv.valor = classeServico.ServicoValor;
                //    sv.data_servico = classeServico.Data;
                //    bd.servico.Add(sv);
                //    bd.SaveChanges();
            }

            //Teste 210420202348
            venda vend = (from vd in bd.venda
                          where vd.idvenda == v.idvenda
                          select vd).FirstOrDefault();
            vend.valor_total_compra = valor;
            bd.SaveChanges();
            System.Diagnostics.Process.Start(@"C:\Users\Giliarde\Desktop" + "xxx.pdf");
        }
    }
}
