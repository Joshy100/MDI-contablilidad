using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using System.Data;


namespace CapaPresentación
{
    public class CapaDatos
    {
        static OdbcConnection conector = null;
        OdbcCommand selector;

        public static OdbcConnection conex()
        {

            try
            {
                conector = new OdbcConnection("Driver ={ MySQL ODBC 5.3 Driver }; Dsn=hotel; UID=root; PWD=;");
                conector.Open();
               // MessageBox.Show("Conexion Exitosa");



            }
            catch (OdbcException e)
            {
                MessageBox.Show("Error al Conectar" + e);
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
                MessageBox.Show("Error al cargar la base de datos. " + ex);
            }
            /* finally
             {
                 conector.Close();
             }*/

        }

    }
}
