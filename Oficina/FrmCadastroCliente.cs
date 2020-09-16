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
    public partial class FrmCadastroCliente : Form
    {
        private int idUsuarioSelecionado = -1;
        public FrmCadastroCliente()
        {
            InitializeComponent();

            ListarUsuarios();
        }

        private void ListarUsuarios()
        {
            using (var bd = new oficinaEntities())
            {
                dgvClientes.DataSource = bd.view_user.ToList();
            }
        }

        private void Salvar()
        {

            if (!ValidarForm())
            {
                return;
            }


            using (var bd = new oficinaEntities())
            {
                if (idUsuarioSelecionado == -1)
                {
                    //Não há cliente selecionado, insere-o:
                    InserirUsuario(bd);
                }
                else
                {
                    //Há cliente selecionado: autaliza-o:
                    AtualizarUsuario(bd);
                }
            }
        }

        private bool ValidarForm()
        {
            if (txtNome.Text.Trim() == "")
            {
                MessageBox.Show("Por favor, preencha o campo Nome");
                return false;
            }



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

        private void AtualizarUsuario(oficinaEntities bd)
        {
            //1. Localizar o registro:
            usuario u = (from us in bd.usuario
                         where us.idusuario == idUsuarioSelecionado
                         select us).FirstOrDefault();

            endereco e = (from end in bd.endereco
                          where end.idusuario == idUsuarioSelecionado
                          select end).FirstOrDefault();

            contato c = (from ctt in bd.contato
                         where ctt.idusuario == idUsuarioSelecionado
                         select ctt).FirstOrDefault();

            if (u != null && e != null && c != null)
            {
                u.nome = txtNome.Text;
                u.cpf = maskTxtCPF.Text;
                u.rg = txtRG.Text;
                u.nascimento = maskedTxtNascimento.Text;
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

                e.logradouro = txtLogradouro.Text;
                e.bairro = txtBairro.Text;
                e.numero = txtNumeroCasa.Text;
                e.cidade = txtCidade.Text;
                e.uf = txtUF.Text;
                e.cep = txtCEP.Text;

                c.numero_telefone = maskedTxtTelefone.Text;
                c.email = txtEmail.Text;

                //if (radFuncionario.Checked)
                //{
                //    funcionario f = new funcionario();
                //    f.login = txtUsuario.Text;
                //    f.senha = maskedTxtSenha.Text;
                //    f.idusuario = idUsuarioSelecionado;
                //    MessageBox.Show(maskedTxtSenha.ToString());
                //    MessageBox.Show(maskTxtConfirmarSenha.ToString());

                //    if (maskedTxtSenha.Text.Equals(maskTxtConfirmarSenha.Text))
                //    {
                //        bd.funcionario.Add(f);
                //        bd.endereco.Add(e);
                //        bd.contato.Add(c);
                //        bd.SaveChanges();
                //        MessageBox.Show("Usuário " + f.login + " criado com sucesso!");
                //    }
                //    else
                //    {
                //        LimparCampusFuncionario();
                //        MessageBox.Show("As senhas inseridas não correspondem, por favor, digite novamente!");
                //    }
                //}

                bd.SaveChanges(); //Salva as modificações no BD
                ListarUsuarios(); //atualiza o grid
                MessageBox.Show("Dados registrados com sucesso!");
                LimparForm();

            }

        }

        private void InserirUsuario(oficinaEntities bd)
        {
            endereco e = new endereco();
            contato c = new contato();
            usuario u = new usuario();

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
            //MessageBox.Show("ID DO USUÁRIO: " +aux.ToString());

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
            //MessageBox.Show("ID DO CLIENTE: "+c.idusuario.ToString());
            if (radFuncionario.Checked)
            {
                funcionario f = new funcionario();
                f.login = txtUsuario.Text;
                f.senha = maskedTxtSenha.Text;
                f.idusuario = aux;

                if (maskedTxtSenha.Text.Equals(maskTxtConfirmarSenha.Text))
                {
                    bd.funcionario.Add(f);
                    bd.endereco.Add(e);
                    bd.contato.Add(c);
                    bd.SaveChanges();
                    MessageBox.Show("Usuário " + f.login + " criado com sucesso!");
                    LimparCampusFuncionario();
                    ListarUsuarios();
                }
                else
                {
                    LimparCampusFuncionario();
                    MessageBox.Show("As senhas inseridas não correspondem, por favor, digite novamente!");
                }
            }
            else
            {
                cliente cl = new cliente();
                cl.idusuario = aux;
                bd.endereco.Add(e);
                bd.contato.Add(c);
                bd.cliente.Add(cl);

                bd.SaveChanges();
                ListarUsuarios();
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

            txtLogradouro.Text = "";
            txtBairro.Text = "";
            txtCidade.Text = "";
            txtUF.Text = "";
            txtCEP.Text = "";
            txtNumeroCasa.Text = "";

            maskedTxtTelefone.Text = "";
            txtEmail.Text = "";

            LimparCampusFuncionario();

            dgvClientes.ClearSelection();
            idUsuarioSelecionado = -1;
            txtNome.Focus();
        }

        private void LimparCampusFuncionario()
        {
            txtUsuario.Text = "";
            maskTxtConfirmarSenha.Text = "";
            maskedTxtSenha.Text = "";
        }
        
        private void ComponentesUsuario()
        {
            lblRGRepresentante.Location = new Point(551, 26);
            lblRGRepresentante.Text = "RG:";
            lblCPFNNPJ.Text = "CPF:";
            maskTxtCPF.Mask = "###.###.###-##";
        }
        

        private void SelecionarRegistro(DataGridViewCellEventArgs e)
        {
            idUsuarioSelecionado = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[0].Value.ToString());
            txtNome.Text = dgvClientes.Rows[e.RowIndex].Cells[1].Value.ToString();
            maskTxtCPF.Text = dgvClientes.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtRG.Text = dgvClientes.Rows[e.RowIndex].Cells[3].Value.ToString();
            string tipoSexo = dgvClientes .Rows[e.RowIndex].Cells[4].Value.ToString();
            if (tipoSexo == "M")
            {
                radMasculino.Checked = true;
            }
            else
            {
                radFeminino.Checked = true;
            }
            maskedTxtNascimento.Text = dgvClientes.Rows[e.RowIndex].Cells[5].Value.ToString();
            int estadoUsuario = int.Parse(dgvClientes.Rows[e.RowIndex].Cells[7].Value.ToString());
            if (estadoUsuario == 0)
            {
                radNaoAtivo.Checked = true;
            }
            else
            {
                radAtivo.Checked = true;
            }
            txtLogradouro.Text = dgvClientes.Rows[e.RowIndex].Cells[9].Value.ToString();
            txtBairro.Text = dgvClientes.Rows[e.RowIndex].Cells[10].Value.ToString();
            txtCidade.Text = dgvClientes.Rows[e.RowIndex].Cells[11].Value.ToString();
            txtUF.Text = dgvClientes.Rows[e.RowIndex].Cells[12].Value.ToString();
            txtCEP.Text = dgvClientes.Rows[e.RowIndex].Cells[13].Value.ToString();
            txtNumeroCasa.Text = dgvClientes.Rows[e.RowIndex].Cells[14].Value.ToString();
            maskedTxtTelefone.Text = dgvClientes.Rows[e.RowIndex].Cells[16].Value.ToString();
            txtEmail.Text = dgvClientes.Rows[e.RowIndex].Cells[17].Value.ToString();

        }

        

        private void txtNumeroCasa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }

        

        private void radFornecedor_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();

            lblCPFNNPJ.Text = "CNPJ:";
            maskTxtCPF.Mask = "##.###.###/####-##";
            lblRGRepresentante.Text = "Representante:";
            lblRGRepresentante.Location = new Point(497, 26);

            lblNascimento.Visible = false;
            maskedTxtNascimento.Visible = false;
            panelSexo.Visible = false;
            lblSexo.Visible = false;
            radFeminino.Visible = false;
            radMasculino.Visible = false;
            panelEstado.Visible = false;
            lblEstado.Visible = false;
            radAtivo.Visible = false;
            radNaoAtivo.Visible = false;

            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            lblSenha.Visible = false;
            maskedTxtSenha.Visible = false;
            lblConfirmarSenha.Visible = false;
            maskTxtConfirmarSenha.Visible = false;
            checkExibirSenha.Visible = false;
            grupoFuncionario.Visible = false;
        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            Salvar();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            if (idUsuarioSelecionado == -1)
            {
                MessageBox.Show("Selecione com um duplo" +
                    " clique sobre algum produto da lista");
                return; //aborta o método
            }
            using (var bd = new oficinaEntities())
            {
                //1. Localizar o registro:
                usuario u = (from us in bd.usuario
                             where us.idusuario == idUsuarioSelecionado
                             select us).FirstOrDefault();

                endereco ed = (from end in bd.endereco
                               where end.idusuario == idUsuarioSelecionado
                               select end).FirstOrDefault();

                contato c = (from ctt in bd.contato
                             where ctt.idusuario == idUsuarioSelecionado
                             select ctt).FirstOrDefault();

                if (u != null && ed != null && c != null)
                {
                    bd.endereco.Remove(ed);
                    bd.contato.Remove(c);
                    bd.usuario.Remove(u);
                    bd.SaveChanges(); //Confirma exclusão no BD
                    ListarUsuarios(); //Atualiza o Grid
                    LimparForm();
                    MessageBox.Show("Registro excluído com sucesso!");
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparForm();
        }

        private void txtRG_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ',') && (e.KeyChar != '-') && (e.KeyChar != '.'))
            {
                e.Handled = true;
                //MessageBox.Show("este campo aceita somente numero e virgula");
            }
        }

        private void dgvClientes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            SelecionarRegistro(e);
        }

        private void radFuncionario_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();

            ComponentesUsuario();


            lblUsuario.Visible = true;
            txtUsuario.Visible = true;
            lblSenha.Visible = true;
            maskedTxtSenha.Visible = true;
            lblConfirmarSenha.Visible = true;
            maskTxtConfirmarSenha.Visible = true;
            checkExibirSenha.Visible = true;
            grupoFuncionario.Visible = true;

            lblNascimento.Visible = true;
            maskedTxtNascimento.Visible = true;
            panelSexo.Visible = true;
            lblSexo.Visible = true;
            radFeminino.Visible = true;
            radMasculino.Visible = true;
            panelEstado.Visible = true;
            lblEstado.Visible = true;
            radAtivo.Visible = true;
            radNaoAtivo.Visible = true;

        }

        private void radCliente_CheckedChanged(object sender, EventArgs e)
        {
            LimparForm();
            ComponentesUsuario();


            lblUsuario.Visible = false;
            txtUsuario.Visible = false;
            lblSenha.Visible = false;
            maskedTxtSenha.Visible = false;
            lblConfirmarSenha.Visible = false;
            maskTxtConfirmarSenha.Visible = false;
            checkExibirSenha.Visible = false;
            grupoFuncionario.Visible = false;


            lblNascimento.Visible = true;
            maskedTxtNascimento.Visible = true;
            panelSexo.Visible = true;
            lblSexo.Visible = true;
            radFeminino.Visible = true;
            radMasculino.Visible = true;
            panelEstado.Visible = true;
            lblEstado.Visible = true;
            radAtivo.Visible = true;
            radNaoAtivo.Visible = true;

            LimparCampusFuncionario();
        }

        private void checkExibirSenha_CheckedChanged(object sender, EventArgs e)
        {
            if (checkExibirSenha.Checked)
            {
                maskedTxtSenha.PasswordChar = '\0';
                maskTxtConfirmarSenha.PasswordChar = '\0';
            }
            else
            {
                maskedTxtSenha.PasswordChar = '*';
                maskTxtConfirmarSenha.PasswordChar = '*';
            }
        }
    }
}
