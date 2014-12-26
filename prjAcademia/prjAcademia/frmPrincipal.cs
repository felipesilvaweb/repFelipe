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
    public partial class frmPrincipal : Form
    {
        clsDB Banco = new clsDB();
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 frmCadCliente = new Form1();

            Cursor.Current = Cursors.WaitCursor;

            frmCadCliente.ShowDialog();
        }

        private void modalidadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmModalidade frmMod = new frmModalidade();

            Cursor.Current = Cursors.WaitCursor;
            frmMod.ShowDialog();



        }

        private void financeiroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPagamento frmPag = new frmPagamento();

            Cursor.Current = Cursors.WaitCursor;
            frmPag.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            label1.Text = string.Format("Pendências {0}/{1}",DateTime.Now.Month,DateTime.Now.Year);

            dataGridView1.DataSource = Banco.retornaBanco(string.Format("select nom_cliente as 'Cliente',tel_cliente as 'Contato' from tb_cliente where id_cliente not in (select id_cliente from tb_pagamento where mes_ref = '{0}' and ano_ref = '{1}') order by nom_cliente asc ",DateTime.Now.Month.ToString(),DateTime.Now.Year.ToString()));
            dataGridView1.Columns[0].Width = 200;
            dataGridView1.Columns[1].Width = 80;
        }
    }
}
