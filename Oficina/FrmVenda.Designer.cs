namespace Oficina
{
    partial class FrmVenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVenda));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtCodigoProduto = new System.Windows.Forms.TextBox();
            this.txtQtdEmEstoque = new System.Windows.Forms.TextBox();
            this.lblQtdEmEstoque = new System.Windows.Forms.Label();
            this.dgvVenda = new System.Windows.Forms.DataGridView();
            this.txtDesconto = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtValorTotal = new System.Windows.Forms.TextBox();
            this.lblValorTotal = new System.Windows.Forms.Label();
            this.btnFinalizar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtProduto = new System.Windows.Forms.TextBox();
            this.lblProduto = new System.Windows.Forms.Label();
            this.txtQtd = new System.Windows.Forms.TextBox();
            this.lblQtd = new System.Windows.Forms.Label();
            this.txtValorUnitario = new System.Windows.Forms.TextBox();
            this.lblValorUnitario = new System.Windows.Forms.Label();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.lblCodigoBarras = new System.Windows.Forms.Label();
            this.groupBoxServico = new System.Windows.Forms.GroupBox();
            this.cmbMecanico = new System.Windows.Forms.ComboBox();
            this.mecanicoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtValorServico = new System.Windows.Forms.TextBox();
            this.richTxtBoxDescricao = new System.Windows.Forms.RichTextBox();
            this.lblValorServico = new System.Windows.Forms.Label();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.groupBoxCliente = new System.Windows.Forms.GroupBox();
            this.btnLimparPagamento = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPagamento = new System.Windows.Forms.TextBox();
            this.btnPagar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.panelTipoCliente = new System.Windows.Forms.Panel();
            this.radNaoCadastrado = new System.Windows.Forms.RadioButton();
            this.radCadastrado = new System.Windows.Forms.RadioButton();
            this.lblTipoCliente = new System.Windows.Forms.Label();
            this.txtContaCliente = new System.Windows.Forms.TextBox();
            this.lblContaCliente = new System.Windows.Forms.Label();
            this.panelPagamento = new System.Windows.Forms.Panel();
            this.radAPrazo = new System.Windows.Forms.RadioButton();
            this.radAVista = new System.Windows.Forms.RadioButton();
            this.lblFormaPagamento = new System.Windows.Forms.Label();
            this.comboBoxNomeCliente = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblNomeCliente = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).BeginInit();
            this.groupBoxServico.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecanicoBindingSource)).BeginInit();
            this.groupBoxCliente.SuspendLayout();
            this.panelTipoCliente.SuspendLayout();
            this.panelPagamento.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtCodigoProduto);
            this.groupBox1.Controls.Add(this.txtQtdEmEstoque);
            this.groupBox1.Controls.Add(this.lblQtdEmEstoque);
            this.groupBox1.Controls.Add(this.dgvVenda);
            this.groupBox1.Controls.Add(this.txtDesconto);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtValorTotal);
            this.groupBox1.Controls.Add(this.lblValorTotal);
            this.groupBox1.Controls.Add(this.btnFinalizar);
            this.groupBox1.Controls.Add(this.btnInserir);
            this.groupBox1.Controls.Add(this.txtProduto);
            this.groupBox1.Controls.Add(this.lblProduto);
            this.groupBox1.Controls.Add(this.txtQtd);
            this.groupBox1.Controls.Add(this.lblQtd);
            this.groupBox1.Controls.Add(this.txtValorUnitario);
            this.groupBox1.Controls.Add(this.lblValorUnitario);
            this.groupBox1.Controls.Add(this.txtCodigoBarras);
            this.groupBox1.Controls.Add(this.lblCodigoBarras);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(459, 478);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Venda";
            // 
            // txtCodigoProduto
            // 
            this.txtCodigoProduto.Location = new System.Drawing.Point(273, 103);
            this.txtCodigoProduto.Name = "txtCodigoProduto";
            this.txtCodigoProduto.Size = new System.Drawing.Size(180, 20);
            this.txtCodigoProduto.TabIndex = 18;
            this.txtCodigoProduto.Visible = false;
            // 
            // txtQtdEmEstoque
            // 
            this.txtQtdEmEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtdEmEstoque.Enabled = false;
            this.txtQtdEmEstoque.Location = new System.Drawing.Point(61, 72);
            this.txtQtdEmEstoque.Name = "txtQtdEmEstoque";
            this.txtQtdEmEstoque.Size = new System.Drawing.Size(117, 20);
            this.txtQtdEmEstoque.TabIndex = 17;
            // 
            // lblQtdEmEstoque
            // 
            this.lblQtdEmEstoque.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtdEmEstoque.AutoSize = true;
            this.lblQtdEmEstoque.Location = new System.Drawing.Point(6, 75);
            this.lblQtdEmEstoque.Name = "lblQtdEmEstoque";
            this.lblQtdEmEstoque.Size = new System.Drawing.Size(49, 13);
            this.lblQtdEmEstoque.TabIndex = 16;
            this.lblQtdEmEstoque.Text = "Estoque:";
            // 
            // dgvVenda
            // 
            this.dgvVenda.AllowUserToAddRows = false;
            this.dgvVenda.AllowUserToDeleteRows = false;
            this.dgvVenda.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVenda.Location = new System.Drawing.Point(0, 133);
            this.dgvVenda.Name = "dgvVenda";
            this.dgvVenda.ReadOnly = true;
            this.dgvVenda.Size = new System.Drawing.Size(453, 335);
            this.dgvVenda.TabIndex = 15;
            this.dgvVenda.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvVenda_CellDoubleClick);
            // 
            // txtDesconto
            // 
            this.txtDesconto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDesconto.Enabled = false;
            this.txtDesconto.Location = new System.Drawing.Point(392, 44);
            this.txtDesconto.Name = "txtDesconto";
            this.txtDesconto.Size = new System.Drawing.Size(61, 20);
            this.txtDesconto.TabIndex = 14;
            this.txtDesconto.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(316, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Desconto[%]:";
            // 
            // txtValorTotal
            // 
            this.txtValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorTotal.Enabled = false;
            this.txtValorTotal.Location = new System.Drawing.Point(317, 72);
            this.txtValorTotal.Name = "txtValorTotal";
            this.txtValorTotal.Size = new System.Drawing.Size(136, 20);
            this.txtValorTotal.TabIndex = 12;
            // 
            // lblValorTotal
            // 
            this.lblValorTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblValorTotal.AutoSize = true;
            this.lblValorTotal.Location = new System.Drawing.Point(196, 75);
            this.lblValorTotal.Name = "lblValorTotal";
            this.lblValorTotal.Size = new System.Drawing.Size(115, 13);
            this.lblValorTotal.TabIndex = 11;
            this.lblValorTotal.Text = "Valor Total da Compra:";
            // 
            // btnFinalizar
            // 
            this.btnFinalizar.Location = new System.Drawing.Point(141, 103);
            this.btnFinalizar.Name = "btnFinalizar";
            this.btnFinalizar.Size = new System.Drawing.Size(126, 23);
            this.btnFinalizar.TabIndex = 10;
            this.btnFinalizar.Text = "Finalizar Compra";
            this.btnFinalizar.UseVisualStyleBackColor = true;
            this.btnFinalizar.Click += new System.EventHandler(this.btnFinalizar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(9, 103);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(126, 23);
            this.btnInserir.TabIndex = 9;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // txtProduto
            // 
            this.txtProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtProduto.Enabled = false;
            this.txtProduto.Location = new System.Drawing.Point(305, 17);
            this.txtProduto.Name = "txtProduto";
            this.txtProduto.Size = new System.Drawing.Size(148, 20);
            this.txtProduto.TabIndex = 8;
            // 
            // lblProduto
            // 
            this.lblProduto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProduto.AutoSize = true;
            this.lblProduto.Location = new System.Drawing.Point(252, 20);
            this.lblProduto.Name = "lblProduto";
            this.lblProduto.Size = new System.Drawing.Size(47, 13);
            this.lblProduto.TabIndex = 7;
            this.lblProduto.Text = "Produto:";
            // 
            // txtQtd
            // 
            this.txtQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtQtd.Enabled = false;
            this.txtQtd.Location = new System.Drawing.Point(252, 44);
            this.txtQtd.Name = "txtQtd";
            this.txtQtd.Size = new System.Drawing.Size(59, 20);
            this.txtQtd.TabIndex = 5;
            this.txtQtd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtd_KeyPress);
            // 
            // lblQtd
            // 
            this.lblQtd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblQtd.AutoSize = true;
            this.lblQtd.Location = new System.Drawing.Point(181, 47);
            this.lblQtd.Name = "lblQtd";
            this.lblQtd.Size = new System.Drawing.Size(65, 13);
            this.lblQtd.TabIndex = 4;
            this.lblQtd.Text = "Quantidade:";
            // 
            // txtValorUnitario
            // 
            this.txtValorUnitario.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtValorUnitario.Enabled = false;
            this.txtValorUnitario.Location = new System.Drawing.Point(103, 44);
            this.txtValorUnitario.Name = "txtValorUnitario";
            this.txtValorUnitario.Size = new System.Drawing.Size(75, 20);
            this.txtValorUnitario.TabIndex = 3;
            // 
            // lblValorUnitario
            // 
            this.lblValorUnitario.AutoSize = true;
            this.lblValorUnitario.Location = new System.Drawing.Point(6, 47);
            this.lblValorUnitario.Name = "lblValorUnitario";
            this.lblValorUnitario.Size = new System.Drawing.Size(73, 13);
            this.lblValorUnitario.TabIndex = 2;
            this.lblValorUnitario.Text = "Valor Unitário:";
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCodigoBarras.Location = new System.Drawing.Point(103, 17);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(143, 20);
            this.txtCodigoBarras.TabIndex = 1;
            this.txtCodigoBarras.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigoBarras_KeyPress);
            // 
            // lblCodigoBarras
            // 
            this.lblCodigoBarras.AutoSize = true;
            this.lblCodigoBarras.Location = new System.Drawing.Point(6, 20);
            this.lblCodigoBarras.Name = "lblCodigoBarras";
            this.lblCodigoBarras.Size = new System.Drawing.Size(91, 13);
            this.lblCodigoBarras.TabIndex = 0;
            this.lblCodigoBarras.Text = "Código de Barras:";
            // 
            // groupBoxServico
            // 
            this.groupBoxServico.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxServico.Controls.Add(this.cmbMecanico);
            this.groupBoxServico.Controls.Add(this.label2);
            this.groupBoxServico.Controls.Add(this.txtValorServico);
            this.groupBoxServico.Controls.Add(this.richTxtBoxDescricao);
            this.groupBoxServico.Controls.Add(this.lblValorServico);
            this.groupBoxServico.Controls.Add(this.lblDescricao);
            this.groupBoxServico.Location = new System.Drawing.Point(480, 270);
            this.groupBoxServico.Name = "groupBoxServico";
            this.groupBoxServico.Size = new System.Drawing.Size(311, 218);
            this.groupBoxServico.TabIndex = 1;
            this.groupBoxServico.TabStop = false;
            this.groupBoxServico.Text = "Serviço";
            // 
            // cmbMecanico
            // 
            this.cmbMecanico.DataSource = this.mecanicoBindingSource;
            this.cmbMecanico.DisplayMember = "apelido";
            this.cmbMecanico.FormattingEnabled = true;
            this.cmbMecanico.Location = new System.Drawing.Point(19, 37);
            this.cmbMecanico.Name = "cmbMecanico";
            this.cmbMecanico.Size = new System.Drawing.Size(286, 21);
            this.cmbMecanico.TabIndex = 48;
            this.cmbMecanico.ValueMember = "idmecanico";
            // 
            // mecanicoBindingSource
            // 
            this.mecanicoBindingSource.DataSource = typeof(Oficina.Modelos.mecanico);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mecânico";
            // 
            // txtValorServico
            // 
            this.txtValorServico.Location = new System.Drawing.Point(175, 188);
            this.txtValorServico.Name = "txtValorServico";
            this.txtValorServico.Size = new System.Drawing.Size(130, 20);
            this.txtValorServico.TabIndex = 3;
            // 
            // richTxtBoxDescricao
            // 
            this.richTxtBoxDescricao.Location = new System.Drawing.Point(19, 79);
            this.richTxtBoxDescricao.Name = "richTxtBoxDescricao";
            this.richTxtBoxDescricao.Size = new System.Drawing.Size(286, 87);
            this.richTxtBoxDescricao.TabIndex = 2;
            this.richTxtBoxDescricao.Text = "";
            // 
            // lblValorServico
            // 
            this.lblValorServico.AutoSize = true;
            this.lblValorServico.Location = new System.Drawing.Point(172, 172);
            this.lblValorServico.Name = "lblValorServico";
            this.lblValorServico.Size = new System.Drawing.Size(31, 13);
            this.lblValorServico.TabIndex = 1;
            this.lblValorServico.Text = "Valor";
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Location = new System.Drawing.Point(16, 61);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(55, 13);
            this.lblDescricao.TabIndex = 0;
            this.lblDescricao.Text = "Descrição";
            // 
            // groupBoxCliente
            // 
            this.groupBoxCliente.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxCliente.Controls.Add(this.btnLimparPagamento);
            this.groupBoxCliente.Controls.Add(this.label4);
            this.groupBoxCliente.Controls.Add(this.label3);
            this.groupBoxCliente.Controls.Add(this.txtPagamento);
            this.groupBoxCliente.Controls.Add(this.btnPagar);
            this.groupBoxCliente.Controls.Add(this.btnBuscarCliente);
            this.groupBoxCliente.Controls.Add(this.panelTipoCliente);
            this.groupBoxCliente.Controls.Add(this.lblTipoCliente);
            this.groupBoxCliente.Controls.Add(this.txtContaCliente);
            this.groupBoxCliente.Controls.Add(this.lblContaCliente);
            this.groupBoxCliente.Controls.Add(this.panelPagamento);
            this.groupBoxCliente.Controls.Add(this.lblFormaPagamento);
            this.groupBoxCliente.Controls.Add(this.comboBoxNomeCliente);
            this.groupBoxCliente.Controls.Add(this.lblNomeCliente);
            this.groupBoxCliente.Location = new System.Drawing.Point(480, 12);
            this.groupBoxCliente.Name = "groupBoxCliente";
            this.groupBoxCliente.Size = new System.Drawing.Size(311, 256);
            this.groupBoxCliente.TabIndex = 2;
            this.groupBoxCliente.TabStop = false;
            this.groupBoxCliente.Text = "Cliente";
            // 
            // btnLimparPagamento
            // 
            this.btnLimparPagamento.Location = new System.Drawing.Point(175, 226);
            this.btnLimparPagamento.Name = "btnLimparPagamento";
            this.btnLimparPagamento.Size = new System.Drawing.Size(130, 23);
            this.btnLimparPagamento.TabIndex = 53;
            this.btnLimparPagamento.Text = "Limpar";
            this.btnLimparPagamento.UseVisualStyleBackColor = true;
            this.btnLimparPagamento.Click += new System.EventHandler(this.btnLimparPagamento_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 52;
            this.label4.Tag = "";
            this.label4.Text = "R$";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(289, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 51;
            this.label3.Tag = "";
            this.label3.Text = "R$";
            // 
            // txtPagamento
            // 
            this.txtPagamento.Location = new System.Drawing.Point(175, 198);
            this.txtPagamento.Name = "txtPagamento";
            this.txtPagamento.Size = new System.Drawing.Size(113, 20);
            this.txtPagamento.TabIndex = 50;
            // 
            // btnPagar
            // 
            this.btnPagar.Location = new System.Drawing.Point(21, 197);
            this.btnPagar.Name = "btnPagar";
            this.btnPagar.Size = new System.Drawing.Size(148, 23);
            this.btnPagar.TabIndex = 49;
            this.btnPagar.Text = "Pagar";
            this.btnPagar.UseVisualStyleBackColor = true;
            this.btnPagar.Click += new System.EventHandler(this.btnPagar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(21, 168);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(148, 23);
            this.btnBuscarCliente.TabIndex = 48;
            this.btnBuscarCliente.Text = "Buscar Cliente";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // panelTipoCliente
            // 
            this.panelTipoCliente.Controls.Add(this.radNaoCadastrado);
            this.panelTipoCliente.Controls.Add(this.radCadastrado);
            this.panelTipoCliente.Location = new System.Drawing.Point(19, 29);
            this.panelTipoCliente.Name = "panelTipoCliente";
            this.panelTipoCliente.Size = new System.Drawing.Size(286, 31);
            this.panelTipoCliente.TabIndex = 45;
            // 
            // radNaoCadastrado
            // 
            this.radNaoCadastrado.AutoSize = true;
            this.radNaoCadastrado.Checked = true;
            this.radNaoCadastrado.Location = new System.Drawing.Point(114, 7);
            this.radNaoCadastrado.Name = "radNaoCadastrado";
            this.radNaoCadastrado.Size = new System.Drawing.Size(102, 17);
            this.radNaoCadastrado.TabIndex = 1;
            this.radNaoCadastrado.TabStop = true;
            this.radNaoCadastrado.Text = "Não Cadastrado";
            this.radNaoCadastrado.UseVisualStyleBackColor = true;
            // 
            // radCadastrado
            // 
            this.radCadastrado.AutoSize = true;
            this.radCadastrado.Location = new System.Drawing.Point(14, 7);
            this.radCadastrado.Name = "radCadastrado";
            this.radCadastrado.Size = new System.Drawing.Size(79, 17);
            this.radCadastrado.TabIndex = 0;
            this.radCadastrado.Text = "Cadastrado";
            this.radCadastrado.UseVisualStyleBackColor = true;
            // 
            // lblTipoCliente
            // 
            this.lblTipoCliente.AutoSize = true;
            this.lblTipoCliente.Location = new System.Drawing.Point(16, 13);
            this.lblTipoCliente.Name = "lblTipoCliente";
            this.lblTipoCliente.Size = new System.Drawing.Size(78, 13);
            this.lblTipoCliente.TabIndex = 47;
            this.lblTipoCliente.Text = "Tipo de Cliente";
            // 
            // txtContaCliente
            // 
            this.txtContaCliente.Location = new System.Drawing.Point(175, 170);
            this.txtContaCliente.Name = "txtContaCliente";
            this.txtContaCliente.Size = new System.Drawing.Size(113, 20);
            this.txtContaCliente.TabIndex = 46;
            this.txtContaCliente.Tag = "";
            // 
            // lblContaCliente
            // 
            this.lblContaCliente.AutoSize = true;
            this.lblContaCliente.Location = new System.Drawing.Point(172, 154);
            this.lblContaCliente.Name = "lblContaCliente";
            this.lblContaCliente.Size = new System.Drawing.Size(35, 13);
            this.lblContaCliente.TabIndex = 45;
            this.lblContaCliente.Text = "Conta";
            // 
            // panelPagamento
            // 
            this.panelPagamento.Controls.Add(this.radAPrazo);
            this.panelPagamento.Controls.Add(this.radAVista);
            this.panelPagamento.Location = new System.Drawing.Point(19, 80);
            this.panelPagamento.Name = "panelPagamento";
            this.panelPagamento.Size = new System.Drawing.Size(286, 31);
            this.panelPagamento.TabIndex = 44;
            // 
            // radAPrazo
            // 
            this.radAPrazo.AutoSize = true;
            this.radAPrazo.Location = new System.Drawing.Point(114, 7);
            this.radAPrazo.Name = "radAPrazo";
            this.radAPrazo.Size = new System.Drawing.Size(62, 17);
            this.radAPrazo.TabIndex = 1;
            this.radAPrazo.Text = "À Prazo";
            this.radAPrazo.UseVisualStyleBackColor = true;
            // 
            // radAVista
            // 
            this.radAVista.AutoSize = true;
            this.radAVista.Checked = true;
            this.radAVista.Location = new System.Drawing.Point(14, 7);
            this.radAVista.Name = "radAVista";
            this.radAVista.Size = new System.Drawing.Size(58, 17);
            this.radAVista.TabIndex = 0;
            this.radAVista.TabStop = true;
            this.radAVista.Text = "À Vista";
            this.radAVista.UseVisualStyleBackColor = true;
            // 
            // lblFormaPagamento
            // 
            this.lblFormaPagamento.AutoSize = true;
            this.lblFormaPagamento.Location = new System.Drawing.Point(16, 63);
            this.lblFormaPagamento.Name = "lblFormaPagamento";
            this.lblFormaPagamento.Size = new System.Drawing.Size(108, 13);
            this.lblFormaPagamento.TabIndex = 2;
            this.lblFormaPagamento.Text = "Forma de Pagamento";
            // 
            // comboBoxNomeCliente
            // 
            this.comboBoxNomeCliente.DataSource = this.clienteBindingSource;
            this.comboBoxNomeCliente.DisplayMember = "idcliente";
            this.comboBoxNomeCliente.FormattingEnabled = true;
            this.comboBoxNomeCliente.Location = new System.Drawing.Point(21, 133);
            this.comboBoxNomeCliente.Name = "comboBoxNomeCliente";
            this.comboBoxNomeCliente.Size = new System.Drawing.Size(286, 21);
            this.comboBoxNomeCliente.TabIndex = 1;
            this.comboBoxNomeCliente.ValueMember = "idcliente";
            this.comboBoxNomeCliente.TextChanged += new System.EventHandler(this.comboBoxNomeCliente_TextChanged);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataSource = typeof(Oficina.Modelos.cliente);
            // 
            // lblNomeCliente
            // 
            this.lblNomeCliente.AutoSize = true;
            this.lblNomeCliente.Location = new System.Drawing.Point(16, 117);
            this.lblNomeCliente.Name = "lblNomeCliente";
            this.lblNomeCliente.Size = new System.Drawing.Size(35, 13);
            this.lblNomeCliente.TabIndex = 0;
            this.lblNomeCliente.Text = "Nome";
            // 
            // FrmVenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.groupBoxCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBoxServico);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVenda";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Venda";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVenda)).EndInit();
            this.groupBoxServico.ResumeLayout(false);
            this.groupBoxServico.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.mecanicoBindingSource)).EndInit();
            this.groupBoxCliente.ResumeLayout(false);
            this.groupBoxCliente.PerformLayout();
            this.panelTipoCliente.ResumeLayout(false);
            this.panelTipoCliente.PerformLayout();
            this.panelPagamento.ResumeLayout(false);
            this.panelPagamento.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBoxServico;
        private System.Windows.Forms.TextBox txtQtd;
        private System.Windows.Forms.Label lblQtd;
        private System.Windows.Forms.TextBox txtValorUnitario;
        private System.Windows.Forms.Label lblValorUnitario;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label lblCodigoBarras;
        private System.Windows.Forms.TextBox txtValorTotal;
        private System.Windows.Forms.Label lblValorTotal;
        private System.Windows.Forms.Button btnFinalizar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtProduto;
        private System.Windows.Forms.Label lblProduto;
        private System.Windows.Forms.TextBox txtValorServico;
        private System.Windows.Forms.RichTextBox richTxtBoxDescricao;
        private System.Windows.Forms.Label lblValorServico;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.GroupBox groupBoxCliente;
        private System.Windows.Forms.Label lblFormaPagamento;
        private System.Windows.Forms.ComboBox comboBoxNomeCliente;
        private System.Windows.Forms.Label lblNomeCliente;
        private System.Windows.Forms.TextBox txtContaCliente;
        private System.Windows.Forms.Label lblContaCliente;
        private System.Windows.Forms.Panel panelPagamento;
        private System.Windows.Forms.RadioButton radAPrazo;
        private System.Windows.Forms.RadioButton radAVista;
        private System.Windows.Forms.Panel panelTipoCliente;
        private System.Windows.Forms.RadioButton radNaoCadastrado;
        private System.Windows.Forms.RadioButton radCadastrado;
        private System.Windows.Forms.Label lblTipoCliente;
        private System.Windows.Forms.TextBox txtDesconto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbMecanico;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvVenda;
        private System.Windows.Forms.TextBox txtQtdEmEstoque;
        private System.Windows.Forms.Label lblQtdEmEstoque;
        private System.Windows.Forms.TextBox txtCodigoProduto;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.TextBox txtPagamento;
        private System.Windows.Forms.Button btnPagar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnLimparPagamento;
        private System.Windows.Forms.BindingSource mecanicoBindingSource;
    }
}