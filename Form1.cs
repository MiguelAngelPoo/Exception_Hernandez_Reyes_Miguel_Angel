using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Execepcion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBoton1_Click(object sender, EventArgs e)
        {

          

         //Mensaje de advertencia de que no se han llenado los campos adecuados
            if (txtMatricula.Text == "")
            
                Ep.SetError(txtMatricula, "No ha ingresado matricula");


            if (txtNombre.Text == "")

                Ep.SetError(txtNombre, "No ha ingresado Nombre");
            
            if (txtSemestre.Text == "")

                Ep.SetError(txtSemestre, "No ha ingresado semestre");
           
            if (txtSemestre.Text == "")

                Ep.SetError(txtCarrera, "No ha ingresado Carrera");
            
            if (txtTelefono.Text == "")
                Ep.SetError(txtTelefono, "No ha ingresado telefono");

            if (txtCal.Text == "")
                Ep.SetError(txtCal, "No ha ingresado Calificacion");


            //try catch para mostrar al alumno en caso de que los datos que entren no sean adecuados
            try
            {
                Alumno Al = new Alumno();
                Al.Matricula = txtMatricula.Text;
                Al.Nombre = txtNombre.Text;
                Al.Semestre = Convert.ToInt32(txtSemestre.Text);
                Al.carrera = txtCarrera.Text;
                Al.Telefono = Convert.ToInt32(txtTelefono.Text);
                
                //confirmacion de que el usuario se ah creado
                throw new ExepcionEspecial("su alumno se creo exitosamente");

            }
            catch (FormatException ex)
            {

                //mensaje de error al ingresar un dato no adecuado 
                MessageBox.Show("Error en registrar alumno"+ ex.Message);
               
            }   

            catch(ExepcionEspecial espEx)
            {

                
                MessageBox.Show(espEx.Message);
            
            }
                
            

        }

        private void txtCal_Validating(object sender, CancelEventArgs e)
        {




            try
            {
                //condicion para verificar que el dato de la calificacion se encuentre entre los numero del 1 al 10
                int Cal = Convert.ToInt32(txtCal.Text);

                if (Cal < 1 || Cal > 10 )
                {
                    MessageBox.Show("Ingrese una calificacion del 1 al 10");
                }

            }
            catch (Exception ex)
            {
                //mensjae en caso de que registro tenga un error 
                MessageBox.Show("Erro en los campos","error",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
                
                
            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }



        //comentario de clase
        //prueba anterior de try catch
        /* try
         {
             int telefono = Convert.ToInt32(txtTelefono.Text);

             int Matricula = Convert.ToInt32(txtMatricula.Text);

             int Semestre = Convert.ToInt32(txtSemestre.Text);


             MessageBox.Show("Enviados");
         }

         catch (Exception eX)
         {   

             //El primero es un mensaje para el usuario

             MessageBox.Show("Valor incorrecto, Ingrese un nuevi valor");

             //El segundo es un mensaje pero para el desarollador

             MessageBox.Show(eX.ToString());
         }

             finally { txtTelefono.Focus(); };
             */
    }
}
