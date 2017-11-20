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
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reporte_de_Balance_General  dd= new Reporte_de_Balance_General();
            dd.Show();
            this.Hide();     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reporte_de_Estado_de_Resultados er = new Reporte_de_Estado_de_Resultados();
            er.Show();
            this.Hide();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
