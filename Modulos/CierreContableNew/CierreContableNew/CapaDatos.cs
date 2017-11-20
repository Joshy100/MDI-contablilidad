using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CierreContableNew
{
    class CapaDatos
    {
        static OdbcConnection conector = null;
        OdbcCommand selector;
        //OdbcDataReader odr;
        public static OdbcConnection conex()
        {
            try
            {
                conector = new OdbcConnection("Driver ={ MySQL ODBC 3.51 Driver }; DSN=pruebahotel; UID=root; PWD = ;");
                conector.Open();
            }
            catch (OdbcException e)
            {

            }
            return conector;
        }
        public void mostrar(DataTable tabla, String operar)
        {
            MessageBox.Show(operar);
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
        //OdbcDataReader odr;
        public void mostrar_txt(TextBox txt1, TextBox nom, string tabla, string campo)
        {
            string sentencia = "SELECT saldo AS saldo, nomenclatura AS nomen FROM " + tabla + " WHERE nombre = '" + campo + "'";
            //MessageBox.Show(sentencia);
            OdbcCommand selectortxt = new OdbcCommand(sentencia,conector);
            //conex().Open();
            OdbcDataReader odr = selectortxt.ExecuteReader();
            if (odr.Read() == true)
            {
                txt1.Text = odr["saldo"].ToString();
                nom.Text = odr["nomen"].ToString();
            }
            conex().Close();
        }

        public void mostrar_dgv(DataGridView grid, String consulta, String tabla)
        {
            try
            {
                //MessageBox.Show(consulta + " mostrar grid");
                selector = new OdbcCommand();
                selector.Connection = conector;
                selector.CommandText = consulta;
                DataSet ds = new DataSet();
                OdbcDataAdapter dg = new OdbcDataAdapter(selector);
                dg.Fill(ds, tabla);
                grid.DataSource = ds;
                grid.DataMember = tabla;
            }
            catch(OdbcException e)
            {
                MessageBox.Show("No se puede conectar a la base de datos dg");
            }
        }

        public void insertar(string mes_consulta, string mes_historial)
        {
            int id = 1;
            int retorno = 0;
            DateTime fechahoy = DateTime.Now;
            string fecha = fechahoy.ToString("d");
            //MessageBox.Show(fecha);
            string sent = "INSERT INTO historial (fecha,valor,fechaCierre,cuentacontabilidad_nomenclatura) SELECT '"+ fecha +"', cuentacontabilidad.saldo, '"+ mes_historial +"', cuentacontabilidad.nomenclatura FROM cuentacontabilidad, detallepartida, partida WHERE month(partida.fecha) = "+ mes_consulta +" AND detallepartida.partida_idPartida = partida.idPartida AND cuentacontabilidad.nomenclatura = detallepartida.cuentacontabilidad_nomenclatura";
            //MessageBox.Show(sent);
            OdbcCommand insert = new OdbcCommand(sent,conector);
            retorno = insert.ExecuteNonQuery();
            id++;
        }

        public void actualizar(string mes_consulta)
        {
            int retorno = 0;
            string sent = "UPDATE cuentacontabilidad SET cargoAcumulado = cargoAcumulado + cargoMes, cargoMes = 0, abonoAcumulado = abonoAcumulado + abonoMes, abonoMes = 0, saldoAnterior = saldoActual, saldoActual = 0 WHERE nomenclatura IN (SELECT detallepartida.cuentacontabilidad_nomenclatura FROM detallepartida, partida WHERE month(partida.fecha) = "+mes_consulta+ " AND detallepartida.partida_idPartida = partida.idPartida)";
            //MessageBox.Show(sent);
            OdbcCommand insert = new OdbcCommand(sent, conector);
            retorno = insert.ExecuteNonQuery();
        }

    }
}
