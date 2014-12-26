using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace prjAcademia
{
    class clsModalidade
    {

        public void busca(object dataGrid,string str_busca)
        {
            clsDB banco = new clsDB();
            ((DataGridView)dataGrid).DataSource = banco.retornaBanco(string.Format("Select * from tb_modalidade where nom_modalidade like '{0}%'", str_busca));
        }

    }
}
