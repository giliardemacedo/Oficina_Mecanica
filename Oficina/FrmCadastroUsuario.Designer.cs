namespace Oficina
{
    partial class FrmCadastroUsuario
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroUsuario));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.maskTxtCPFCNPJ = new System.Windows.Forms.MaskedTextBox();
            this.maskedTxtNascimento = new System.Windows.Forms.MaskedTextBox();
            this.panelEstado = new System.Windows.Forms.Panel();
            this.radNaoAtivo = new System.Windows.Forms.RadioButton();
            this.radAtivo = new System.Windows.Forms.RadioButton();
            this.panelSexo = new System.Windows.Forms.Panel();
            this.radFeminino = new System.Windows.Forms.RadioButton();
            this.radMasculino = new System.Windows.Forms.RadioButton();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.lblSexo = new System.Windows.Forms.Label();
            this.txtRGRepresentante = new System.Windows.Forms.TextBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.lblRGRepresentante = new System.Windows.Forms.Label();
            this.lblCPFNNPJ = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.lblCep = new System.Windows.Forms.Label();
            this.lblUf = new System.Windows.Forms.Label();
            this.txtUF = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txtNumeroCasa = new System.Windows.Forms.TextBox();
            this.lblNumeroCasa = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.maskedTxtTelefone = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoCadastro = new System.Windows.Forms.Label();
            this.radCliente = new System.Windows.Forms.RadioButton();
            this.radFuncionario = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radFornecedor = new System.Windows.Forms.RadioButton();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.maskedTxtSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.maskTxtConfirmarSenha = new System.Windows.Forms.MaskedTextBox();
            this.lblConfirmarSenha = new System.Windows.Forms.Label();
            this.checkExibirSenha = new System.Windows.Forms.CheckBox();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.grupoFuncionario = new System.Windows.Forms.GroupBox();
            this.dgvUsuario = new System.Windows.Forms.DataGridView();
            this.idusuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cpfDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rgDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sexoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nascimentoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datacadastroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estadoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idenderecoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logradouroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bairroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ufDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cepDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idcontatoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numerotelefoneDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.viewuserBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox1.SuspendLayout();
            this.panelEstado.SuspendLayout();
            this.panelSexo.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.grupoFuncionario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.maskTxtCPFCNPJ);
            this.groupBox1.Controls.Add(this.maskedTxtNascimento);
            this.groupBox1.Controls.Add(this.panelEstado);
            this.groupBox1.Controls.Add(this.panelSexo);
            this.groupBox1.Controls.Add(this.lblNascimento);
            this.groupBox1.Controls.Add(this.lblEstado);
            this.groupBox1.Controls.Add(this.lblSexo);
            this.groupBox1.Controls.Add(this.txtRGRepresentante);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.lblRGRepresentante);
            this.groupBox1.Controls.Add(this.lblCPFNNPJ);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(785, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Usuário";
            // 
            // maskTxtCPFCNPJ
            // 
            this.maskTxtCPFCNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.maskTxtCPFCNPJ.Location = new System.Drawing.Point(373, 23);
            this.maskTxtCPFCNPJ.Mask = "###.###.###-##";
            this.maskTxtCPFCNPJ.Name = "maskTxtCPFCNPJ";
            this.maskTxtCPFCNPJ.Size = new System.Drawing.Size(114, 20);
            this.maskTxtCPFCNPJ.TabIndex = 44;
            // 
            // maskedTxtNascimento
            // 
            this.maskedTxtNascimento.Location = new System.Drawing.Point(78, 49);
            this.maskedTxtNascimento.Mask = "##/##/####";
            this.maskedTxtNascimento.Name = "maskedTxtNascimento";
            this.maskedTxtNascimento.Size = new System.Drawing.Size(142, 20);
            this.maskedTxtNascimento.TabIndex = 13;
            // 
            // panelEstado
            // 
            this.panelEstado.Controls.Add(this.radNaoAtivo);
            this.panelEstado.Controls.Add(this.radAtivo);
            this.panelEstado.Location = new System.Drawing.Point(493, 47);
            this.panelEstado.Name = "panelEstado";
            this.panelEstado.Size = new System.Drawing.Size(167, 31);
            this.panelEstado.TabIndex = 43;
            // 
            // radNaoAtivo
            // 
            this.radNaoAtivo.AutoSize = true;
            this.radNaoAtivo.Location = new System.Drawing.Point(80, 6);
            this.radNaoAtivo.Name = "radNaoAtivo";
            this.radNaoAtivo.Size = new System.Drawing.Size(72, 17);
            this.radNaoAtivo.TabIndex = 1;
            this.radNaoAtivo.Text = "Não Ativo";
            this.radNaoAtivo.UseVisualStyleBackColor = true;
            // 
            // radAtivo
            // 
            this.radAtivo.AutoSize = true;
            this.radAtivo.Checked = true;
            this.radAtivo.Location = new System.Drawing.Point(14, 6);
            this.radAtivo.Name = "radAtivo";
            this.radAtivo.Size = new System.Drawing.Size(49, 17);
            this.radAtivo.TabIndex = 0;
            this.radAtivo.TabStop = true;
            this.radAtivo.Text = "Ativo";
            this.radAtivo.UseVisualStyleBackColor = true;
            // 
            // panelSexo
            // 
            this.panelSexo.Controls.Add(this.radFeminino);
            this.panelSexo.Controls.Add(this.radMasculino);
            this.panelSexo.Location = new System.Drawing.Point(268, 47);
            this.panelSexo.Name = "panelSexo";
            this.panelSexo.Size = new System.Drawing.Size(167, 31);
            this.panelSexo.TabIndex = 30;
            // 
            // radFeminino
            // 
            this.radFeminino.AutoSize = true;
            this.radFeminino.Location = new System.Drawing.Point(82, 5);
            this.radFeminino.Name = "radFeminino";
            this.radFeminino.Size = new System.Drawing.Size(67, 17);
            this.radFeminino.TabIndex = 1;
            this.radFeminino.Text = "Feminino";
            this.radFeminino.UseVisualStyleBackColor = true;
            // 
            // radMasculino
            // 
            this.radMasculino.AutoSize = true;
            this.radMasculino.Checked = true;
            this.radMasculino.Location = new System.Drawing.Point(4, 5);
            this.radMasculino.Name = "radMasculino";
            this.radMasculino.Size = new System.Drawing.Size(73, 17);
            this.radMasculino.TabIndex = 0;
            this.radMasculino.TabStop = true;
            this.radMasculino.Text = "Masculino";
            this.radMasculino.UseVisualStyleBackColor = true;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(6, 52);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(66, 13);
            this.lblNascimento.TabIndex = 12;
            this.lblNascimento.Text = "Nascimento:";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(441, 52);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(46, 13);
            this.lblEstado.TabIndex = 42;
            this.lblEstado.Text = " Estado:";
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(226, 52);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 29;
            this.lblSexo.Text = "Sexo:";
            // 
            // txtRGRepresentante
            // 
            this.txtRGRepresentante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtRGRepresentante.Location = new System.Drawing.Point(583, 23);
            this.txtRGRepresentante.MaxLength = 20;
            this.txtRGRepresentante.Name = "txtRGRepresentante";
            this.txtRGRepresentante.Size = new System.Drawing.Size(193, 20);
            this.txtRGRepresentante.TabIndex = 5;
            this.txtRGRepresentante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRG_KeyPress);
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNome.Location = new System.Drawing.Point(50, 23);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(281, 20);
            this.txtNome.TabIndex = 3;
            // 
            // lblRGRepresentante
            // 
            this.lblRGRepresentante.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblRGRepresentante.AutoSize = true;
            this.lblRGRepresentante.Location = new System.Drawing.Point(551, 26);
            this.lblRGRepresentante.Name = "lblRGRepresentante";
            this.lblRGRepresentante.Size = new System.Drawing.Size(26, 13);
            this.lblRGRepresentante.TabIndex = 2;
            this.lblRGRepresentante.Text = "RG:";
            // 
            // lblCPFNNPJ
            // 
            this.lblCPFNNPJ.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCPFNNPJ.AutoSize = true;
            this.lblCPFNNPJ.Location = new System.Drawing.Point(337, 26);
            this.lblCPFNNPJ.Name = "lblCPFNNPJ";
            this.lblCPFNNPJ.Size = new System.Drawing.Size(30, 13);
            this.lblCPFNNPJ.TabIndex = 1;
            this.lblCPFNNPJ.Text = "CPF:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 26);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.BackColor = System.Drawing.Color.Lime;
            this.btnSalvar.Location = new System.Drawing.Point(480, 10);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtCEP);
            this.groupBox2.Controls.Add(this.lblCep);
            this.groupBox2.Controls.Add(this.lblUf);
            this.groupBox2.Controls.Add(this.txtUF);
            this.groupBox2.Controls.Add(this.txtCidade);
            this.groupBox2.Controls.Add(this.lblCidade);
            this.groupBox2.Controls.Add(this.txtNumeroCasa);
            this.groupBox2.Controls.Add(this.lblNumeroCasa);
            this.groupBox2.Controls.Add(this.lblBairro);
            this.groupBox2.Controls.Add(this.txtLogradouro);
            this.groupBox2.Controls.Add(this.txtBairro);
            this.groupBox2.Controls.Add(this.lblLogradouro);
            this.groupBox2.Location = new System.Drawing.Point(12, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(785, 72);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Endereço";
            // 
            // txtCEP
            // 
            this.txtCEP.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCEP.Location = new System.Drawing.Point(627, 46);
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(149, 20);
            this.txtCEP.TabIndex = 27;
            this.txtCEP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCEP_KeyPress);
            // 
            // lblCep
            // 
            this.lblCep.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCep.AutoSize = true;
            this.lblCep.Location = new System.Drawing.Point(590, 49);
            this.lblCep.Name = "lblCep";
            this.lblCep.Size = new System.Drawing.Size(31, 13);
            this.lblCep.TabIndex = 26;
            this.lblCep.Text = "CEP:";
            // 
            // lblUf
            // 
            this.lblUf.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUf.AutoSize = true;
            this.lblUf.Location = new System.Drawing.Point(339, 49);
            this.lblUf.Name = "lblUf";
            this.lblUf.Size = new System.Drawing.Size(24, 13);
            this.lblUf.TabIndex = 25;
            this.lblUf.Text = "UF:";
            // 
            // txtUF
            // 
            this.txtUF.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtUF.Location = new System.Drawing.Point(380, 46);
            this.txtUF.MaxLength = 2;
            this.txtUF.Name = "txtUF";
            this.txtUF.Size = new System.Drawing.Size(204, 20);
            this.txtUF.TabIndex = 24;
            // 
            // txtCidade
            // 
            this.txtCidade.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCidade.Location = new System.Drawing.Point(76, 46);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(261, 20);
            this.txtCidade.TabIndex = 23;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(6, 49);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(43, 13);
            this.lblCidade.TabIndex = 22;
            this.lblCidade.Text = "Cidade:";
            // 
            // txtNumeroCasa
            // 
            this.txtNumeroCasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNumeroCasa.Location = new System.Drawing.Point(669, 20);
            this.txtNumeroCasa.MaxLength = 8;
            this.txtNumeroCasa.Name = "txtNumeroCasa";
            this.txtNumeroCasa.Size = new System.Drawing.Size(107, 20);
            this.txtNumeroCasa.TabIndex = 20;
            this.txtNumeroCasa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNumeroCasa_KeyPress);
            // 
            // lblNumeroCasa
            // 
            this.lblNumeroCasa.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNumeroCasa.AutoSize = true;
            this.lblNumeroCasa.Location = new System.Drawing.Point(589, 23);
            this.lblNumeroCasa.Name = "lblNumeroCasa";
            this.lblNumeroCasa.Size = new System.Drawing.Size(74, 13);
            this.lblNumeroCasa.TabIndex = 19;
            this.lblNumeroCasa.Text = "Número Casa:";
            // 
            // lblBairro
            // 
            this.lblBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(339, 23);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(37, 13);
            this.lblBairro.TabIndex = 18;
            this.lblBairro.Text = "Bairro:";
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLogradouro.Location = new System.Drawing.Point(76, 20);
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(261, 20);
            this.txtLogradouro.TabIndex = 16;
            // 
            // txtBairro
            // 
            this.txtBairro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtBairro.Location = new System.Drawing.Point(380, 20);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(204, 20);
            this.txtBairro.TabIndex = 17;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(6, 23);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(64, 13);
            this.lblLogradouro.TabIndex = 15;
            this.lblLogradouro.Text = "Logradouro:";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.txtEmail);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.maskedTxtTelefone);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 205);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(785, 51);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Contato";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtEmail.Location = new System.Drawing.Point(375, 22);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(305, 20);
            this.txtEmail.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "E-mail:";
            // 
            // maskedTxtTelefone
            // 
            this.maskedTxtTelefone.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.maskedTxtTelefone.Location = new System.Drawing.Point(119, 22);
            this.maskedTxtTelefone.Mask = "## #####-####";
            this.maskedTxtTelefone.Name = "maskedTxtTelefone";
            this.maskedTxtTelefone.Size = new System.Drawing.Size(194, 20);
            this.maskedTxtTelefone.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Número de Telefone:";
            // 
            // lblTipoCadastro
            // 
            this.lblTipoCadastro.AutoSize = true;
            this.lblTipoCadastro.Location = new System.Drawing.Point(16, 15);
            this.lblTipoCadastro.Name = "lblTipoCadastro";
            this.lblTipoCadastro.Size = new System.Drawing.Size(91, 13);
            this.lblTipoCadastro.TabIndex = 27;
            this.lblTipoCadastro.Text = "Tipo de Cadastro:";
            // 
            // radCliente
            // 
            this.radCliente.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radCliente.AutoSize = true;
            this.radCliente.Checked = true;
            this.radCliente.Location = new System.Drawing.Point(16, 10);
            this.radCliente.Name = "radCliente";
            this.radCliente.Size = new System.Drawing.Size(57, 17);
            this.radCliente.TabIndex = 1;
            this.radCliente.TabStop = true;
            this.radCliente.Text = "Cliente";
            this.radCliente.UseVisualStyleBackColor = true;
            this.radCliente.CheckedChanged += new System.EventHandler(this.radCliente_CheckedChanged);
            // 
            // radFuncionario
            // 
            this.radFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.radFuncionario.AutoSize = true;
            this.radFuncionario.Location = new System.Drawing.Point(191, 10);
            this.radFuncionario.Name = "radFuncionario";
            this.radFuncionario.Size = new System.Drawing.Size(80, 17);
            this.radFuncionario.TabIndex = 0;
            this.radFuncionario.Text = "Funcionario";
            this.radFuncionario.UseVisualStyleBackColor = true;
            this.radFuncionario.CheckedChanged += new System.EventHandler(this.radFuncionario_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.radFornecedor);
            this.panel1.Controls.Add(this.radCliente);
            this.panel1.Controls.Add(this.radFuncionario);
            this.panel1.Location = new System.Drawing.Point(113, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(284, 43);
            this.panel1.TabIndex = 28;
            // 
            // radFornecedor
            // 
            this.radFornecedor.AutoSize = true;
            this.radFornecedor.Location = new System.Drawing.Point(93, 11);
            this.radFornecedor.Name = "radFornecedor";
            this.radFornecedor.Size = new System.Drawing.Size(79, 17);
            this.radFornecedor.TabIndex = 2;
            this.radFornecedor.TabStop = true;
            this.radFornecedor.Text = "Fornecedor";
            this.radFornecedor.UseVisualStyleBackColor = true;
            this.radFornecedor.CheckedChanged += new System.EventHandler(this.radFornecedor_CheckedChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.Blue;
            this.btnLimpar.Location = new System.Drawing.Point(717, 10);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(60, 13);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(187, 20);
            this.txtUsuario.TabIndex = 35;
            this.txtUsuario.Visible = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(12, 16);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 34;
            this.lblUsuario.Text = "Usuário:";
            this.lblUsuario.Visible = false;
            // 
            // maskedTxtSenha
            // 
            this.maskedTxtSenha.Location = new System.Drawing.Point(297, 13);
            this.maskedTxtSenha.Name = "maskedTxtSenha";
            this.maskedTxtSenha.PasswordChar = '*';
            this.maskedTxtSenha.Size = new System.Drawing.Size(144, 20);
            this.maskedTxtSenha.TabIndex = 37;
            this.maskedTxtSenha.Visible = false;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(250, 16);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(41, 13);
            this.lblSenha.TabIndex = 36;
            this.lblSenha.Text = "Senha:";
            this.lblSenha.Visible = false;
            // 
            // maskTxtConfirmarSenha
            // 
            this.maskTxtConfirmarSenha.Location = new System.Drawing.Point(516, 13);
            this.maskTxtConfirmarSenha.Name = "maskTxtConfirmarSenha";
            this.maskTxtConfirmarSenha.PasswordChar = '*';
            this.maskTxtConfirmarSenha.Size = new System.Drawing.Size(172, 20);
            this.maskTxtConfirmarSenha.TabIndex = 39;
            this.maskTxtConfirmarSenha.Visible = false;
            // 
            // lblConfirmarSenha
            // 
            this.lblConfirmarSenha.AutoSize = true;
            this.lblConfirmarSenha.Location = new System.Drawing.Point(444, 16);
            this.lblConfirmarSenha.Name = "lblConfirmarSenha";
            this.lblConfirmarSenha.Size = new System.Drawing.Size(69, 13);
            this.lblConfirmarSenha.TabIndex = 38;
            this.lblConfirmarSenha.Text = "Confirmação:";
            this.lblConfirmarSenha.Visible = false;
            // 
            // checkExibirSenha
            // 
            this.checkExibirSenha.AutoSize = true;
            this.checkExibirSenha.Location = new System.Drawing.Point(694, 16);
            this.checkExibirSenha.Name = "checkExibirSenha";
            this.checkExibirSenha.Size = new System.Drawing.Size(85, 17);
            this.checkExibirSenha.TabIndex = 41;
            this.checkExibirSenha.Text = "Exibir Senha";
            this.checkExibirSenha.UseVisualStyleBackColor = true;
            this.checkExibirSenha.Visible = false;
            this.checkExibirSenha.CheckedChanged += new System.EventHandler(this.checkExibirSenha_CheckedChanged);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.BackColor = System.Drawing.Color.Red;
            this.btnExcluir.Location = new System.Drawing.Point(596, 10);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 42;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // grupoFuncionario
            // 
            this.grupoFuncionario.Controls.Add(this.txtUsuario);
            this.grupoFuncionario.Controls.Add(this.lblUsuario);
            this.grupoFuncionario.Controls.Add(this.checkExibirSenha);
            this.grupoFuncionario.Controls.Add(this.lblSenha);
            this.grupoFuncionario.Controls.Add(this.maskedTxtSenha);
            this.grupoFuncionario.Controls.Add(this.maskTxtConfirmarSenha);
            this.grupoFuncionario.Controls.Add(this.lblConfirmarSenha);
            this.grupoFuncionario.Location = new System.Drawing.Point(12, 257);
            this.grupoFuncionario.Name = "grupoFuncionario";
            this.grupoFuncionario.Size = new System.Drawing.Size(785, 43);
            this.grupoFuncionario.TabIndex = 43;
            this.grupoFuncionario.TabStop = false;
            this.grupoFuncionario.Text = "Funcionário";
            this.grupoFuncionario.Visible = false;
            // 
            // dgvUsuario
            // 
            this.dgvUsuario.AllowUserToAddRows = false;
            this.dgvUsuario.AllowUserToDeleteRows = false;
            this.dgvUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUsuario.AutoGenerateColumns = false;
            this.dgvUsuario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUsuario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idusuarioDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.cpfDataGridViewTextBoxColumn,
            this.rgDataGridViewTextBoxColumn,
            this.sexoDataGridViewTextBoxColumn,
            this.nascimentoDataGridViewTextBoxColumn,
            this.datacadastroDataGridViewTextBoxColumn,
            this.estadoDataGridViewTextBoxColumn,
            this.idenderecoDataGridViewTextBoxColumn,
            this.logradouroDataGridViewTextBoxColumn,
            this.bairroDataGridViewTextBoxColumn,
            this.cidadeDataGridViewTextBoxColumn,
            this.ufDataGridViewTextBoxColumn,
            this.cepDataGridViewTextBoxColumn,
            this.numeroDataGridViewTextBoxColumn,
            this.idcontatoDataGridViewTextBoxColumn,
            this.numerotelefoneDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.dgvUsuario.DataSource = this.viewuserBindingSource;
            this.dgvUsuario.Location = new System.Drawing.Point(12, 304);
            this.dgvUsuario.Name = "dgvUsuario";
            this.dgvUsuario.ReadOnly = true;
            this.dgvUsuario.Size = new System.Drawing.Size(776, 143);
            this.dgvUsuario.TabIndex = 40;
            this.dgvUsuario.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUsuario_CellDoubleClick);
            // 
            // idusuarioDataGridViewTextBoxColumn
            // 
            this.idusuarioDataGridViewTextBoxColumn.DataPropertyName = "idusuario";
            this.idusuarioDataGridViewTextBoxColumn.HeaderText = "idusuario";
            this.idusuarioDataGridViewTextBoxColumn.Name = "idusuarioDataGridViewTextBoxColumn";
            this.idusuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.idusuarioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cpfDataGridViewTextBoxColumn
            // 
            this.cpfDataGridViewTextBoxColumn.DataPropertyName = "cpf";
            this.cpfDataGridViewTextBoxColumn.HeaderText = "cpf";
            this.cpfDataGridViewTextBoxColumn.Name = "cpfDataGridViewTextBoxColumn";
            this.cpfDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rgDataGridViewTextBoxColumn
            // 
            this.rgDataGridViewTextBoxColumn.DataPropertyName = "rg";
            this.rgDataGridViewTextBoxColumn.HeaderText = "rg";
            this.rgDataGridViewTextBoxColumn.Name = "rgDataGridViewTextBoxColumn";
            this.rgDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sexoDataGridViewTextBoxColumn
            // 
            this.sexoDataGridViewTextBoxColumn.DataPropertyName = "sexo";
            this.sexoDataGridViewTextBoxColumn.HeaderText = "sexo";
            this.sexoDataGridViewTextBoxColumn.Name = "sexoDataGridViewTextBoxColumn";
            this.sexoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nascimentoDataGridViewTextBoxColumn
            // 
            this.nascimentoDataGridViewTextBoxColumn.DataPropertyName = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.HeaderText = "nascimento";
            this.nascimentoDataGridViewTextBoxColumn.Name = "nascimentoDataGridViewTextBoxColumn";
            this.nascimentoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // datacadastroDataGridViewTextBoxColumn
            // 
            this.datacadastroDataGridViewTextBoxColumn.DataPropertyName = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.HeaderText = "data_cadastro";
            this.datacadastroDataGridViewTextBoxColumn.Name = "datacadastroDataGridViewTextBoxColumn";
            this.datacadastroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // estadoDataGridViewTextBoxColumn
            // 
            this.estadoDataGridViewTextBoxColumn.DataPropertyName = "estado";
            this.estadoDataGridViewTextBoxColumn.HeaderText = "estado";
            this.estadoDataGridViewTextBoxColumn.Name = "estadoDataGridViewTextBoxColumn";
            this.estadoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idenderecoDataGridViewTextBoxColumn
            // 
            this.idenderecoDataGridViewTextBoxColumn.DataPropertyName = "idendereco";
            this.idenderecoDataGridViewTextBoxColumn.HeaderText = "idendereco";
            this.idenderecoDataGridViewTextBoxColumn.Name = "idenderecoDataGridViewTextBoxColumn";
            this.idenderecoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idenderecoDataGridViewTextBoxColumn.Visible = false;
            // 
            // logradouroDataGridViewTextBoxColumn
            // 
            this.logradouroDataGridViewTextBoxColumn.DataPropertyName = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.HeaderText = "logradouro";
            this.logradouroDataGridViewTextBoxColumn.Name = "logradouroDataGridViewTextBoxColumn";
            this.logradouroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // bairroDataGridViewTextBoxColumn
            // 
            this.bairroDataGridViewTextBoxColumn.DataPropertyName = "bairro";
            this.bairroDataGridViewTextBoxColumn.HeaderText = "bairro";
            this.bairroDataGridViewTextBoxColumn.Name = "bairroDataGridViewTextBoxColumn";
            this.bairroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cidadeDataGridViewTextBoxColumn
            // 
            this.cidadeDataGridViewTextBoxColumn.DataPropertyName = "cidade";
            this.cidadeDataGridViewTextBoxColumn.HeaderText = "cidade";
            this.cidadeDataGridViewTextBoxColumn.Name = "cidadeDataGridViewTextBoxColumn";
            this.cidadeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ufDataGridViewTextBoxColumn
            // 
            this.ufDataGridViewTextBoxColumn.DataPropertyName = "uf";
            this.ufDataGridViewTextBoxColumn.HeaderText = "uf";
            this.ufDataGridViewTextBoxColumn.Name = "ufDataGridViewTextBoxColumn";
            this.ufDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cepDataGridViewTextBoxColumn
            // 
            this.cepDataGridViewTextBoxColumn.DataPropertyName = "cep";
            this.cepDataGridViewTextBoxColumn.HeaderText = "cep";
            this.cepDataGridViewTextBoxColumn.Name = "cepDataGridViewTextBoxColumn";
            this.cepDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // numeroDataGridViewTextBoxColumn
            // 
            this.numeroDataGridViewTextBoxColumn.DataPropertyName = "numero";
            this.numeroDataGridViewTextBoxColumn.HeaderText = "numero";
            this.numeroDataGridViewTextBoxColumn.Name = "numeroDataGridViewTextBoxColumn";
            this.numeroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idcontatoDataGridViewTextBoxColumn
            // 
            this.idcontatoDataGridViewTextBoxColumn.DataPropertyName = "idcontato";
            this.idcontatoDataGridViewTextBoxColumn.HeaderText = "idcontato";
            this.idcontatoDataGridViewTextBoxColumn.Name = "idcontatoDataGridViewTextBoxColumn";
            this.idcontatoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idcontatoDataGridViewTextBoxColumn.Visible = false;
            // 
            // numerotelefoneDataGridViewTextBoxColumn
            // 
            this.numerotelefoneDataGridViewTextBoxColumn.DataPropertyName = "numero_telefone";
            this.numerotelefoneDataGridViewTextBoxColumn.HeaderText = "numero_telefone";
            this.numerotelefoneDataGridViewTextBoxColumn.Name = "numerotelefoneDataGridViewTextBoxColumn";
            this.numerotelefoneDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // viewuserBindingSource
            // 
            this.viewuserBindingSource.DataSource = typeof(Oficina.Modelos.view_user);
            // 
            // FrmCadastroUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grupoFuncionario);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.dgvUsuario);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblTipoCadastro);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.Name = "FrmCadastroUsuario";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Usuários";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panelEstado.ResumeLayout(false);
            this.panelEstado.PerformLayout();
            this.panelSexo.ResumeLayout(false);
            this.panelSexo.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.grupoFuncionario.ResumeLayout(false);
            this.grupoFuncionario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.viewuserBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label lblRGRepresentante;
        private System.Windows.Forms.Label lblCPFNNPJ;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtRGRepresentante;
        private System.Windows.Forms.Panel panelSexo;
        private System.Windows.Forms.RadioButton radFeminino;
        private System.Windows.Forms.RadioButton radMasculino;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.MaskedTextBox maskedTxtNascimento;
        private System.Windows.Forms.Panel panelEstado;
        private System.Windows.Forms.RadioButton radNaoAtivo;
        private System.Windows.Forms.RadioButton radAtivo;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNumeroCasa;
        private System.Windows.Forms.Label lblNumeroCasa;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label lblCep;
        private System.Windows.Forms.Label lblUf;
        private System.Windows.Forms.TextBox txtUF;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox maskedTxtTelefone;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoCadastro;
        private System.Windows.Forms.RadioButton radCliente;
        private System.Windows.Forms.RadioButton radFuncionario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.MaskedTextBox maskedTxtSenha;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.MaskedTextBox maskTxtConfirmarSenha;
        private System.Windows.Forms.Label lblConfirmarSenha;
        private System.Windows.Forms.CheckBox checkExibirSenha;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.GroupBox grupoFuncionario;
        private System.Windows.Forms.MaskedTextBox maskTxtCPFCNPJ;
        private System.Windows.Forms.RadioButton radFornecedor;
        private System.Windows.Forms.BindingSource viewuserBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numerotelefoneDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idcontatoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cepDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ufDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bairroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logradouroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idenderecoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estadoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn datacadastroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nascimentoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sexoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rgDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cpfDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idusuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dgvUsuario;
    }
}

