using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using capaPresentacion;
using CierreContableNew;
using CapaPresentación;
using enlaces;

namespace MDI_Contabilidad
{
    public partial class Contabilidad : Form
    {
        poliza p ;
        CapaPresentacion cc;
        opPoliza op;
        poliza_batch pb;
        busqueda b;
        Form1 ef;
                
        public Contabilidad()
        {
            InitializeComponent();
        }

        //polizas locales --- braulio y fernando
        private void polizasLocalesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (p == null)
            {
                p = new poliza();
                p.MdiParent = this;
                p.FormClosed += new FormClosedEventHandler(cpoliza_FormClosed);
                p.Show();
            }
            else {
                p.Activate();
            }*/
            string sentencia = "select count(estado) as total from partida where estado = 'batch';";
            //MessageBox.Show(sentencia);
            enlaces.CapaLogica cl = new enlaces.CapaLogica();
            cl.llama(sentencia);
        }

        void cpoliza_FormClosed(object sender, EventArgs e) {
            p = null;
        }
        // fin polizas locales 
        private void presupuestosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        
        //cierre contable --- marcos perez
        private void cierreContableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (cc == null)
            {
                cc = new CapaPresentacion();
                cc.MdiParent = this;
                cc.FormClosed += new FormClosedEventHandler(cierre_FormClosed);
                cc.Show();
            }
            else
            {
                cc.Activate();
            }
        }

        void cierre_FormClosed(object sender, EventArgs e)
        {
            cc = null;
        }
        //fin de cierre contable

        private void enlaceOtrosModulosToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        //enlace a otros modulos --- josue garrido

        private void opcionPolizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (op == null)
            {
                op = new opPoliza();
                op.MdiParent = this;
                op.FormClosed += new FormClosedEventHandler(opcionpoliza_FormClosed);
                op.Show();
            }
            else
            {
                op.Activate();
            }
        }

        void opcionpoliza_FormClosed(object sender, EventArgs e)
        {
            op = null;
        }

        private void polizaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pb == null)
            {
                pb = new poliza_batch();
                pb.MdiParent = this;
                pb.FormClosed += new FormClosedEventHandler(polizabatch_FormClosed);
                pb.Show();
            }
            else
            {
                pb.Activate();
            }
        }
        void polizabatch_FormClosed(object sender, EventArgs e)
        {
            pb = null;
        }

        private void verPolizasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*if (b == null)
            {
                b = new busqueda();
                b.MdiParent = this;
                b.FormClosed += new FormClosedEventHandler(busqueda_FormClosed);
                b.Show();
            }
            else
            {
                b.Activate();
            }*/
            string sentencia = "select count(estado) as total from partida where estado = 'batch';";
            //MessageBox.Show(sentencia);
            enlaces.CapaLogica cl = new enlaces.CapaLogica();
            cl.llama(sentencia);
        }
        void busqueda_FormClosed(object sender, EventArgs e)
        {
            b = null;
        }
        //fin de enlace a otros modulos

        //estados financieros --- oseas de leon
        private void estadosFinancierosToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ef = new Form1();
            ef.Show();           
        }

        

        private void activosFijosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        //fin de estados financieros
    }
}
