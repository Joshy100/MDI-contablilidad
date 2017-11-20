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
    public partial class busqueda : Form
    {
        public busqueda()
        {
            InitializeComponent();
        }

        private void busqueda_Load(object sender, EventArgs e)
        {
            string sentencia = "select count(estado) as total from partida where estado = 'batch';";
            //MessageBox.Show(sentencia);
            CapaLogica cl = new CapaLogica();
            cl.llama(sentencia);
            this.Close();
        }
    }
}
