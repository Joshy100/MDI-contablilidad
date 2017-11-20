using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas2Nov
{
    public class CapaLogica
    {
        CapaDatos cd = new CapaDatos();
        //string l;
        //public void llenar(DataTable t, string l)
        //{
        //    CapaDatos.conex();
        //    cd.mostrar(t,l);
        //    CapaDatos.conex().Close();  
        //}

        public void llenar_dvg(DataGridView busqueda, String sentencia, String tabla)
        {
           CapaDatos.conex();
           cd.mostrar_dgv(busqueda, sentencia, tabla);
           CapaDatos.conex().Close();             
        }

        public void recibe_datos(ComboBox cmb, string tabla, string db) {
            CapaDatos.conex();
            cd.mostrar_cmb(cmb, tabla, db);
            CapaDatos.conex().Close();
        }
    }

}
