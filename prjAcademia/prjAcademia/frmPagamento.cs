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
    public partial class frmPagamento : Form
    {
        clsDB Banco = new clsDB();
        string id_cliente = "";

        public frmPagamento()
        {
            InitializeComponent();
        }

        private void frmPagamento_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.retornaBanco(string.Format("select id_cliente as 'COD',nom_cliente as 'Cliente',tel_cliente as 'Telefone' from tb_cliente"));

            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].Width = 350;
            dataGridView1.Columns[2].Width = 200;

            maskedTextBox1.Text = string.Format("{0}/{1}", DateTime.Now.Month, DateTime.Now.Year);
            
            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "" )
            {
                MessageBox.Show("Ambos os campos são obrigatórios!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if(id_cliente == "")
            {
                MessageBox.Show("Nenhum Cliente selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (Banco.retornaValores("select count(m.id_modalidade) from tb_modalidade m inner join tb_cliente_modalidade c on c.id_modalidade = m.id_modalidade where c.id_cliente = " + id_cliente) == "0")
            {
                MessageBox.Show("Cliente não possui nenhuma modalidade vinculada!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            string[] arrData = maskedTextBox1.Text.Split('/');

            //DataRow row = ((DataRowView)comboBox2.SelectedItem).Row;

            //MessageBox.Show(comboBox2.SelectedValue.ToString());

            if(Banco.Insert(string.Format("insert into tb_pagamento values({0},'{1}','{2}',current_timestamp)",id_cliente,arrData[0],arrData[1])))
            {
                MessageBox.Show("Pagamento Realizado Corretamente","Confirmação",MessageBoxButtons.OK,MessageBoxIcon.Information);

            }

            else
            {
                MessageBox.Show("Pagamento Realizado Incorretamente!","Atenção",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }



        }

        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = Banco.retornaBanco(string.Format("select id_cliente as 'COD',nom_cliente as 'Cliente',tel_cliente as 'Telefone' from tb_cliente where nom_cliente like '{0}%'", txtBusca.Text));
        }

        private void txtBusca_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button4.PerformClick();
            }
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int row = dataGridView1.CurrentRow.Index;
            if (row != -1)
            {
                id_cliente = dataGridView1[0, row].Value.ToString();

                DataTable dt_preco = Banco.retornaBanco("select sum(preco_modalidade) as total from tb_modalidade m inner join tb_cliente_modalidade c on c.id_modalidade = m.id_modalidade where c.id_cliente = " + id_cliente);


                dataGridView2.DataSource = Banco.retornaBanco("select nom_modalidade as Modalidade, resp_modalidade as Responsável, preco_modalidade as 'Preço' from tb_modalidade m inner join tb_cliente_modalidade c on c.id_modalidade = m.id_modalidade where c.id_cliente = " + id_cliente);
                lblResultado.Text = dt_preco.Rows[0]["total"].ToString();
            }*/
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int row = dataGridView1.CurrentRow.Index;
            if (row != -1)
            {
                id_cliente = dataGridView1[0, row].Value.ToString();

                DataTable dt_preco = Banco.retornaBanco("select sum(preco_modalidade) as total from tb_modalidade m inner join tb_cliente_modalidade c on c.id_modalidade = m.id_modalidade where c.id_cliente = " + id_cliente);


                dataGridView2.DataSource = Banco.retornaBanco("select nom_modalidade as Modalidade, resp_modalidade as Responsável, preco_modalidade as 'Preço' from tb_modalidade m inner join tb_cliente_modalidade c on c.id_modalidade = m.id_modalidade where c.id_cliente = " + id_cliente);
                lblResultado.Text = dt_preco.Rows[0]["total"].ToString();
            }
        }
    }
}
