namespace Oficina
{
    partial class FrmCadastroProduto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadastroProduto));
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoBarras = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricaoServico = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricaoMarca = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtValorCusto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMargemAvista = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtValorAvista = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtValorPrazo = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtMargemPrazo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtValorAtacado = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMargemAtacado = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblQtdACadastrar = new System.Windows.Forms.Label();
            this.txtQtdACadastrar = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCarregarValores = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.txtQtdEstoque = new System.Windows.Forms.TextBox();
            this.btnListarPecas = new System.Windows.Forms.Button();
            this.lblMensagemCodProduto = new System.Windows.Forms.Label();
            this.cbFornecedor = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Codigo:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(44, 13);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(186, 20);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodigo_KeyPress);
            // 
            // txtCodigoBarras
            // 
            this.txtCodigoBarras.Enabled = false;
            this.txtCodigoBarras.Location = new System.Drawing.Point(99, 50);
            this.txtCodigoBarras.Name = "txtCodigoBarras";
            this.txtCodigoBarras.Size = new System.Drawing.Size(186, 20);
            this.txtCodigoBarras.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código de Barras:";
            // 
            // txtDescricaoServico
            // 
            this.txtDescricaoServico.Enabled = false;
            this.txtDescricaoServico.Location = new System.Drawing.Point(163, 80);
            this.txtDescricaoServico.Name = "txtDescricaoServico";
            this.txtDescricaoServico.Size = new System.Drawing.Size(173, 20);
            this.txtDescricaoServico.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(154, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição do Produto/Serviço:";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Enabled = false;
            this.txtUnidade.Location = new System.Drawing.Point(537, 50);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(88, 20);
            this.txtUnidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(505, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "UN:";
            // 
            // txtDescricaoMarca
            // 
            this.txtDescricaoMarca.Enabled = false;
            this.txtDescricaoMarca.Location = new System.Drawing.Point(454, 80);
            this.txtDescricaoMarca.Name = "txtDescricaoMarca";
            this.txtDescricaoMarca.Size = new System.Drawing.Size(171, 20);
            this.txtDescricaoMarca.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(342, 83);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Descrição da Marca:";
            // 
            // txtValorCusto
            // 
            this.txtValorCusto.Enabled = false;
            this.txtValorCusto.Location = new System.Drawing.Point(107, 114);
            this.txtValorCusto.Name = "txtValorCusto";
            this.txtValorCusto.Size = new System.Drawing.Size(131, 20);
            this.txtValorCusto.TabIndex = 11;
            this.txtValorCusto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.textBox6_KeyUp);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Valor Custo:";
            // 
            // txtMargemAvista
            // 
            this.txtMargemAvista.Enabled = false;
            this.txtMargemAvista.Location = new System.Drawing.Point(107, 148);
            this.txtMargemAvista.Name = "txtMargemAvista";
            this.txtMargemAvista.Size = new System.Drawing.Size(131, 20);
            this.txtMargemAvista.TabIndex = 13;
            this.txtMargemAvista.Leave += new System.EventHandler(this.txtMargemAvista_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(3, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Margem Avista[%]:";
            // 
            // txtValorAvista
            // 
            this.txtValorAvista.Enabled = false;
            this.txtValorAvista.Location = new System.Drawing.Point(336, 148);
            this.txtValorAvista.Name = "txtValorAvista";
            this.txtValorAvista.Size = new System.Drawing.Size(131, 20);
            this.txtValorAvista.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(261, 151);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 13);
            this.label8.TabIndex = 14;
            this.label8.Text = "Valor Avista:";
            // 
            // txtValorPrazo
            // 
            this.txtValorPrazo.Enabled = false;
            this.txtValorPrazo.Location = new System.Drawing.Point(336, 183);
            this.txtValorPrazo.Name = "txtValorPrazo";
            this.txtValorPrazo.Size = new System.Drawing.Size(131, 20);
            this.txtValorPrazo.TabIndex = 19;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(261, 186);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Valor Prazo:";
            // 
            // txtMargemPrazo
            // 
            this.txtMargemPrazo.Enabled = false;
            this.txtMargemPrazo.Location = new System.Drawing.Point(107, 183);
            this.txtMargemPrazo.Name = "txtMargemPrazo";
            this.txtMargemPrazo.Size = new System.Drawing.Size(131, 20);
            this.txtMargemPrazo.TabIndex = 17;
            this.txtMargemPrazo.Leave += new System.EventHandler(this.txtMargemPrazo_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 13);
            this.label10.TabIndex = 16;
            this.label10.Text = "Margem Prazo[%]:";
            // 
            // txtValorAtacado
            // 
            this.txtValorAtacado.Enabled = false;
            this.txtValorAtacado.Location = new System.Drawing.Point(336, 218);
            this.txtValorAtacado.Name = "txtValorAtacado";
            this.txtValorAtacado.Size = new System.Drawing.Size(131, 20);
            this.txtValorAtacado.TabIndex = 23;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(261, 221);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(77, 13);
            this.label11.TabIndex = 22;
            this.label11.Text = "Valor Atacado:";
            // 
            // txtMargemAtacado
            // 
            this.txtMargemAtacado.Enabled = false;
            this.txtMargemAtacado.Location = new System.Drawing.Point(107, 218);
            this.txtMargemAtacado.Name = "txtMargemAtacado";
            this.txtMargemAtacado.Size = new System.Drawing.Size(131, 20);
            this.txtMargemAtacado.TabIndex = 21;
            this.txtMargemAtacado.Leave += new System.EventHandler(this.txtMargemAtacado_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(3, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 20;
            this.label12.Text = "Margem Atacado[%]:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(291, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(64, 13);
            this.label13.TabIndex = 24;
            this.label13.Text = "Fornecedor:";
            // 
            // btnLimpar
            // 
            this.btnLimpar.Enabled = false;
            this.btnLimpar.Location = new System.Drawing.Point(376, 112);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(123, 23);
            this.btnLimpar.TabIndex = 27;
            this.btnLimpar.Text = "Limpar ";
            this.btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(502, 112);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(123, 23);
            this.btnExcluir.TabIndex = 28;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // lblQtdACadastrar
            // 
            this.lblQtdACadastrar.AutoSize = true;
            this.lblQtdACadastrar.Location = new System.Drawing.Point(376, 16);
            this.lblQtdACadastrar.Name = "lblQtdACadastrar";
            this.lblQtdACadastrar.Size = new System.Drawing.Size(122, 13);
            this.lblQtdACadastrar.TabIndex = 29;
            this.lblQtdACadastrar.Text = "Quantidade a Cadastrar:";
            // 
            // txtQtdACadastrar
            // 
            this.txtQtdACadastrar.Enabled = false;
            this.txtQtdACadastrar.Location = new System.Drawing.Point(502, 13);
            this.txtQtdACadastrar.Name = "txtQtdACadastrar";
            this.txtQtdACadastrar.Size = new System.Drawing.Size(123, 20);
            this.txtQtdACadastrar.TabIndex = 30;
            this.txtQtdACadastrar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQtdACadastrar_KeyPress);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(247, 112);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(123, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCarregarValores
            // 
            this.btnCarregarValores.Enabled = false;
            this.btnCarregarValores.Location = new System.Drawing.Point(473, 146);
            this.btnCarregarValores.Name = "btnCarregarValores";
            this.btnCarregarValores.Size = new System.Drawing.Size(152, 23);
            this.btnCarregarValores.TabIndex = 33;
            this.btnCarregarValores.Text = "Carregar Valores";
            this.btnCarregarValores.UseVisualStyleBackColor = true;
            this.btnCarregarValores.Click += new System.EventHandler(this.btnCarregarValores_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 16);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 34;
            this.label14.Text = "Estoque:";
            // 
            // txtQtdEstoque
            // 
            this.txtQtdEstoque.Enabled = false;
            this.txtQtdEstoque.Location = new System.Drawing.Point(281, 13);
            this.txtQtdEstoque.Name = "txtQtdEstoque";
            this.txtQtdEstoque.Size = new System.Drawing.Size(89, 20);
            this.txtQtdEstoque.TabIndex = 35;
            // 
            // btnListarPecas
            // 
            this.btnListarPecas.Enabled = false;
            this.btnListarPecas.Location = new System.Drawing.Point(473, 181);
            this.btnListarPecas.Name = "btnListarPecas";
            this.btnListarPecas.Size = new System.Drawing.Size(152, 23);
            this.btnListarPecas.TabIndex = 36;
            this.btnListarPecas.Text = "Listar Peças";
            this.btnListarPecas.UseVisualStyleBackColor = true;
            // 
            // lblMensagemCodProduto
            // 
            this.lblMensagemCodProduto.AutoSize = true;
            this.lblMensagemCodProduto.Location = new System.Drawing.Point(5, 36);
            this.lblMensagemCodProduto.Name = "lblMensagemCodProduto";
            this.lblMensagemCodProduto.Size = new System.Drawing.Size(0, 13);
            this.lblMensagemCodProduto.TabIndex = 37;
            this.lblMensagemCodProduto.Visible = false;
            // 
            // cbFornecedor
            // 
            this.cbFornecedor.DisplayMember = "nome";
            this.cbFornecedor.Enabled = false;
            this.cbFornecedor.FormattingEnabled = true;
            this.cbFornecedor.Location = new System.Drawing.Point(361, 50);
            this.cbFornecedor.Name = "cbFornecedor";
            this.cbFornecedor.Size = new System.Drawing.Size(138, 21);
            this.cbFornecedor.TabIndex = 25;
            this.cbFornecedor.ValueMember = "nome";
            // 
            // FrmCadastroProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 244);
            this.Controls.Add(this.lblMensagemCodProduto);
            this.Controls.Add(this.btnListarPecas);
            this.Controls.Add(this.txtQtdEstoque);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.btnCarregarValores);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.txtQtdACadastrar);
            this.Controls.Add(this.lblQtdACadastrar);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cbFornecedor);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtValorAtacado);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtMargemAtacado);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtValorPrazo);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtMargemPrazo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtValorAvista);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtMargemAvista);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtValorCusto);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtDescricaoMarca);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUnidade);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDescricaoServico);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCodigoBarras);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCadastroProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Produtos";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoBarras;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricaoServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricaoMarca;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtValorCusto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMargemAvista;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtValorAvista;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtValorPrazo;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtMargemPrazo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtValorAtacado;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtMargemAtacado;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblQtdACadastrar;
        private System.Windows.Forms.TextBox txtQtdACadastrar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCarregarValores;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtQtdEstoque;
        private System.Windows.Forms.Button btnListarPecas;
        private System.Windows.Forms.Label lblMensagemCodProduto;
        private System.Windows.Forms.ComboBox cbFornecedor;
    }
}