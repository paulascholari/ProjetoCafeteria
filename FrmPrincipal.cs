using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCafeteria
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }
          /// <summary>
          ///  esse comando serve para facilitar a abertura das telas
          /// </summary>
          /// <param name="frm"></param>
        private void AbrirTela(Form frm)
        {
            frm.ShowDialog();
        }

        private void criarPedidosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fornecedoresToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

            AbrirTela(new frmJanelaSplash());
            AbrirTela(new frmLogin());
        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTela(new FrmCategoria());
        }

        private void produtosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirTela(new frmProdutos());
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmClientes());
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmCargos());
        }

        private void funcionariosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmFuncionarios());
        }

        private void criarPedidosToolStripMenuItem_Click_1(object sender, EventArgs e)
        {

            AbrirTela(new FrmPedidos());
        }

        private void categoriasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmCategoriaRealatorios());
        }

        private void produtosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmProdutosRelatorios());
        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmClienteRelatorio());
        }

        private void cargosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmCargosRelatorios());
        }

        private void funcionariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {

            AbrirTela(new FrmFuncionariosRelatorios());
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
