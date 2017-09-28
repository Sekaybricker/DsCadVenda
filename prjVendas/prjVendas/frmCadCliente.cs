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
    public partial class frmCadCliente : Form
    {
        bool incluir = false;
        bool alterar = false;
        Util util = new Util();
        public frmCadCliente()
        {
            InitializeComponent();
        }

        private void frmCadCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'vendasDataSet.pc_clientes' table. You can move, or remove it, as needed.
            this.pc_clientesTableAdapter.Fill(this.vendasDataSet.pc_clientes);

        }

        private void btnIncluir_Click(object sender, EventArgs e)
        {
            util.HabilitaBotoes(false, Controls);
            util.HabilitaCampos(true, Controls);
            util.LimparCampos(Controls);
            incluir = true;
            alterar = false;
            txtCodigo.Enabled = false;
            txtNome.Focus();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            alterar = true;
            incluir = false;
            util.HabilitaBotoes(false, Controls);
            util.HabilitaCampos(true, Controls);
            txtCodigo.Enabled = false;
            txtCodigo.Text = dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString();
            txtNome.Text = dgvClientes[1, dgvClientes.CurrentRow.Index].Value.ToString();
            txtEndereco.Text = dgvClientes[2, dgvClientes.CurrentRow.Index].Value.ToString();
            txtCidade.Text = dgvClientes[3, dgvClientes.CurrentRow.Index].Value.ToString();
            txtBairro.Text = dgvClientes[4, dgvClientes.CurrentRow.Index].Value.ToString();
            mskCep.Text = dgvClientes[6, dgvClientes.CurrentRow.Index].Value.ToString();
            mskEstado.Text = dgvClientes[5, dgvClientes.CurrentRow.Index].Value.ToString();
            mskTelefone.Text = dgvClientes[7, dgvClientes.CurrentRow.Index].Value.ToString();
            dtpDatanasc.Value = DateTime.Parse(dgvClientes[8, dgvClientes.CurrentRow.Index].Value.ToString());
            txtNome.Focus();
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            try
            {
                if (incluir)
                {
                    util.HabilitaBotoes(true, Controls);
                    pc_clientesTableAdapter.Insert(txtNome.Text, txtEndereco.Text, txtCidade.Text,
                        txtBairro.Text, mskEstado.Text, mskCep.Text, mskTelefone.Text, dtpDatanasc.Value);
                    MessageBox.Show("Incluído com sucesso!", "Incluir", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    util.LimparCampos(Controls);
                }
                else if (alterar)
                {
                    pc_clientesTableAdapter.Update(txtNome.Text, txtEndereco.Text, txtCidade.Text,
                        txtBairro.Text, mskEstado.Text, mskCep.Text, mskTelefone.Text, dtpDatanasc.Value, int.Parse(txtCodigo.Text));
                    MessageBox.Show("Alterado com sucesso!", "Alterar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    util.LimparCampos(Controls);
                }
                frmCadCliente_Load(null, null);
            }
            catch (FormatException)
            {
                MessageBox.Show("Digite ");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocorreu um erro\n" + ex.Message, "Erro:", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    if (MessageBox.Show(null, "Deseja mesmo excluir o cliente selecionado?", "Atenção", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                    {
                        pc_clientesTableAdapter.Delete(int.Parse(dgvClientes[0, dgvClientes.CurrentRow.Index].Value.ToString()));
                        frmCadCliente_Load(null, null);
                        MessageBox.Show(null, "Cliente apagado com sucesso!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Primeiro selecione um cliente", "Aviso", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

                }
            }   
            catch(Exception ex)
            {
                MessageBox.Show("Erro:" + ex.Message, "ERRO", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation);
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
           
           
        }

        private void btnPesquisar_Click_1(object sender, EventArgs e)
        {
            pc_clientesTableAdapter.FillByNome(this.vendasDataSet.pc_clientes, "%" + txtPesquisar.Text + "%");
        }
    }
}
