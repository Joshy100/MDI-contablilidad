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
    public partial class CapaPresetacionConsulta : Form
    {
        string mes;
        string mesconsulta;
        string anio;
        CapaLogica cl = new CapaLogica();
        public CapaPresetacionConsulta()
        {
            InitializeComponent();
        }

        private void CapaPresetacionConsulta_Load(object sender, EventArgs e)
        {
            
        }

        private void btn_consulta_Click(object sender, EventArgs e)
        {
            anio = txt_anio.Text.ToString();
            mes = cmb_mes_consulta.SelectedItem.ToString();
            if (mes == "ENERO")
            {
                mesconsulta = "01";    
            }
            else if (mes == "FEBRERO")
            {
                mesconsulta = "02";
            }
            else if (mes == "MARZO")
            {
                mesconsulta = "03";
            }
            else if (mes == "ABRIL")
            {
                mesconsulta = "04";
            }
            else if (mes == "MAYO")
            {
                mesconsulta = "05";
            }
            else if (mes == "JUNIO")
            {
                mesconsulta = "06";
            }
            else if (mes == "JULIO")
            {
                mesconsulta = "07";
            }
            else if (mes == "AGOSTO")
            {
                mesconsulta = "08";
            }
            else if (mes == "SEPTIEMBRE")
            {
                mesconsulta = "09";
            }
            else if (mes == "OCTUBRE")
            {
                mesconsulta = "10";
            }
            else if (mes == "NOVIEMBRE")
            {
                mesconsulta = "11";
            }
            else if (mes == "DICIEMBRE")
            {
                mesconsulta = "12";
            }
            string consulta = "SELECT cuentacontabilidad.nombre, historial.valor FROM cuentacontabilidad, historial WHERE month(historial.fechaCierre) = "+mesconsulta+" AND year(historial.fechaCierre) = "+anio+" AND cuentacontabilidad.nomenclatura = historial.cuentacontabilidad_nomenclatura";
            cl.llenar_dgv(dgv_consulta, consulta, "historial");
            //MessageBox.Show(consulta);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
