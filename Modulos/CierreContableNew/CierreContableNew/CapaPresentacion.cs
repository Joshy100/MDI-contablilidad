using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CierreContableNew
{
    public partial class CapaPresentacion : Form
    {
        int id_mes = 1;
        int idmes_contador = 1;
        string mes;
        string mes_consulta;
        string mes_historial;
        CapaLogica cl = new CapaLogica();
        public CapaPresentacion()
        {
            InitializeComponent();

        }

        private void CapaPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_cierre_Click(object sender, EventArgs e)
        {
            mes = cmb_mes.SelectedItem.ToString();
            //MessageBox.Show(mes);
            if (mes == "ENERO")
            {
                id_mes = 1;
                if (idmes_contador == id_mes)
                {
                    mes_consulta = "01";
                    mes_historial = "2017-01-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 2;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
                             
            }
            else if (mes == "FEBRERO")
            {
                id_mes = 2;
                if (idmes_contador == id_mes)
                {
                    mes_consulta = "02";
                    mes_historial = "2017-02-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 3;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }

            }
            else if (mes == "MARZO")
            {
                id_mes = 3;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "03";
                    mes_historial = "2017-03-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 4;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "ABRIL")
            {
                id_mes = 4;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "04";
                    mes_historial = "2017-04-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 5;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }

            }
            else if (mes == "MAYO")
            {
                id_mes = 5;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "05";
                    mes_historial = "2017-05-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 6;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "JUNIO")
            {
                id_mes = 6;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "06";
                    mes_historial = "2017-06-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 7;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "JULIO")
            {
                id_mes = 7;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "07";
                    mes_historial = "2017-07-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 8;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }

            }
            else if (mes == "AGOSTO")
            {
                id_mes = 8;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "08";
                    mes_historial = "2017-08-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 9;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "SEPTIEMBRE")
            {
                id_mes = 9;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "09";
                    mes_historial = "2017-09-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 10;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "OCTUBRE")
            {
                id_mes = 10;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "10";
                    mes_historial = "2017-10-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 11;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }
            }
            else if (mes == "NOVIEMBRE")
            {
                id_mes = 11;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "11";
                    mes_historial = "2017-11-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 12;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                }

            }
            else if (mes == "DICIEMBRE")
            {
                id_mes = 12;
                if(idmes_contador == id_mes)
                {
                    mes_consulta = "12";
                    mes_historial = "2017-12-01";
                    cl.llenar_bd(mes_consulta, mes_historial);
                    cl.llenar_actualizar(mes_consulta);
                    MessageBox.Show("Se Cerraron las cuentas");
                    idmes_contador = 1;
                }
                else
                {
                    MessageBox.Show("El cierre debe hacerse en orden");
                    id_mes = idmes_contador;
                } 
            }
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            CapaPresetacionConsulta cps = new CapaPresetacionConsulta();
            cps.Show();
        }
    }
}
