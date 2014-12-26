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
    public partial class frmModalidadeCliente : Form
    {
        int cliente;

        public frmModalidadeCliente(int id_cliente)
        {
            cliente = id_cliente;
            InitializeComponent();
        }

        private void frmModalidadeCliente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'db_fitnessDataSet1.tb_modalidade' table. You can move, or remove it, as needed.
            this.tb_modalidadeTableAdapter.Fill(this.db_fitnessDataSet1.tb_modalidade);

            clsDB clsBanco = new clsDB();

            dataGridView1.DataSource = clsBanco.retornaBanco("select nom_modalidade as 'Modalidade Associada' from tb_modalidade m inner join tb_cliente_modalidade c on m.id_modalidade = c.id_modalidade where c.id_cliente = " + cliente);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            clsDB Banco = new clsDB();

            //MessageBox.Show(comboBox1.SelectedValue.ToString());

            if (Banco.Insert(string.Format("insert into tb_cliente_modalidade(id_cliente,id_modalidade) values({0},{1})", cliente, comboBox1.SelectedValue)))
            {
                dataGridView1.DataSource = Banco.retornaBanco("select nom_modalidade as 'Modalidade Associada' from tb_modalidade m inner join tb_cliente_modalidade c on m.id_modalidade = c.id_modalidade where c.id_cliente = " + cliente);
                MessageBox.Show("Modalidade associada com sucesso!");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            clsDB Banco = new clsDB();

            

            if (Banco.Insert(string.Format("delete from tb_cliente_modalidade where id_cliente = {0} and id_modalidade =  {1})", cliente, comboBox1.SelectedValue)))
            {
                dataGridView1.DataSource = Banco.retornaBanco("select nom_modalidade as 'Modalidade Associada' from tb_modalidade m inner join tb_cliente_modalidade c on m.id_modalidade = c.id_modalidade where c.id_cliente = " + cliente);
                MessageBox.Show("Modalidade removida com sucesso!");
            }
        }
    }
}
