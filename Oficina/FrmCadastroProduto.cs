using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oficina.Modelos;

namespace Oficina
{
    public partial class FrmCadastroProduto : Form
    {
        public FrmCadastroProduto()
        {
            InitializeComponent();

            ListarFornecedores();

            
        }

        private void ListarFornecedores()
        {
            using (var bd = new oficinaEntities())
            {
                cbFornecedor.DataSource = bd.fornecedor.ToList();
            }
            cbFornecedor.SelectedIndex = -1;
        }

        private void textBox6_KeyUp(object sender, KeyEventArgs e)
        {
            //adicionei o try catch pois qndo ele adiciona o ponto de milhar e se vc precisar apagar todos os caracteres
            //acontece um erro. Então o catch deixa passar mesmo ocorrendo o erro.
            try
            {
                //formata com o ponto de milhar
                txtValorCusto.Text = string.Format("{0,0:#,##0}", double.Parse(txtValorCusto.Text));

                //Toda vez que digita após adicionar o ponto de milhar o cursor volta pro inicio do textbox
                //por isso na proxima linha conto quantos caractes tem no textbox
                int cont = txtValorCusto.TextLength;

                //Aqui eu coloco o cursor sempre depois do ultimo caractere
                txtValorCusto.SelectionStart = cont;
                txtValorCusto.SelectionLength = 0;
            }
            catch (Exception)
            {
            }
        }

        private void txtQtdACadastrar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtQtdACadastrar.Text != "")
                {
                    HabilitarCampus();

                }
                else
                {
                    MessageBox.Show("Informe quantos produtos irão ser cadastrados!");
                }
            }
            
        }

        private void HabilitarCampus()
        {
            txtQtdACadastrar.Enabled = false;

            cbFornecedor.Enabled = true;
            txtCodigoBarras.Enabled = true;
            txtCodigo.Enabled = true;
            txtUnidade.Enabled = true;
            txtDescricaoServico.Enabled = true;
            txtDescricaoMarca.Enabled = true;
            txtValorCusto.Enabled = true;
            txtMargemAvista.Enabled = true;
            txtMargemPrazo.Enabled = true;
            txtMargemAtacado.Enabled = true;

            txtCodigo.Enabled = false;
            lblMensagemCodProduto.Visible = false;
            lblMensagemCodProduto.Text = "";

            //txtValorAvista.Enabled = true;
            //txtValorPrazo.Enabled = true;
            //txtValorAtacado.Enabled = true;

            //btnSalvar.Enabled = true;
            btnLimpar.Enabled = true;
            btnExcluir.Enabled = true;
            btnCarregarValores.Enabled = true;
            btnListarPecas.Enabled = true;
        }

        private void Salvar()
        {
            if (txtValorAvista.Text != "" && txtValorPrazo.Text != "" && txtValorAtacado.Text != "" && txtCodigoBarras.Text != "")
            {
                int qtd = int.Parse(txtQtdACadastrar.Text);

                using (var bd = new oficinaEntities())
                {
                    produto p = new produto();
                    estoque e = new estoque();

                    fornecedor f = (from fn in bd.fornecedor
                                 where fn.nome == cbFornecedor.Text
                                 select fn).FirstOrDefault();

                    //MessageBox.Show(f.idfornecedor.ToString());
                    p.idfornecedor = f.idfornecedor;
                    p.estado = "Disponível";

                    produto prod = (from pdt in bd.produto
                                  where pdt.codigo == txtCodigo.Text
                                  select pdt).FirstOrDefault();

                    if (prod != null)
                    {
                        
                        estoque est = (from etq in bd.estoque
                                       where etq.idestoque == prod.estoque_idestoque
                                       select etq).FirstOrDefault();

                        p.estoque_idestoque = est.idestoque;
                        est.qtd_estoque = est.qtd_estoque + 1;// ERRO AQUI
                        txtQtdEstoque.Text = est.qtd_estoque.ToString();
                        //bd.estoque.Add(e);
                    }
                    else
                    {

                        txtQtdEstoque.Text = "1";
                        e.qtd_estoque = 1;
                        bd.estoque.Add(e);
                        bd.SaveChanges();
                        p.estoque_idestoque = e.idestoque;
                    }

                    //CÓDIGO TESTE
                    //if (e.qtd_estoque.ToString() == "")
                    //{
                    //    e.qtd_estoque = 1;
                    //}
                    //else
                    //{
                    //    e.qtd_estoque = e.qtd_estoque + 1;
                    //}
                    //p.estoque_idestoque = e.idestoque;
                    p.descricao = txtDescricaoServico.Text;
                    p.un = txtUnidade.Text;
                    p.descricao_marca = txtDescricaoMarca.Text;
                    p.codigo = txtCodigo.Text;
                    p.codigo_barras = txtCodigoBarras.Text;
                    p.valor_custo = Double.Parse(txtValorCusto.Text);
                    p.margem_avista = Double.Parse(txtMargemAvista.Text);
                    p.margem_prazo = Double.Parse(txtMargemPrazo.Text);
                    p.margem_atacado = Double.Parse(txtMargemAtacado.Text);
                    p.valor_avista = Double.Parse(txtValorAvista.Text);
                    p.valor_prazo = Double.Parse(txtValorPrazo.Text);
                    p.valor_atacado = Double.Parse(txtValorAtacado.Text);


                    p.ultima_atualizacao = DateTime.Now;
                    p.data_cadastro = DateTime.Now;

                    //CÓDIGO TESTE
                    //bd.estoque.Add(e);
                    //
                    bd.produto.Add(p);
                    //bd.estoque.Add(e);
                    bd.SaveChanges();

                    txtCodigoBarras.Text = "";
                    txtCodigoBarras.Focus();

                    
                    //ListarUsuarios();
                    MessageBox.Show("Produto cadastrado com sucesso!");

                }
                qtd--;
                txtQtdACadastrar.Text = qtd.ToString();
                if (qtd == 0)
                {
                    LimparCampus();
                    DesabilitarCampus();
                }
            }
            else
            {
                MessageBox.Show("Por favor, preencha os campos obrigatórios!");
            }

            
            
        }

        private void DesabilitarCampus()
        {
            //txtQtdACadastrar.Enabled = true;
            txtCodigo.Enabled = true;
            cbFornecedor.Enabled = false;
            txtCodigoBarras.Enabled = false;
            //txtCodigo.Enabled = false;
            txtUnidade.Enabled = false;
            txtDescricaoServico.Enabled = false;
            txtDescricaoMarca.Enabled = false;
            txtValorCusto.Enabled = false;
            txtMargemAvista.Enabled = false;
            txtMargemPrazo.Enabled = false;
            txtMargemAtacado.Enabled = false;
            txtQtdACadastrar.Enabled = false;

            //txtValorAvista.Enabled = false;
            //txtValorPrazo.Enabled = false;
            //txtValorAtacado.Enabled = false;

            btnSalvar.Enabled = false;
            btnLimpar.Enabled = false;
            btnExcluir.Enabled = false;
            btnListarPecas.Enabled = false;
        }

        private void LimparCampus()
        {
            txtQtdEstoque.Text = "";
            txtQtdACadastrar.Text = "";
            cbFornecedor.Text = "";
            txtCodigoBarras.Text = "";
            txtCodigo.Text = "";
            txtUnidade.Text = "";
            txtDescricaoServico.Text = "";
            txtDescricaoMarca.Text = "";
            txtValorCusto.Text = "";
            txtMargemAvista.Text = "";
            txtMargemPrazo.Text = "";
            txtMargemAtacado.Text = "";
            txtValorAvista.Text = "";
            txtValorPrazo.Text = "";
            txtValorAtacado.Text = "";

        }
        private void LimparCampusChecado()
        {
            txtQtdEstoque.Text = "";
            txtQtdACadastrar.Text = "";
            cbFornecedor.Text = "";
            txtCodigoBarras.Text = "";
            txtUnidade.Text = "";
            txtDescricaoServico.Text = "";
            txtDescricaoMarca.Text = "";
            txtValorCusto.Text = "";
            txtMargemAvista.Text = "";
            txtMargemPrazo.Text = "";
            txtMargemAtacado.Text = "";
            txtValorAvista.Text = "";
            txtValorPrazo.Text = "";
            txtValorAtacado.Text = "";

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void txtMargemAvista_Leave(object sender, EventArgs e)
        {
            //decimal porcentagem = 0;
            //decimal.TryParse(txtMargemAvista.Text, out porcentagem);
            //txtMargemAvista.Text = String.Format("{0:P2}", porcentagem / 100);
        }

        private void txtMargemPrazo_Leave(object sender, EventArgs e)
        {
            //decimal porcentagem = 0;
            //decimal.TryParse(txtMargemPrazo.Text, out porcentagem);
            //txtMargemPrazo.Text = String.Format("{0:P2}", porcentagem / 100);
        }

        private void txtMargemAtacado_Leave(object sender, EventArgs e)
        {
            //decimal porcentagem = 0;
            //decimal.TryParse(txtMargemAtacado.Text, out porcentagem);
            //txtMargemAtacado.Text = String.Format("{0:P2}", porcentagem / 100);
        }

        //public bool ValidarMargens()
        //{
        //    if (txtMargemAvista.Text == "")
        //    {
        //        MessageBox.Show("Por favor, preencha a margem de avista!");
        //        return false;
        //    }
        //    if (txtValorCusto.Text == "")
        //    {
        //        MessageBox.Show("Por favor, preencha o valor de custo!");
        //        return false;
        //    }
        //    if (txtMargemPrazo.Text == "")
        //    {
        //        MessageBox.Show("Por favor, preencha a margem a prazo!");
        //        return false;
        //    }
        //    if (txtMargemAtacado.Text == "")
        //    {
        //        MessageBox.Show("Por favor, preencha a margem de atacado!");
        //        return false;
        //    }
        //    return true;
        //}

        private void btnCarregarValores_Click(object sender, EventArgs e)
        {
            //if (!ValidarMargens())
            //{
            //    return;
            //}
            btnSalvar.Enabled = true;
            double valorCusto = Double.Parse(txtValorCusto.Text);
            


            if (txtMargemAvista.Text == "")
            {
                txtMargemAvista.Text = "";
            }
            else
            {
                double margemAvista = Double.Parse(txtMargemAvista.Text);
                txtValorAvista.Text = (valorCusto + (valorCusto * (margemAvista / 100))).ToString();
            }

            if (txtMargemPrazo.Text == "")
            {
                txtMargemPrazo.Text = "";
            }
            else
            {
                double margemPrazo = Double.Parse(txtMargemPrazo.Text);
                txtValorPrazo.Text = (valorCusto + (valorCusto * (margemPrazo / 100))).ToString();
            }
            if (txtMargemAtacado.Text == "")
            {
                txtMargemAtacado.Text = "";
            }
            else
            {
                double margemAtacado = Double.Parse(txtMargemAtacado.Text);
                txtValorAtacado.Text = (valorCusto + (valorCusto * (margemAtacado / 100))).ToString();
            }

        }

        private void txtCodigo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                if (txtCodigo.Text != "")
                {
                    using (var bd = new oficinaEntities())
                    {
                        txtQtdACadastrar.Focus();
                        string codigoComparacao = txtCodigo.Text;
                        produto p = (from pr in bd.produto
                                     where pr.codigo == codigoComparacao
                                     select pr).FirstOrDefault();

                        if (p != null)
                        {
                            RecuperandoDados(p);
                            btnSalvar.Enabled = true;
                            txtQtdACadastrar.Focus();
                        }
                        else
                        {
                            lblMensagemCodProduto.Visible = true;
                            lblMensagemCodProduto.ForeColor = Color.Green;
                            lblMensagemCodProduto.Text = "Não há produto cadastrado referente a esse código.";
                            LimparCampusChecado();
                            txtQtdEstoque.Text = "Não Cadastrado!";
                            txtQtdACadastrar.Enabled = true;
                            txtQtdACadastrar.Focus();
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Informe qual é o código do produto.");
                }
            }
        }

        private void RecuperandoDados(produto p)
        {
            using (var bd = new oficinaEntities())
            {
                estoque etq = (from est in bd.estoque
                             where est.idestoque == p.estoque_idestoque
                             select est).FirstOrDefault();

                txtQtdEstoque.Text = etq.qtd_estoque.ToString();
                
            }

            //cbFornecedor.Text = p.fornecedor;
            txtDescricaoServico.Text = p.descricao;
            txtDescricaoMarca.Text = p.descricao_marca;
            txtValorCusto.Text = p.valor_custo.ToString();
            txtMargemAvista.Text = p.margem_avista.ToString();
            txtMargemPrazo.Text = p.margem_prazo.ToString();
            txtMargemAtacado.Text = p.margem_atacado.ToString();
            txtValorAvista.Text = p.valor_avista.ToString();
            txtValorPrazo.Text = p.valor_prazo.ToString();
            txtValorAtacado.Text = p.valor_atacado.ToString();

            txtQtdACadastrar.Enabled = true;

        }
        
    }
}
