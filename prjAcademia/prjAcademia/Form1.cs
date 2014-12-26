using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjAcademia
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_fitnessDataSet1.tb_cliente' table. You can move, or remove it, as needed.
            this.tb_clienteTableAdapter1.Fill(this.db_fitnessDataSet1.tb_cliente);
            // TODO: This line of code loads data into the 'db_fitnessDataSet.tb_cliente' table. You can move, or remove it, as needed.

            Cursor.Current = Cursors.Default;
            
        }

        private static int ID_cliente;


        

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            #region Validação
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LightYellow;
                txtNome.Focus();
                return;
            }

            if (txtTel.Text == "")
            {
                MessageBox.Show("Telefone é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTel.BackColor = Color.LightYellow;
                txtTel.Focus();
                return;
            }
            #endregion

            clsCliente Cliente = new clsCliente();

            Cliente.Nom_cliente = txtNome.Text;
            Cliente.Rg_cliente = txtRg.Text;
            Cliente.Cpf_cliente = txtCPF.Text;
            Cliente.Tel_cliente = txtTel.Text;
            Cliente.Cel_cliente = txtCel.Text;
            Cliente.Datnasc_cliente = DateForm(txtDatnasc.Text);
            //Cliente.Datinc_cliente = DateForm(txtDataCad.Text);
            Cliente.Ativo_cliente = "S";
            Cliente.Obs_cliente = txtObs.Text;
            Cliente.Foto_cliente = picFoto.ImageLocation;

            if (cmbDiaVenc.SelectedIndex == 0)
                Cliente.Dia_venc = "10";
            else
                Cliente.Dia_venc = "20";

            if(Cliente.novoCliente())
            {
                MessageBox.Show(txtNome.Text + " cadastrado com sucesso!","Confirmação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                button4.PerformClick();

            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private string DateForm(string data)
        {
            if (data != "")
                return String.Format("{0}-{1}-{2}", data.Substring(4, 4), data.Substring(0, 2), data.Substring(2, 2));
            else
                return "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            clsCliente Cliente = new clsCliente();
            Cliente.Busca = txtBusca.Text;

            Cliente.busca(dataGridView1);


        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            if (row != -1)
            {

                clsCliente Cliente = new clsCliente();

                Cliente.carregaCliente(dataGridView1[0, row].Value.ToString());

                txtNome.Text = Cliente.Nom_cliente;
                txtRg.Text = Cliente.Rg_cliente;
                txtCPF.Text = Cliente.Cpf_cliente;
                txtTel.Text = Cliente.Tel_cliente;
                txtCel.Text = Cliente.Cel_cliente;
                txtDatnasc.Text = Cliente.Datnasc_cliente;
                //txtDataCad.Text = Cliente.Datinc_cliente;
                txtObs.Text = Cliente.Obs_cliente;

                ID_cliente = Cliente.Id_usuario;

                if (Cliente.Dia_venc == "10")
                {
                    cmbDiaVenc.SelectedIndex = 0;
                }
                else
                {
                    cmbDiaVenc.SelectedIndex = 1;
                }

                btnAlterar.Enabled = true;
                btnDesativar.Enabled = true;
                button2.Enabled = true;

            }
            else
                MessageBox.Show("Nenhum Item selecionado!");

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            #region Validação
            if (txtNome.Text == "")
            {
                MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtNome.BackColor = Color.LightYellow;
                txtNome.Focus();
                return;
            }

            if (txtTel.Text == "")
            {
                MessageBox.Show("Telefone é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txtTel.BackColor = Color.LightYellow;
                txtTel.Focus();
                return;
            }
            #endregion

            clsCliente Cliente = new clsCliente();

            Cliente.Nom_cliente = txtNome.Text;
            Cliente.Rg_cliente = txtRg.Text;
            Cliente.Cpf_cliente = txtCPF.Text;
            Cliente.Tel_cliente = txtTel.Text;
            Cliente.Cel_cliente = txtCel.Text;
            Cliente.Datnasc_cliente = DateForm(txtDatnasc.Text);
            //Cliente.Datinc_cliente = DateForm(txtDataCad.Text);
            Cliente.Ativo_cliente = "S";
            Cliente.Obs_cliente = txtObs.Text;
            Cliente.Foto_cliente = picFoto.ImageLocation;
            if (cmbDiaVenc.SelectedIndex == 0)
                Cliente.Dia_venc = "10";
            else
                Cliente.Dia_venc = "20";


            if (Cliente.atualizaCliente(ID_cliente.ToString()))
            {
                MessageBox.Show(txtNome.Text + " atualizado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button4.PerformClick();

            }
            else
            {
                MessageBox.Show("Erro ao atualizar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void Limpar()
        {
            clsCliente Cliente = new clsCliente();

            txtNome.Text = "";
            txtRg.Text = "";
            txtCPF.Text = "";
            txtTel.Text = "";
            txtCel.Text = "";
            txtDatnasc.Text = "";
            //txtDataCad.Text = "";
            txtObs.Text = "";

            ID_cliente = 0;
            btnAlterar.Enabled = false;
            button2.Enabled = false;
        }

        private void btnDesativar_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void tbclienteBindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmModalidadeCliente frm = new frmModalidadeCliente(ID_cliente);
            frm.ShowDialog();
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtBusca_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
