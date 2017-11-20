using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;
using System.Windows.Forms;
using capaPresentacion;

namespace enlaces
{
    class CapaDatos
    { 
    public static OdbcConnection conector = null;

    public static OdbcConnection conex()
    {
        try
        {
            conector = new OdbcConnection("Driver ={ MySQL ODBC 5.3 Driver }; Dsn=conectar; UID=root; PWD =;");
            conector.Open();
            //MessageBox.Show("SE ha conectado a la base de datos");
        }
        catch (OdbcException e)
        {
            MessageBox.Show("Nos se pudo conectar a la base de datos");
        }

        return conector;
    }
    int num;
    public void verificar(string sentencia)
    {
        OdbcCommand sentenciasql = new OdbcCommand(sentencia, conector);

        try
        {
            OdbcDataReader leer = sentenciasql.ExecuteReader();
            if (leer.Read() == true)
            {

                int total = Convert.ToInt32(leer["total"].ToString());
                if (total > 0)
                {
                    num = 1;
                        modificaBatch modificaBatch = new modificaBatch();
                        modificaBatch.Show();
                    //MessageBox.Show("Hay Polizas En Batch");
                }
                else
                {
                    num = 0;
                    poliza poliza = new poliza();
                    poliza.Show();
                    //MessageBox.Show("No Existen...");
                }
            }
            else
            {
                //MessageBox.Show("No Existen...");
            }
        }
        catch (OdbcException e)
        {
            MessageBox.Show("Error En La Sentencia");
        }
        finally
        {
            conex().Close();
        }
        //return num;
    }
}
}
