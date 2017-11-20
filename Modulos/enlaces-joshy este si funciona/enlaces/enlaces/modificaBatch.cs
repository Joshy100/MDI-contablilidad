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

namespace enlaces
{
    public partial class modificaBatch : Form
    {
        public modificaBatch()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            poliza_batch batch = new poliza_batch();
            batch.Show();
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            poliza online = new poliza();
            online.Show();
            this.Close();
        }
    }
}
