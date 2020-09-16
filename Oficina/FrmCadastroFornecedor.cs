using Oficina.Modelos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oficina
{
    public partial class FrmCadastroFornecedor : Form
    {
        private int idFornecedorSelecionado = -1;
        public FrmCadastroFornecedor()
        {
            InitializeComponent();

            ListarFornecedores();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            Salvar();
        }

        private void Salvar()
        {
            if (!ValidarForm())
            {
                return;
            }

            using (var bd = new oficinaEntities())
            {
                if (idFornecedorSelecionado == -1)
                {
                    //Não há cliente selecionado, insere-o:
                    InserirFornecedor(bd);
                }
                else
                {
                    //Há cliente selecionado: autaliza-o:
                    AtualizarFornecedor(bd);
                }
            }
        }

        private void AtualizarFornecedor(oficinaEntities bd)
        {
            usuario u = (from us in bd.usuario
                         where us.idusuario == idFornecedorSelecionado
                         select us).FirstOrDefault();

            endereco e = (from end in bd.endereco
                          where end.idusuario == idFornecedorSelecionado
                          select end).FirstOrDefault();

            contato c = (from ctt in bd.contato
                         where ctt.idusuario == idFornecedorSelecionado
                         select ctt).FirstOrDefault();

            if (u != null && e != null && c != null)
            {
                u.nome = txtNome.Text;
                u.cpf = maskTxtCNPJ.Text;
                u.rg = txtRepresentante.Text;
                //u.nascimento = maskedTxtNascimento.Text;
                //if (radMasculino.Checked)
                //{
                //    u.sexo = "M";
                //}
                //else
                //{
                //    u.sexo = "F";
                //}
                //if (radAtivo.Checked)
                //{
                //   u.estado = "1";
                //}
                //else
                //{
                //    u.estado = "0";
                //}

                e.logradouro = txtLogradouro.Text;
                e.bairro = txtBairro.Text;
                e.numero = txtNumeroCasa.Text;
                e.cidade = txtCidade.Text;
                e.uf = txtUF.Text;
                e.cep = txtCEP.Text;

                c.numero_telefone = maskedTxtTelefone.Text;
                c.email = txtEmail.Text;

                bd.SaveChanges(); //Salva as modificações no BD
                ListarFornecedores(); //atualiza o grid
                MessageBox.Show("Dados registrados com sucesso!");
                LimparForm();

            }
        }

        private void ListarFornecedores()
        {
            using (var bd = new oficinaEntities())
            {
                dgvFornecedor.DataSource = bd.fornecedor.ToList();
            }
        }

        private void InserirFornecedor(oficinaEntities bd)
        {
            endereco e = new endereco();
            contato c = new contato();

            fornecedor f = new fornecedor();
            f.nome = txtNome.Text;
            f.CNPJ = maskTxtCNPJ.Text;
            f.representante = txtRepresentante.Text;
            bd.fornecedor.Add(f);
            bd.SaveChanges();

            int aux = f.idfornecedor;

            e.idfornecedor = aux;
            e.logradouro = txtLogradouro.Text;
            e.bairro = txtBairro.Text;
            e.numero = txtNumeroCasa.Text;
            e.cidade = txtCidade.Text;
            e.uf = txtUF.Text;
            e.cep = txtCEP.Text;

            c.idfornecedor = aux;
            c.numero_telefone = maskedTxtTelefone.Text;
            c.email = txtEmail.Text;

            bd.endereco.Add(e);
            bd.contato.Add(c);
            bd.SaveChanges();
            ListarFornecedores();
            MessageBox.Show("Registro Salvo Com Sucesso!");
            LimparForm();
        }

        private void LimparForm()
        {
            txtNome.Text = "";
            maskTxtCNPJ.Text = "";
            txtRepresentante.Text = "";
            //radMasculino.Checked = true;
            //maskedTxtNascimento.Text = "";
            //radAtivo.Checked = true;

            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtCEP.Text = "";
            txtNumeroCasa.Text = "";

            maskedTxtTelefone.Text = "";
            txtEmail.Text = "";

            dgvFornecedor.ClearSelection();
            idFornecedorSelecionado = -1;
            txtNome.Focus();
        }

        private bool ValidarForm()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha o campo Nome");
                return false;
            }

            if (!maskTxtCNPJ.MaskFull)
            {
                MessageBox.Show("Preencha o campo CPF corretamente.");
                return false;
            }

            if (txtRepresentante.Text.Trim() == "")
            {
                MessageBox.Show("Pro favor, preencha o campo RG");
                return false;
            }
            return true;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void dgvFornecedor_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarRegistro(e);
        }

        private void SelecionarRegistro(DataGridViewCellEventArgs e)
        {
            idFornecedorSelecionado = int.Parse(dgvFornecedor.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgvFornecedor.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskTxtCNPJ.Text = dgvFornecedor.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRepresentante.Text = dgvFornecedor.Rows[e.RowIndex].Cells[3].Value.ToString();
        }
    }
}
