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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void usuárioToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            FrmCadastroUsuario frm = new FrmCadastroUsuario();
            frm.MdiParent = this;
            frm.Show();
            
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            //this.Top = 0;
            //this.Left = 0;
            //this.Width = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Width;
            //this.Height = System.Windows.Forms.Screen.PrimaryScreen.Bounds.Height;

            //this.MainMenuStrip = new MenuStrip();
            
        }

        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frm = new FrmCadastroProduto();
            frm.MdiParent = this;
            frm.Show();

        }

        private void mecânicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroMecanico frm = new FrmCadastroMecanico();
            frm.MdiParent = this;
            frm.Show();
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmVenda frm = new FrmVenda();
            frm.MdiParent = this;
            frm.Show();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroCliente cadCliente = new FrmCadastroCliente();
            cadCliente.MdiParent = this;
            cadCliente.Show();
        }

        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroFornecedor cadFornecedor = new FrmCadastroFornecedor();
            cadFornecedor.MdiParent = this;
            cadFornecedor.Show();
        }
    }
}
