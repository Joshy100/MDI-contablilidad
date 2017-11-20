using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Odbc;
using CrystalDecisions.ReportSource;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;



namespace CapaPresentación
{

    public partial class Reporte_de_Balance_General : Form
    {
        public string periodo;
        public string nivel;

        OdbcConnection cn = new OdbcConnection();
        OdbcConnection cn2 = new OdbcConnection();

        public Reporte_de_Balance_General()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //cn = Conexion.conex();
            cn = CapaDatos.conex();



            if ((periodo == null) && (nivel == null))
            {

                MessageBox.Show("Debe Seleccionar Periodo y Nivel");
            }
            else if (nivel == null)
            {
                MessageBox.Show("Debe Seleccionar un Nivel");

            }
            else if ((periodo == null))
            {

                MessageBox.Show("Debe Seleccionar Periodo");
            }
            else if ((nivel == "Nivel 1") && (periodo != null))
            {
                CapaLogica mr = new CapaLogica();
                mr.mostrar(cn2,"Balance_GeneralN1.rpt");
            }
            else if ((nivel == "Nivel 2") && (periodo != null)) {

                CapaLogica mr = new CapaLogica();
                mr.mostrarbg2("Balance_GeneralN2.rpt");
            }
            else if ((nivel == "Nivel 3") && (periodo != null))
            {
                CapaLogica mr = new CapaLogica();
                mr.mostrarbg3("Balance_GeneralN3.rpt");
            }
            else if ((nivel == "Nivel 4") && (periodo != null))
            {
                CapaLogica mr = new CapaLogica();
                mr.mostrarbg4("Balance_GeneralN4.rpt");
            }
            else if ((nivel == "Nivel 5") && (periodo != null))
            {
                CapaLogica mr = new CapaLogica();
                mr.mostrarbg5("BalanceGeneralN5.rpt");
            }

        }




        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = comboBox2.SelectedItem.ToString();
            nivel = textBox2.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bg1 = new Form1();
            bg1.Show();
        }

        private void Reporte_de_Balance_General_Load(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            periodo = textBox1.Text;

        }
    }
}
