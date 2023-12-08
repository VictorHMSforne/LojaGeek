using LojaGeek.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LojaGeek
{
    public partial class FrmProdutos : Form
    {
        public FrmProdutos()
        {
            InitializeComponent();
        }

        public void CarregacbxTipo()
        {
            SqlConnection con = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"D:\\Programação\\Modulo 2\\Emerson\\LojaGeek\\LojaGeek\\DBgeek.mdf\";Integrated Security=True");
            string sql = "SELECT * FROM Tipo";
            SqlCommand cmd = new SqlCommand(sql, con);
            con.Open();
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            DataSet ds = new DataSet();
            da.Fill(ds, "Tipo");
            cbxTipo.ValueMember = "tipo";
            cbxTipo.DisplayMember = "tipo";
            cbxTipo.DataSource = ds.Tables["Tipo"];
            con.Close();
        }

        private void FrmProdutos_Load(object sender, EventArgs e)
        {
            CarregacbxTipo();
            Produto produto = new Produto();
            List<Produto> produtos = produto.listaprodutos();
            dgvProduto.DataSource = produtos;
            btnEditar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNome.Text == "" && txtPreco.Text == "" && txtQuantidade.Text == "")
                {
                    MessageBox.Show("Por favor, preencha todos os campos!", "Campos obrigatórios", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                else
                {
                    Produto produto = new Produto();
                    if (produto.RegistroRepetido(txtNome.Text, cbxTipo.Text) == true)
                    {
                        MessageBox.Show("Produto já existe em nossa base de dados!", "Repetido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtNome.Text = "";
                        txtPreco.Text = "";
                        txtQuantidade.Text = "";
                        cbxTipo.Text = "";
                        this.ActiveControl = txtNome;
                    }
                    else
                    {
                        int qtde = Convert.ToInt32(txtQuantidade.Text.Trim());
                        if (qtde == 0)
                        {
                            MessageBox.Show("A quantidade não pode ser igual a zero.", "Quantidade", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            this.ActiveControl = txtQuantidade;
                            return;
                        }
                        else
                        {
                            produto.Inserir(txtNome.Text, cbxTipo.Text, qtde, txtPreco.Text);
                            MessageBox.Show("Produto inserido com sucesso!", "Inserção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            txtNome.Text = "";
                            txtQuantidade.Text = "";
                            txtPreco.Text = "";
                            cbxTipo.Text = "";
                            this.ActiveControl = txtNome;
                            List<Produto> produtos = produto.listaprodutos();
                            dgvProduto.DataSource = produtos;
                        }
                    }
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Inserção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtID.Text.Trim());
                int qtde = Convert.ToInt32(txtQuantidade.Text);
                Produto produto = new Produto();
                produto.Atualizar(Id, txtNome.Text, cbxTipo.Text, qtde, txtPreco.Text);
                MessageBox.Show("Produto atualizado com sucesso!", "Edição", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaprodutos();
                dgvProduto.DataSource = produtos;
                txtID.Text = "";
                txtNome.Text = "";
                cbxTipo.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.ActiveControl = txtNome;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Edição", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                int Id = Convert.ToInt32(txtID.Text.Trim());
                Produto produto = new Produto();
                produto.Excluir(Id);
                MessageBox.Show("Produto excluído com sucesso!", "Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Information);
                List<Produto> produtos = produto.listaprodutos();
                dgvProduto.DataSource = produtos;
                txtID.Text = "";
                txtNome.Text = "";
                cbxTipo.Text = "";
                txtQuantidade.Text = "";
                txtPreco.Text = "";
                this.ActiveControl = txtNome;
                btnEditar.Enabled = false;
                btnExcluir.Enabled = false;
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Exclusão", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLocalizar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Trim() == "")
                {
                    MessageBox.Show("Por favor digite o ID para localizar o produto!", "Localizar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    Produto produto = new Produto();
                    int Id = Convert.ToInt32(txtID.Text.Trim());
                    produto.Localizar(Id);
                    txtNome.Text = produto.nome;
                    cbxTipo.Text = produto.tipo;
                    txtQuantidade.Text = Convert.ToString(produto.quantidade);
                    txtPreco.Text = Convert.ToString(produto.preco);
                    btnEditar.Enabled = true;
                    btnExcluir.Enabled = true;
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message, "Erro - Localização", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvProduto_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dgvProduto.Rows[e.RowIndex];
                this.dgvProduto.Rows[e.RowIndex].Selected = true;
                txtID.Text = row.Cells[0].Value.ToString();
                txtNome.Text = row.Cells[1].Value.ToString();
                cbxTipo.Text = row.Cells[2].Value.ToString();
                txtQuantidade.Text = row.Cells[3].Value.ToString();
                txtPreco.Text = row.Cells[4].Value.ToString();
            }
        }
    }
}
