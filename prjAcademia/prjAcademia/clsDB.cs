using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace prjAcademia
{
    class clsDB
    {
       

        private string geraConnectionString(){
             //string connString = ConfigurationManager.ConnectionStrings["ConnString"].ConnectionString;
            string connString = "SERVER=localhost;DATABASE=db_fitness;UID=root;PWD=square";
             return connString;

        }

        public MySqlConnection Connect()
        {
            
            using(MySqlConnection conn = new MySqlConnection(geraConnectionString()))
            {
                
                return conn;
            }

            
            
        }

        public bool Insert(string sql)
        {
            MySqlConnection conn = Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql,conn);

            try
            {
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(Exception ex)
            {

                conn.Close();
                return false;
            }

        }

        public DataTable retornaBanco(string sql)
        {
            DataTable dt = new DataTable();
            

            MySqlConnection conn = Connect();
            conn.Open();

            try
            {
                MySqlCommand cmd = new MySqlCommand(sql, conn);
            

                MySqlDataAdapter da = new MySqlDataAdapter(cmd);

                da.Fill(dt);
           
                return dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
        }

        public string retornaValores(string sql)
        {
            DataTable dt = new DataTable();


            MySqlConnection conn = Connect();
            conn.Open();

            MySqlCommand cmd = new MySqlCommand(sql, conn);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);

            da.Fill(dt);



            return dt.Rows[0][0].ToString();

        }

    }
}
