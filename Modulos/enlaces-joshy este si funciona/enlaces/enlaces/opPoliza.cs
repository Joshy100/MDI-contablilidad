using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace enlaces
{
    public partial class opPoliza : Form
    {
        public string hola;
        public opPoliza()
        {
            InitializeComponent();
            Class1 classe = new Class1();  
        }

        private void opPoliza_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true)
            {
                Class1 cl = new Class1();
                hola = enlaces.Class1.devuelta1(1);
                hola = enlaces.Class1.estado;
            }
            else
            {
                if (radioButton2.Checked == true)
                {
                    hola = enlaces.Class1.devuelta2(1);
                    Class1 cl = new Class1();
                    hola = enlaces.Class1.estado;
                }
            }
            Class1 classe = new Class1();
            //MessageBox.Show(hola);
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            hola = enlaces.Class1.devuelta1(1);
            Class1 cl = new Class1();
            enlaces.Class1.estado = hola;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            hola = enlaces.Class1.devuelta2(1);
            Class1 cl = new Class1();
            enlaces.Class1.estado = hola;
        }
    }
}
