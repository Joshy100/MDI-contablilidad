using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Consultas2Nov
{
    public partial class CapaPresentacion : Form
    {
        public String tabla; // string parametro nombre tabla enviada por navegador
        public String database; //string parametro del nombre de la bd por traido del navegador

        string campost = "";
        string condicion = "";
        string consulta = "";
        
        int campos_ingresados = 0;        
        int condiciones_ingresadas = 0;         
        
        CapaLogica cl = new CapaLogica();
             
        
        public CapaPresentacion(String table1, String database1)
        {
            InitializeComponent();

            //reciben parametros de navegador
            this.tabla = table1;
            this.database = database1;

            //inicializa componentes con información de la base de datos
            cl.recibe_datos(Cmb_campos, tabla, database);
            cl.recibe_datos(Cmb_campos2, tabla, database);

            //inicializa componentes
            btn_nc.Enabled = false;
            Txt_campo1.Enabled = false;
            Txt_condicion1.Enabled = false;
            Txt_operador.Enabled = false;
            btn_add.Enabled = false;
            Cmb_campos2.Enabled = false;
            Cmb_operadorcondiciones.Enabled = false;
            Cmb_campos.Enabled = false;
            Txt_condicion.Enabled = false;
            btn_adCondicion.Enabled = false;
            Btn_crear.Enabled = false;                    
            
        }
        
        private void CapaPresentacion_Load(object sender, EventArgs e)
        {
        }



        /*
         Este boton lo que hace es agregar los campos que se quieran ver en la consulta
             */
        private void button1_Click(object sender, EventArgs e)
        {
            string campo = Txt_campo1.Text;            

            if (campo == "")
            {
                MessageBox.Show("No se ha elegido un campo");
                Cmb_campos.Items.Clear();
                cl.recibe_datos(Cmb_campos, tabla, database);
            }
            else
            {             
                //si no se ha ingresado un campo
                if (campos_ingresados == 0)
                {
                    campost = campo;                    
                }
                //si ya se han ingresado mas de un campo
                else if (campos_ingresados >= 1)
                {
                    campost = " , " + campo;                    
                    Txt_campo1.Text = "";
                }                
            }
            campos_ingresados++;
            
            //Limpiado de componentes
            Cmb_campos.Items.Remove(Cmb_campos.SelectedItem);
            Cmb_campos.Text = "";
            Txt_campo1.Clear();
        }       

        private void Btn_creacond_Click(object sender, EventArgs e)
        {
            //aqui se forma ya la estructura final de la consulta dependiendo de cada una de las condiciones

            //si se ingresaron campos y si ingresaron condicion 
            if (campost != "" && condicion != "")
            {
                consulta = "SELECT " + campost + " FROM " + tabla + " WHERE " + condicion;
                MessageBox.Show("Consulta creada exitosamente");
                this.Hide();
            }
            // si ingresaron campos pero no ingresaron condiciones
            else if (campost != "" && condicion == "")
            {
                consulta = "SELECT " + campost + "FROM" + tabla;
                MessageBox.Show("Consulta creada exitosamente");
                this.Hide();
            }
            // si no ingrearon campos pero si se ingresaron condiciones
            else if (campost == "" && condicion != "")
            {
                consulta = "SELECT  * FROM " + tabla + " WHERE " + condicion;
                MessageBox.Show("Consulta creada exitosamente");
                this.Hide();
            }
            //si no hay ni campos ni condiciones se crea un select general de todos los datos de la tabla
            else if (campost == "" && condicion == "")
            {
                MessageBox.Show("No se ha creado la consulta");
            }           

           //
           //CREAR LA FUNCION PARA MANDAR LOS PARAMETROS AL FORMULARIO 
           //EJ: 
           //                   
            
           //Limpiado de componentes y variables
            btn_nc.Enabled = true;
            Btn_crear.Enabled = false;
            consulta = "";            
            btn_add.Enabled = false;
            Cmb_campos.Enabled = false;
            Cmb_campos2.Enabled = false;
            Cmb_operadorcondiciones.Enabled = false;
            Txt_condicion.Enabled = false;
            btn_adCondicion.Enabled = false;
            Txt_campo1.Enabled = false;            
        }

        private void Cmb_campos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtiene el dato del combobox donde estan los campos de la tabla y lo muestra en un textbox
            string dato = Cmb_campos.SelectedItem.ToString();
            Txt_campo1.Text = dato.ToString();               
                     
        }

        private void Cmb_operadorcondiciones_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtiene los operadores del combobox y los muestra en un textbox
            Txt_operador.Text = Cmb_operadorcondiciones.SelectedItem.ToString();
            Txt_condicion.Focus();
        }

        private void Txt_condicion_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cmb_campos2_SelectedIndexChanged(object sender, EventArgs e)
        {
            //obtiene los datos del combobox y los muestra en un textbox
            Txt_condicion1.Text = Cmb_campos2.SelectedItem.ToString();
        }

        private void CapaPresentacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }

        private void btn_nc_Click(object sender, EventArgs e)
        {          

            //inicializa nuevamente la información de la base de datos
            cl.recibe_datos(Cmb_campos, tabla, database);
            cl.recibe_datos(Cmb_campos2, tabla, database);

            //limpia las demas variables y reincia componentes
            campost = "";
            condicion = "";
            consulta = "";
            campos_ingresados = 0;
            condiciones_ingresadas = 0;
            Btn_ccompleta.Enabled = true;
            Btn_cpersonalizada.Enabled = true;
            Cmb_campos.Items.Clear();
            Cmb_campos2.Items.Clear();
            Cmb_campos.Enabled = false;
            Txt_campo1.Enabled = false;
            Cmb_campos2.Enabled = false;
            Cmb_operadorcondiciones.Enabled = false;
            btn_add.Enabled = false;
            btn_adCondicion.Enabled = false;
            Btn_crear.Enabled = false;
            Txt_condicion.Enabled = false;            
            //dgv.Rows.Clear();
            btn_nc.Enabled = false;
            Cmb_campos.Text = "";
            Txt_campo1.Clear();
            Cmb_campos2.Text = "";
            Cmb_operadorcondiciones.Text = "";
            Txt_condicion1.Clear();
            Txt_condicion.Clear();            
            Txt_operador.Clear();
        }      

        private void btn_adCondicion_Click(object sender, EventArgs e)
        {
            //agrega las condiciones que se desea el usuario

            string condicion1 = Txt_condicion1.Text.ToString();
            string operador = Txt_operador.Text.ToString();
            string condicion2 = Txt_condicion.Text.ToString();

            Regex er = new Regex("^[0-9]+$");

            if ((condicion1 == "" && operador == "" && condicion2 == "")
               || (condicion1 == "" && operador == "")
               || (condicion1 == "" && condicion2 == "")
               || (operador == "" && condicion2 == "")
               || (condicion1 == "")
               || (operador == "")
               || (condicion2 == ""))
            {
                MessageBox.Show("No debe haber campos vacios al crear una condicion");
                Cmb_campos2.Items.Clear();               
                cl.recibe_datos(Cmb_campos2, tabla, database);
            }
            else
            {
                if (condiciones_ingresadas == 0)
                {
                    if (operador == "MAYOR QUE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " > " + condicion2;
                        }
                        else {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }                            
                    }
                    else if (operador == "MENOR QUE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " < " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }
                    else if (operador == "IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " = " + condicion2;
                        }
                        else if (!er.IsMatch(condicion2)) { }
                        {
                            condicion = condicion1 + " = " + "'" + condicion2 + "'";
                        }
                    }
                    else if (operador == "MAYOR O IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " >= " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }
                    else if (operador == "MENOR O IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " <= " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }
                    else if (operador == "DIFERENTE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion1 + " <> " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }

                }
                else if(condiciones_ingresadas >= 1)
                {
                    if (operador == "MAYOR QUE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " > " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }                        
                    }
                    else if (operador == "MENOR QUE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " < " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }                        
                    }
                    else if (operador == "IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " = " + condicion2;
                        }
                        else if (!er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " = " + "'" + condicion2 + "'";
                        }                        
                    }
                    else if (operador == "MAYOR O IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " >= " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }
                    else if (operador == "MENOR O IGUAL")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " <= " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }
                    else if (operador == "DIFERENTE")
                    {
                        if (er.IsMatch(condicion2))
                        {
                            condicion = condicion + " AND " + condicion1 + " <> " + condicion2;
                        }
                        else
                        {
                            MessageBox.Show("No se puede comparar con un numero");
                            Cmb_campos2.Items.Clear();
                            cl.recibe_datos(Cmb_campos2, tabla, database);
                        }
                    }                    
                }
            }
            condiciones_ingresadas++;

            //limpia componentes
            Txt_operador.Text = "";
            Txt_condicion1.Text = "";
            Txt_condicion.Text = "";
            Cmb_campos2.Items.Remove(Cmb_campos2.SelectedItem);           
            Cmb_campos2.Text = "";
            Cmb_operadorcondiciones.Text = "";            
        }

        private void Btn_ccompleta_Click(object sender, EventArgs e)
        {
            consulta = "SELECT * FROM " + tabla;
            //envia consulta creada 
            consulta = "";
            btn_nc.Enabled = false;
            Btn_ccompleta.Enabled = true;
            Btn_cpersonalizada.Enabled = true;            
        }

        private void Btn_cpersonalizada_Click(object sender, EventArgs e)
        {
            Cmb_campos.Enabled = true;
            Txt_campo1.Enabled = true;
            btn_add.Enabled = true;
            Cmb_campos2.Enabled = true;
            Cmb_operadorcondiciones.Enabled = true;
            Txt_condicion.Enabled = true;
            btn_adCondicion.Enabled = true;
            Btn_crear.Enabled = true;
            btn_nc.Enabled = true;
        }
    }
}
