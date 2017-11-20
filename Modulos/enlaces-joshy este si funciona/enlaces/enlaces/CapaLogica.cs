using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace enlaces
{
    public class CapaLogica
    {
        CapaDatos cd = new CapaDatos();
        public void llama(string sentencia)
        {
            CapaDatos.conex();
            cd.verificar(sentencia);
            CapaDatos.conex().Close();
        }
    }
}
