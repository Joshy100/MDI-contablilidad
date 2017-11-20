using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas2Nov
{
    public class CapaDatos
    {
        static OdbcConnection conector = null;
        OdbcCommand selector;
        public static OdbcConnection conex()
        {
            try
            {
                conector = new OdbcConnection("Driver ={ MySQL ODBC 5.3 Driver }; Dsn=pruebahs; UID=root; PWD = ;");
                conector.Open();
            }
            catch (OdbcException e)
            {

            }
            return conector;
        }
        public void mostrar(DataTable tabla, String operar)
        {
            try
            {
                selector = new OdbcCommand();
                selector.Connection = conector;
                selector.CommandText = operar;
                OdbcDataAdapter adaptar = new OdbcDataAdapter(selector);
                adaptar.Fill(tabla);
            }
            catch (OdbcException ex)
            {
                MessageBox.Show("No se puede conectar a la base de datos");
            }
        }
        public void mostrar_dgv(DataGridView sentencia, String consulta, String tabla)
        {
            try
            {
                selector = new OdbcCommand();
                selector.Connection = conector;
                selector.CommandText = consulta;
                DataSet ds = new DataSet();
                OdbcDataAdapter dg = new OdbcDataAdapter(selector);
                dg.Fill(ds, tabla);
                sentencia.DataSource = ds;
                sentencia.DataMember = tabla;
            }
            catch(OdbcException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos dg");
            }
        }

        OdbcDataReader odr;
        public void mostrar_cmb(ComboBox cmb1, string tabla, string bd) {
            selector = new OdbcCommand("SELECT COLUMN_NAME AS Campos FROM information_schema.COLUMNS WHERE TABLE_SCHEMA = '" + bd +"' AND TABLE_NAME = '" + tabla + "'", conector);
            odr = selector.ExecuteReader();
            while (odr.Read())
            {
                cmb1.Items.Add(odr["Campos"].ToString());
            }
            odr.Close();
        }
    }
}
