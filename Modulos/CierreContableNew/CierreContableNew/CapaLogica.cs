using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CierreContableNew
{
    class CapaLogica
    {
        CapaDatos cd = new CapaDatos();
        string l;
        public void llenar(DataTable t, string l)
        {
            CapaDatos.conex();
            cd.mostrar(t, l);
            CapaDatos.conex().Close();
        }

        public void llenar_txt(TextBox txt1,TextBox nom, string tabla, string campo)
        {
            CapaDatos.conex();
            cd.mostrar_txt(txt1, nom, tabla, campo);
            CapaDatos.conex().Close();
        }

        public void llenar_dgv(DataGridView grid, String sentencia, String tabla)
        {
            CapaDatos.conex();
            //MessageBox.Show(sentencia + " llenar grid");
            cd.mostrar_dgv(grid, sentencia, tabla);
            CapaDatos.conex().Close();
        }

        public void llenar_bd(string mes_consulta, string mes_historial)
        {
            CapaDatos.conex();
            cd.insertar(mes_consulta, mes_historial);
            CapaDatos.conex().Close();
        }

        public void llenar_actualizar(string mes_consulta)
        {
            CapaDatos.conex();
            cd.actualizar(mes_consulta);
            CapaDatos.conex().Close();
        }
    }
}
