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
    public partial class FrmCadastroMecanico : Form
    {
        public FrmCadastroMecanico()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                endereco e = new endereco();
                contato c = new contato();
                usuario u = new usuario();
                mecanico m = new mecanico();

                u.nome = txtNome.Text;
                u.cpf = maskTxtCPF.Text;
                u.rg = txtRG.Text;
                if (radMasculino.Checked)
                {
                    u.sexo = "M";
                }
                else
                {
                    u.sexo = "F";
                }
                if (radAtivo.Checked)
                {
                    u.estado = "1";
                }
                else
                {
                    u.estado = "0";
                }
                u.nascimento = maskedTxtNascimento.Text;
                u.data_cadastro = DateTime.Now;

                bd.usuario.Add(u);
                bd.SaveChanges();

                int aux = u.idusuario;

                m.usuario_idusuario = aux;
                m.apelido = txtApelido.Text;
                m.funcao = txtFuncao.Text;

                e.idusuario = aux;
                e.logradouro = txtLogradouro.Text;
                e.bairro = txtBairro.Text;
                e.numero = txtNumeroCasa.Text;
                e.cidade = txtCidade.Text;
                e.uf = txtUF.Text;
                e.cep = txtCEP.Text;

                c.idusuario = aux;
                c.numero_telefone = maskedTxtTelefone.Text;
                c.email = txtEmail.Text;

                bd.mecanico.Add(m);
                bd.endereco.Add(e);
                bd.contato.Add(c);
                bd.SaveChanges();
                MessageBox.Show("Registro Salvo Com Sucesso!");
                LimparForm();
            }
        }

        private void LimparForm()
        {
            txtNome.Text = "";
            maskTxtCPF.Text = "";
            txtRG.Text = "";
            radMasculino.Checked = true;
            maskedTxtNascimento.Text = "";
            radAtivo.Checked = true;

            txtApelido.Text = "";
            txtFuncao.Text = "";

            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtCEP.Text = "";
            txtNumeroCasa.Text = "";

            maskedTxtTelefone.Text = "";
            txtEmail.Text = "";
            
            txtNome.Focus();
        }

        private bool ValidarForm()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha o campo Nome");
                return false;
            }
            //if (txtApelido.Text.Trim() == "")
            //{
            //    MessageBox.Show("Por favor, preencha o campo Nome");
            //    return false;
            //}
            //if (txtFuncao.Text.Trim() == "")
            //{
            //    MessageBox.Show("Por favor, preencha o campo Nome");
            //    return false;
            //}
            if (!maskTxtCPF.MaskFull)
            {
                MessageBox.Show("Preencha o campo CPF corretamente.");
                return false;
            }

            if (txtRG.Text.Trim() == "")
            {
                MessageBox.Show("Pro favor, preencha o campo RG");
                return false;
            }
            return true;

        }
    }
}
