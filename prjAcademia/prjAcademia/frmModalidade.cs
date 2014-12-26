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
    public partial class frmModalidade : Form
    {
        clsDB Banco = new clsDB();
        int id_modalidade = 0;

        public frmModalidade()
        {
            InitializeComponent();
        }

        private void frmModalidade_Load(object sender, EventArgs e)
        {

            CarregaDataGrid();
            
        }

        private void CarregaDataGrid()
        {
            dataGridView1.DataSource = Banco.retornaBanco("Select id_modalidade as'Cod', nom_modalidade as 'Modalidade', resp_modalidade as 'Responsável', preco_modalidade as 'Preço' from tb_modalidade");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("Nome é obrigatório!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                textBox1.BackColor = Color.LightYellow;
                textBox1.Focus();
                return;
            }

            if(Banco.Insert(string.Format("insert into tb_modalidade(nom_modalidade,resp_modalidade,preco_modalidade) values('{0}','{1}',{2})",textBox1.Text,textBox2.Text,maskedTextBox1.Text.Replace(",","."))))
            {
                MessageBox.Show(textBox1.Text + " cadastrado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Limpar();
                CarregaDataGrid();
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (id_modalidade != 0)
            {
                if (Banco.Insert(string.Format("update tb_modalidade set nom_modalidade = '{0}', resp_modalidade = '{1}', preco_modalidade = {2} where id_modalidade = {3}", textBox1.Text, textBox2.Text, maskedTextBox1.Text.Replace(",","."),id_modalidade)))
                {
                    MessageBox.Show(textBox1.Text + " alterado com sucesso!", "Confirmação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Erro ao alterar!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                CarregaDataGrid();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Limpar();
        }

        private void Limpar()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            maskedTextBox1.Text = "";

            button2.Enabled = false;
            id_modalidade = 0;
            textBox1.Focus();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataTable dt;

            int row = dataGridView1.CurrentRow.Index;
            if (row != -1)
            {
                id_modalidade = Convert.ToInt32(dataGridView1[0, row].Value.ToString());


                dt = Banco.retornaBanco("select * from tb_modalidade where id_modalidade = " + id_modalidade);

                textBox1.Text = dt.Rows[0]["nom_modalidade"].ToString();
                textBox2.Text = dt.Rows[0]["resp_modalidade"].ToString();
                maskedTextBox1.Text = dt.Rows[0]["preco_modalidade"].ToString();

                button2.Enabled = true;

            }
        }
    }
}
