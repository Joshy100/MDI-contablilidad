using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentación
{
    public partial class Reporte_de_Estado_de_Resultados : Form
    {
        string periodo;

        public Reporte_de_Estado_de_Resultados()
        {
            InitializeComponent();
        }

        private void Reporte_de_Estado_de_Resultados_Load(object sender, EventArgs e)
        {
            this.Hide();
            //Form1 bg1 = new Form1();
            //bg1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
          
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form1 bg1 = new Form1();
            bg1.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (periodo == null)
            {

                MessageBox.Show("Debe Seleccionar un Periodo");
            }

            else
            {
                CapaLogica mr = new CapaLogica();
                mr.mostrarestador("EstadoResultados.rpt");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox1.Text = comboBox1.SelectedItem.ToString();
            periodo = textBox1.Text;
        }
    }
}
