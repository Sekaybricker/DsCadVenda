using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prjVendas
{
    public partial class s : Form
    {
        bool incluir, alterar;
        Util util = new Util();

        public s()
        {
            InitializeComponent();
        }
        
        private void frmCadProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_00981_14_A_1_2015DataSet.pc_produto' table. You can move, or remove it, as needed.
            this.pc_produtoTableAdapter.Fill(this.db_00981_14_A_1_2015DataSet.pc_produto);
            util.HabilitaBotoes(true, Controls);
            util.HabilitaCampos(false, Controls);
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar = true;
            incluir = false;
            util.HabilitaBotoes(false, Controls);
            util.HabilitaCampos(true, Controls);
            txtCodigo.Enabled = false;
            txtCodigo.Text = dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtdescricao.Text = dgvProdutos[1, dgvProdutos.CurrentRow.Index].Value.ToString();
            nudQuantidade.Text = dgvProdutos[2, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtPrecounit.Text = dgvProdutos[3, dgvProdutos.CurrentRow.Index].Value.ToString();
            txtdescricao.Focus();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvProdutos.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o produto selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_produtoTableAdapter.Delete(int.Parse(dgvProdutos[0, dgvProdutos.CurrentRow.Index].Value.ToString()));
                        frmCadProduto_Load(null, null);
                        MessageBox.Show(null, "Produto apagado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Primeiro selecione um produto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "ERRO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    util.HabilitaBotoes(true, Controls);
                    pc_produtoTableAdapter.Insert(txtdescricao.Text, int.Parse(nudQuantidade.Value.ToString()), double.Parse(txtPrecounit.Text));
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    util.LimparCampos(Controls);
                }
                else if (alterar)
                {
                    pc_produtoTableAdapter.Update(txtdescricao.Text, int.Parse(nudQuantidade.Value.ToString()), double.Parse(txtPrecounit.Text), int.Parse(txtCodigo.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    util.LimparCampos(Controls);
                }
                frmCadProduto_Load(null, null);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            incluir = false;
            alterar = false;
            util.HabilitaBotoes(true, Controls);
            util.HabilitaCampos(false, Controls);
            util.LimparCampos(Controls);
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            try
            {
                pc_produtoTableAdapter.FillByDescricao(db_00981_14_A_1_2015DataSet.pc_produto, "%" + txtPesquisar.Text + "%");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            util.HabilitaBotoes(false, Controls);
            util.HabilitaCampos(true, Controls);
            util.LimparCampos(Controls);
            incluir = true;
            alterar = false;
            txtCodigo.Enabled = false;
            txtdescricao.Focus();
        }
    }
}
