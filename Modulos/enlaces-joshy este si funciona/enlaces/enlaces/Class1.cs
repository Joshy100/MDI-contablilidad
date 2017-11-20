using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enlaces
{
    
    public class Class1
    {
       public static string estado;
        public static string Estado
        {
            get
            {
                return estado;
            }
            set
            {
                estado = value;
            }
        }   

        public static string devuelta1(int x)
        {
            return "online";
        }
        public static string devuelta2(int x)
        {
            return "batch";
        }
    }
}
