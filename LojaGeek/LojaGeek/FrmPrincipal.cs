using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGeek
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            FrmSplash splash = new FrmSplash();
            splash.Show();
            Application.DoEvents();
            Thread.Sleep(3000);
            splash.Close();
        }

        private void pbxProduto_Click(object sender, EventArgs e)
        {
            FrmProdutos produtos = new FrmProdutos();
            produtos.Show();
        }

        private void pbxCliente_Click(object sender, EventArgs e)
        {
            FrmCliente cliente = new FrmCliente();
            cliente.Show();
        }

        private void pbxVendas_Click(object sender, EventArgs e)
        {
            FrmVendas vendas = new FrmVendas();
            vendas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var a = MessageBox.Show("Deseja Sair?","Sair",MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if(a == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FrmTipoProduto tpProduto = new FrmTipoProduto();    
            tpProduto.Show();
        }
    }
}
