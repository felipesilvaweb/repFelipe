using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjAcademia
{
    class clsCliente
    {
        private int id_usuario;
        private string nom_cliente;
        private string rg_cliente;
        private string cpf_cliente;
        private string tel_cliente;
        private string cel_cliente;
        private string datnasc_cliente;
        private string datinc_cliente;
        private string ativo_cliente;
        private string foto_cliente;
        private string obs_cliente;
        private string dia_venc;

        private string str_busca;

        public string Dia_venc
        {
            get { return dia_venc; }
            set { dia_venc = value; }
        }

        public int Id_usuario
        {
            get
            {
                return id_usuario;
            }
        }
        public string Nom_cliente
        {
            get
            {
                return nom_cliente;
            }
            set
            {
                nom_cliente = value; 
            }
        }
        public string Rg_cliente
        {
            get
            {
                return rg_cliente;
            }

            set
            {
                rg_cliente = value;
            }
        }
        public string Cpf_cliente
        {
            get { return cpf_cliente;}
            set { cpf_cliente = value; }
        }
        public string Tel_cliente
        {
            get { return tel_cliente; }
            set { tel_cliente = value; }
        }
        public string Cel_cliente
        {
            get { return cel_cliente; }
            set { cel_cliente = value; }
        }
        public string Datnasc_cliente
        {
            get { return datnasc_cliente; }
            set { datnasc_cliente = value; }
        }
        public string Datinc_cliente
        {
            get { return datinc_cliente; }
            set { datinc_cliente = value; }
        }
        public string Ativo_cliente
        {
            get { return ativo_cliente; }
            set { ativo_cliente = value; }
        }
        public string Foto_cliente
        {
            get { return foto_cliente; }
            set { foto_cliente = value; }
        }
        public string Obs_cliente
        {
            get { return obs_cliente; }
            set { obs_cliente = value; }
        }

        public string Busca
        {
            set { str_busca = value; }
            get{return str_busca;}
        }

        public bool novoCliente()
        {
            clsDB db = new clsDB();
            StringBuilder sqlCampos = new StringBuilder("Insert into tb_cliente(nom_cliente");

            #region-Preenchimento dos campos do insert


            if (rg_cliente != "")
                sqlCampos.Append(",rg_cliente");

            if (cpf_cliente != "")
                sqlCampos.Append(",cpf_cliente");

            if (tel_cliente != "")
                sqlCampos.Append(",tel_cliente");

            if (cel_cliente != "")
                sqlCampos.Append(",cel_cliente");

            if (datnasc_cliente != "")
                sqlCampos.Append(",datnasc_cliente");
            if (dia_venc != "")
                sqlCampos.Append(",dia_venc");

            
            sqlCampos.Append(",datinc_cliente");


            if (ativo_cliente != "")
                sqlCampos.Append(",ativo_cliente");

            if (foto_cliente != null)
                sqlCampos.Append(",foto_cliente");

            if (obs_cliente != "")
                sqlCampos.Append(",obs_cliente");


            sqlCampos.Append(")");

            #endregion

            StringBuilder sqlValores = new StringBuilder(String.Format(" values('{0}' ",nom_cliente));

            #region Preenchimento dos valores do insert

            if (rg_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", rg_cliente));

            if (cpf_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", cpf_cliente));

            if (tel_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", tel_cliente));

            if (cel_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", cel_cliente));

            if (datnasc_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", datnasc_cliente));

            sqlValores.Append(String.Format(",now()"));

            if (ativo_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", ativo_cliente));

            if (foto_cliente != null)
                sqlValores.Append(String.Format(",'{0}'", foto_cliente));

            if (obs_cliente != "")
                sqlValores.Append(String.Format(",'{0}'", obs_cliente));
            if (dia_venc != "")
                sqlValores.Append(String.Format(",{0}", dia_venc));

            sqlValores.Append(")");
            #endregion
            
            sqlCampos.Append(sqlValores.ToString());

            return db.Insert(sqlCampos.ToString());

        }

        public bool atualizaCliente(string id)
        {
            clsDB db = new clsDB();
            StringBuilder sqlCampos = new StringBuilder("update tb_cliente set nom_cliente = '" + nom_cliente + "'");

          

            
            if (rg_cliente != "")
                sqlCampos.Append(string.Format(" , rg_cliente = '{0}'", rg_cliente));

            if (cpf_cliente != "")
                sqlCampos.Append(string.Format(" , cpf_cliente = '{0}'", cpf_cliente));

            if (tel_cliente != "")
                sqlCampos.Append(string.Format(" , tel_cliente = '{0}'", tel_cliente));

            if (cel_cliente != "")
                sqlCampos.Append(string.Format(" , cel_cliente = '{0}'", cel_cliente));

            if (datnasc_cliente != "")
                sqlCampos.Append(string.Format(" , datnasc_cliente = '{0}'", datnasc_cliente));

            if (ativo_cliente != "")
                sqlCampos.Append(string.Format(" , ativo_cliente = '{0}'", ativo_cliente));

            if (foto_cliente != null)
                sqlCampos.Append(string.Format(" , foto_cliente = '{0}'", foto_cliente));

            if (obs_cliente != "")
                sqlCampos.Append(string.Format(" , obs_cliente = '{0}'", obs_cliente));

            if (dia_venc != "")
                sqlCampos.Append(string.Format(" , dia_venc = {0}", dia_venc));


            sqlCampos.Append(" where id_cliente = " + id);

            return db.Insert(sqlCampos.ToString());


        }

        public void busca(object dataGrid)
        {
            clsDB banco = new clsDB();
            ((DataGridView)dataGrid).DataSource = banco.retornaBanco(string.Format("Select * from tb_cliente where nom_cliente like '{0}%'",str_busca));
        }

        public void carregaCliente(string id)
        {
            clsDB banco = new clsDB();
            DataTable dt = banco.retornaBanco("select * from tb_cliente where id_cliente = " + id);

            id_usuario = Convert.ToInt32(dt.Rows[0]["id_cliente"].ToString());
            nom_cliente = dt.Rows[0]["nom_cliente"].ToString();
            rg_cliente= dt.Rows[0]["rg_cliente"].ToString();
            cpf_cliente=dt.Rows[0]["cpf_cliente"].ToString();
            tel_cliente=dt.Rows[0]["tel_cliente"].ToString();
            cel_cliente=dt.Rows[0]["cel_cliente"].ToString();
            datnasc_cliente=dt.Rows[0]["datnasc_cliente"].ToString();
            datinc_cliente=dt.Rows[0]["datinc_cliente"].ToString();
            ativo_cliente=dt.Rows[0]["ativo_cliente"].ToString();
            foto_cliente=dt.Rows[0]["foto_cliente"].ToString();
            obs_cliente = dt.Rows[0]["obs_cliente"].ToString();
            dia_venc = dt.Rows[0]["dia_venc"].ToString();

           
        }


    }
}
