using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class Form1 : Form
    {
        
        Controlador co = new Controlador();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            
        }

        private void buttonCrearSocio_Click(object sender, EventArgs e)
        {
            //activacion de opciones para mostrar en crear socio(COLOCAR REPLEGABLE)

            //limpiar textbox
            textBoxNombreSocio.Text = "";
            textBoxApellidoSocio.Text = "";
            textBoxIdentificacionSocio.Text = "";
            textBoxCantidad.Text = "";
            textBoxEdicion1.Text = "";
            textBoxEdicion2.Text = "";
            textBoxEdicion3.Text = "";
            textBoxUbicacion1.Text = "";
            textBoxUbicacion2.Text = "";
            textBoxUbicacion3.Text = "";

            //button crear socio
            textBoxNombreSocio.Visible = true;
            textBoxApellidoSocio.Visible = true;
            textBoxIdentificacionSocio.Visible = true;
            labelNombreSocio.Visible = true;
            labelApellidoSocio.Visible = true;
            labelIdentificacionSocio.Visible = true;
            checkBoxSocioComun.Visible = true;
            checkBoxSocioVIP.Visible = true;
            buttonAgregarSocio.Visible = true;
            labelMensajeSocioCreado.Visible = false;
            checkBoxSocioComun.Checked = false;
            checkBoxSocioVIP.Checked = false;
            labelApellidoSocio.Text = "Apellido:";
            labelIdentificacionSocio.Text = "Identificacion:";
            labelMensajeError.Text = "Coloca correctamente los valores en los espacios de texto y selecione algun tipo de socio";

            //button CrearLibro
            labelCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;
            buttonAgregarLibro.Visible = false;
            buttonAgregarEjemplar.Visible = false;
            labelMensajeError.Visible = false;

            //button crear ejemplar
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;

            textBoxEdicion1.Visible = false;
            textBoxUbicacion1.Visible = false;
            textBoxEdicion2.Visible = false;
            textBoxUbicacion2.Visible = false;
            textBoxEdicion3.Visible = false;
            textBoxUbicacion3.Visible = false;

            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = false;
            buttonBuscarLibro.Visible = false;
            buttonAgregarPrestamo.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button consulta
            buttonConsultorCupo.Visible = false;
            label1.Visible = false;
            buttonConsultarEjemplar.Visible = false;

        }

        private void buttonAgregarSocio_Click(object sender, EventArgs e)
        {
            string nombre="";
            string apellido="";
            int idetificacion=0;
            labelMensajeError.Visible = false;
            //Errores en creacion
            //- me deja crear socios con numeros en vez de nombres
            //- si no seleciono socio igual me coloca todo false en lo visible
            try {
                if (textBoxNombreSocio.Text=="" || textBoxApellidoSocio.Text== ""|| !checkBoxSocioVIP.Checked && !checkBoxSocioComun.Checked) {
                    
                    labelMensajeError.Visible = true;

                }
                else
                {
                    nombre = textBoxNombreSocio.Text;
                    apellido = textBoxApellidoSocio.Text;
                }
                
                idetificacion = int.Parse(textBoxIdentificacionSocio.Text);

                
                
            }
            catch
            {
                //mostrar mesaje de error
               
                labelMensajeError.Visible = true;

                
            }

            //logica
            if (!labelMensajeError.Visible) {

                if (checkBoxSocioVIP.Checked)
                {
                    co.CrearSocioVIP(nombre, apellido, idetificacion);
                    labelMensajeSocioCreado.Visible = true;


                }
                if (checkBoxSocioComun.Checked)
                {
                    co.CrearSocioComun(nombre, apellido, idetificacion);
                    labelMensajeSocioCreado.Visible = true;
                }

                //ocultar opciones una vez se le de click a crear socio y no tenga error
                textBoxNombreSocio.Visible = false;
                textBoxApellidoSocio.Visible = false;
                textBoxIdentificacionSocio.Visible = false;
                labelNombreSocio.Visible = false;
                labelApellidoSocio.Visible = false;
                labelIdentificacionSocio.Visible = false;
                checkBoxSocioComun.Visible = false;
                checkBoxSocioVIP.Visible = false;
                buttonAgregarSocio.Visible = false;
            }
           

            

        }

        private void checkBoxSocioComun_CheckedChanged(object sender, EventArgs e)
        {
            //corregir error de cuando esta chekeado 
            checkBoxSocioVIP.Visible = !checkBoxSocioComun.Checked;
        
            
        }

        private void checkBoxSocioVIP_CheckedChanged(object sender, EventArgs e)
        {
            //corregir error de cuando esta chekeado
            checkBoxSocioComun.Visible = !checkBoxSocioVIP.Checked ;
        }

        private void buttonCrearLibro_Click(object sender, EventArgs e)
        {
            //limpiar textbox
            textBoxNombreSocio.Text = "";
            textBoxApellidoSocio.Text = "";
            textBoxIdentificacionSocio.Text = "";
            textBoxCantidad.Text = "";
            textBoxEdicion1.Text = "";
            textBoxEdicion2.Text = "";
            textBoxEdicion3.Text = "";
            textBoxUbicacion1.Text = "";
            textBoxUbicacion2.Text = "";
            textBoxUbicacion3.Text = "";

            //button crear socio
            textBoxNombreSocio.Visible = true;
            textBoxApellidoSocio.Visible = true;
            textBoxIdentificacionSocio.Visible = true;
            labelNombreSocio.Visible = true;
            labelApellidoSocio.Visible = true;
            labelIdentificacionSocio.Visible = true;
            checkBoxSocioComun.Visible = false;
            checkBoxSocioVIP.Visible = false;
            buttonAgregarSocio.Visible = false;
            labelMensajeSocioCreado.Visible = false;
            labelMensajeError.Visible = false;

            //button crear libro
            labelApellidoSocio.Text = "Autor:";
            labelIdentificacionSocio.Text = "Codigo:";
            labelCantidad.Visible = true;
            textBoxCantidad.Visible = true;
            buttonAgregarEjemplar.Visible = true;
            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = false;
            buttonBuscarLibro.Visible = false;
            buttonAgregarPrestamo.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button consulta
            buttonConsultorCupo.Visible = false;
            label1.Visible = false;
            buttonConsultarEjemplar.Visible = false;

        }

        private void buttonAgregarEjemplar_Click(object sender, EventArgs e)
        {

            try
            {
                if (int.Parse(textBoxCantidad.Text) <= 3 && int.Parse(textBoxCantidad.Text) > 0)
                {
                    //se inicializan de nuevo en falso
                    labelEjemplar1.Visible = false;
                    labelEdicion1.Visible = false;
                    labelUbicacio1.Visible = false;
                    labelEjemplar2.Visible = false;
                    labelEdicion2.Visible = false;
                    labelUbicacion2.Visible = false;
                    labelEjemplar3.Visible = false;
                    labelEdicion3.Visible = false;
                    labelUbicacion3.Visible = false;

                    textBoxEdicion1.Visible = false;
                    textBoxUbicacion1.Visible = false;
                    textBoxEdicion2.Visible = false;
                    textBoxUbicacion2.Visible = false;
                    textBoxEdicion3.Visible = false;
                    textBoxUbicacion3.Visible = false;
                    labelMensajeError.Visible = false;

                    switch (int.Parse(textBoxCantidad.Text))
                    {
                        case 1:
                            labelEjemplar1.Visible = true;
                            labelEdicion1.Visible = true;
                            labelUbicacio1.Visible = true;
                            textBoxEdicion1.Visible = true;
                            textBoxUbicacion1.Visible = true;
                            break;

                        case 2:
                            labelEjemplar1.Visible = true;
                            labelEdicion1.Visible = true;
                            labelUbicacio1.Visible = true;
                            labelEjemplar2.Visible = true;
                            labelEdicion2.Visible = true;
                            labelUbicacion2.Visible = true;

                            textBoxEdicion1.Visible = true;
                            textBoxUbicacion1.Visible = true;
                            textBoxEdicion2.Visible = true;
                            textBoxUbicacion2.Visible = true;

                            break;

                        case 3:
                            labelEjemplar1.Visible = true;
                            labelEdicion1.Visible = true;
                            labelUbicacio1.Visible = true;
                            labelEjemplar2.Visible = true;
                            labelEdicion2.Visible = true;
                            labelUbicacion2.Visible = true;
                            labelEjemplar3.Visible = true;
                            labelEdicion3.Visible = true;
                            labelUbicacion3.Visible = true;

                            textBoxEdicion1.Visible = true;
                            textBoxUbicacion1.Visible = true;
                            textBoxEdicion2.Visible = true;
                            textBoxUbicacion2.Visible = true;
                            textBoxEdicion3.Visible = true;
                            textBoxUbicacion3.Visible = true;

                            break;
                    }
                    buttonAgregarLibro.Visible = true;
                }
                else
                {
                    labelMensajeError.Text = "Coloca una cantidad correcta , recuerda debe ser un numero del 1 al 3";
                    labelMensajeError.Visible = true;
                }


                //mostrar botones y el de crear tambien
            }
            catch
            {
                labelMensajeError.Visible = true;
            }
        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            //error cuando creo menos de 3 explota porque esto mandando un valor vacio
            //puedo usar la condicional de cantidad para asignar valores en metodos sobrecargados o un metodo que reciba estos valores opcionalmente

            int cantidad = int.Parse(textBoxCantidad.Text);
            int numeroEdicion1 = 0;
            int numeroEdicion2 = 0;
            int numeroEdicion3 = 0;
            int codigo = 0;
            string ubic1 = "";
            string ubic2 = "";
            string ubic3 = "";
            string nombre = "";
            string autor = "";
            labelMensajeError.Visible = false;
            labelMensajeError.Text = "";
            
            

            
            try {
                codigo = int.Parse(textBoxIdentificacionSocio.Text);
                if (textBoxNombreSocio.Text == "" || textBoxApellidoSocio.Text=="") {
                    labelMensajeError.Text += "Ingresa correctamente los valores de nombre o autor  " + "\n";
                    labelMensajeError.Visible = true;
                }
                else
                {
                    nombre = textBoxNombreSocio.Text;
                    autor = textBoxApellidoSocio.Text;
                }
                
      
            }
            catch{

                labelMensajeError.Text += "Ingresa correctamente los valores de nombre,autor y codigo " + "\n";
                labelMensajeError.Visible = true;

            }
            try
            {
                numeroEdicion1 = int.Parse(textBoxEdicion1.Text);
                ubic1 = textBoxUbicacion1.Text;

            }
            catch
            {
                labelMensajeError.Text = "Ingresa correctamente los valores de el espacio 1 " + "\n";
                labelMensajeError.Visible = true;

            }

            try
            {
                numeroEdicion2 = int.Parse(textBoxEdicion2.Text);
                ubic2 = textBoxUbicacion2.Text;

            }
            catch
            {
                if (cantidad > 1)
                {
                    labelMensajeError.Text += "Ingresa correctamente los valores de el espacio 2 " + "\n";
                    labelMensajeError.Visible = true;
                }

            }

            try
            {
                numeroEdicion3 = int.Parse(textBoxEdicion3.Text);
                ubic3 = textBoxUbicacion3.Text;

            }
            catch
            {
                if (cantidad > 2)
                {
                    labelMensajeError.Text += "Ingresa correctamente los valores de el espacio 3 " + "\n";
                    labelMensajeError.Visible = true;
                }

            }

            //me esta creando libro asi no tenga todos los datos

            if (!labelMensajeError.Visible)
            {
                co.CrearLibro(
                    cantidad,
                    nombre,
                    autor,
                    codigo,
                    numeroEdicion1, numeroEdicion2, numeroEdicion3,
                    ubic1, ubic2, ubic3
                    );
            }


            if (!labelMensajeError.Visible) {


                

                //variables de cierre

                textBoxNombreSocio.Visible = false;
                textBoxApellidoSocio.Visible = false;
                textBoxIdentificacionSocio.Visible = false;
                labelNombreSocio.Visible = false;
                labelApellidoSocio.Visible = false;
                labelIdentificacionSocio.Visible = false;

                labelCantidad.Visible = false;
                textBoxCantidad.Visible = false;
                buttonAgregarEjemplar.Visible = false;


                labelEjemplar1.Visible = false;
                labelEdicion1.Visible = false;
                labelUbicacio1.Visible = false;
                labelEjemplar2.Visible = false;
                labelEdicion2.Visible = false;
                labelUbicacion2.Visible = false;
                labelEjemplar3.Visible = false;
                labelEdicion3.Visible = false;
                labelUbicacion3.Visible = false;
                label1.Visible = false;

                textBoxEdicion1.Visible = false;
                textBoxUbicacion1.Visible = false;
                textBoxEdicion2.Visible = false;
                textBoxUbicacion2.Visible = false;
                textBoxEdicion3.Visible = false;
                textBoxUbicacion3.Visible = false;

                buttonAgregarLibro.Visible = false;
                labelMjsLibroCreado.Visible = true;
                labelMjsLibroCreado.Text = "El libro ha sido creado correctamente.." ;


            }
            
            
        }

        private void buttonPrestarEjemplar_Click(object sender, EventArgs e)
        {
            //limpiar textbox
            textBoxNombreSocio.Text = "";
            textBoxApellidoSocio.Text = "";
            textBoxIdentificacionSocio.Text = "";
            textBoxCantidad.Text = "";
            textBoxEdicion1.Text = "";
            textBoxEdicion2.Text = "";
            textBoxEdicion3.Text = "";
            textBoxUbicacion1.Text = "";
            textBoxUbicacion2.Text = "";
            textBoxUbicacion3.Text = "";

            //button crear socio
            textBoxNombreSocio.Visible = true;
            textBoxApellidoSocio.Visible = false;
            textBoxIdentificacionSocio.Visible = false;
            labelNombreSocio.Visible = true;
            labelApellidoSocio.Visible = false;
            labelIdentificacionSocio.Visible = false;
            checkBoxSocioComun.Visible = false;
            checkBoxSocioVIP.Visible = false;
            buttonAgregarSocio.Visible = false;
            labelMensajeSocioCreado.Visible = false;
            labelMensajeError.Visible = false;

            //button crear libro
            labelNombreSocio.Text = "Nombre del socio:";
            labelApellidoSocio.Text = "Nombre del libro:";
            labelCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            buttonAgregarEjemplar.Visible = false;
            labelMjsLibroCreado.Visible = false;
            buttonAgregarLibro.Visible = false;

            //button crear ejemplar
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;

            textBoxEdicion1.Visible = false;
            textBoxUbicacion1.Visible = false;
            textBoxEdicion2.Visible = false;
            textBoxUbicacion2.Visible = false;
            textBoxEdicion3.Visible = false;
            textBoxUbicacion3.Visible = false;

            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = true;
            

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button consulta
            buttonConsultorCupo.Visible = false;
            label1.Visible = false;
            buttonConsultarEjemplar.Visible = false;
        }

        private void buttonBuscarSocio_Click(object sender, EventArgs e)
        {
            try {

                
                string target = textBoxNombreSocio.Text;

                
                    if (co.BuscarSocio(target))
                    {
                        labelApellidoSocio.Visible = true;
                        textBoxApellidoSocio.Text = "";
                        textBoxApellidoSocio.Visible = true;
                        buttonBuscarLibro.Visible = true;
                        labelMensajeError.Visible = false;
                    }
                    else
                    {
                        labelMensajeError.Text = "Socio no encontrado ";
                        labelApellidoSocio.Visible = false;
                        textBoxApellidoSocio.Visible = false;
                        labelMensajeError.Visible = true;
                    }
               

            }
            catch {
                labelMensajeError.Text = "Socio no encontrado o campo vacio";
                labelMensajeError.Visible = true;
               

            }
        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            //por alguna razon no me encuentra correctamente el libro, cantidad  0
            try
            {

                string target = textBoxApellidoSocio.Text;

                string cantidad = co.BuscarLibro(target);

               


                    if (cantidad != "libro no encontrado")
                    {
                        buttonAgregarPrestamo.Visible = true;
                        labelMensajeDeCantidad.Text = "Cantidad disponible: "+ cantidad;
                        labelMensajeError.Visible = false;
                    }
                    else
                    {  
                        labelMensajeError.Visible = true;
                    }   

            }
            catch
            {
                labelMensajeError.Text = "libro no encontrado o campo vacio";
                labelMensajeError.Visible = true;
                


            }
        }

        private void buttonAgregarPrestamo_Click(object sender, EventArgs e)
        {
            string socio = textBoxNombreSocio.Text;
            string libro = textBoxApellidoSocio.Text;

     
            if (co.AgregarPrestamo(socio, libro))
            {
                labelMensajeError.Visible = false;
            }
            else
            {
                labelMensajeError.Text = "No se ha encontrado socio o libro";
                labelMensajeError.Visible = true;
            }
            
            if (!labelMensajeError.Visible)
            {

                //variables de cierre

                textBoxNombreSocio.Visible = false;
                textBoxApellidoSocio.Visible = false;
                textBoxIdentificacionSocio.Visible = false;
                labelNombreSocio.Visible = false;
                labelApellidoSocio.Visible = false;
                labelIdentificacionSocio.Visible = false;

                labelCantidad.Visible = false;
                textBoxCantidad.Visible = false;
                buttonAgregarEjemplar.Visible = false;


                labelEjemplar1.Visible = false;
                labelEdicion1.Visible = false;
                labelUbicacio1.Visible = false;
                labelEjemplar2.Visible = false;
                labelEdicion2.Visible = false;
                labelUbicacion2.Visible = false;
                labelEjemplar3.Visible = false;
                labelEdicion3.Visible = false;
                labelUbicacion3.Visible = false;

                textBoxEdicion1.Visible = false;
                textBoxUbicacion1.Visible = false;
                textBoxEdicion2.Visible = false;
                textBoxUbicacion2.Visible = false;
                textBoxEdicion3.Visible = false;
                textBoxUbicacion3.Visible = false;

                buttonAgregarLibro.Visible = false;
                labelMensajeDeCantidad.Text = "Prestamo Realizado";

                buttonBuscarSocio.Visible = false;
                buttonBuscarLibro.Visible = false;
                buttonAgregarPrestamo.Visible = false;


            }
        }

        private void buttonDevolver_Click(object sender, EventArgs e)
        {
            //limpiar textbox
            textBoxNombreSocio.Text = "";
            textBoxApellidoSocio.Text = "";
            textBoxIdentificacionSocio.Text = "";
            textBoxCantidad.Text = "";
            textBoxEdicion1.Text = "";
            textBoxEdicion2.Text = "";
            textBoxEdicion3.Text = "";
            textBoxUbicacion1.Text = "";
            textBoxUbicacion2.Text = "";
            textBoxUbicacion3.Text = "";

            //button crear socio
            textBoxNombreSocio.Visible = true;
            textBoxApellidoSocio.Visible = false;
            textBoxIdentificacionSocio.Visible = false;
            labelNombreSocio.Visible = true;
            labelApellidoSocio.Visible = false;
            labelIdentificacionSocio.Visible = false;
            checkBoxSocioComun.Visible = false;
            checkBoxSocioVIP.Visible = false;
            buttonAgregarSocio.Visible = false;
            labelMensajeSocioCreado.Visible = false;
            labelMensajeError.Visible = false;

            //button crear libro
            labelNombreSocio.Text = "Nombre del socio:";
            labelCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            buttonAgregarEjemplar.Visible = false;
            labelMjsLibroCreado.Visible = false;
            buttonAgregarLibro.Visible = false;

            //button crear ejemplar
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;

            textBoxEdicion1.Visible = false;
            textBoxUbicacion1.Visible = false;
            textBoxEdicion2.Visible = false;
            textBoxUbicacion2.Visible = false;
            textBoxEdicion3.Visible = false;
            textBoxUbicacion3.Visible = false;
            

            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = false;
            buttonBuscarLibro.Visible = false;
            buttonAgregarPrestamo.Visible = false;

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = true;
            labelMensajeDeCantidad.Text = "";

            //button consulta
            buttonConsultorCupo.Visible = false;
            label1.Visible = false;
            buttonConsultarEjemplar.Visible = false;
        }

        private void buttonHistorial_Click(object sender, EventArgs e)
        {

            label1.Text = co.MostrarHistorialDePrestamos();
            label1.Visible = true;

            //button crear socio
            textBoxNombreSocio.Visible = false;
            textBoxApellidoSocio.Visible = false;
            textBoxIdentificacionSocio.Visible = false;
            labelNombreSocio.Visible = false;
            labelApellidoSocio.Visible = false;
            labelIdentificacionSocio.Visible = false;
            checkBoxSocioComun.Visible = false;
            checkBoxSocioVIP.Visible = false;
            buttonAgregarSocio.Visible = false;
            labelMensajeSocioCreado.Visible = false;
            labelMensajeError.Visible = false;

            //button crear libro
            labelNombreSocio.Text = "Nombre del socio:";
            labelApellidoSocio.Text = "Nombre del libro:";
            labelCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            buttonAgregarEjemplar.Visible = false;
            labelMjsLibroCreado.Visible = false;
            buttonAgregarLibro.Visible = false;

            //button crear ejemplar
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;

            textBoxEdicion1.Visible = false;
            textBoxUbicacion1.Visible = false;
            textBoxEdicion2.Visible = false;
            textBoxUbicacion2.Visible = false;
            textBoxEdicion3.Visible = false;
            textBoxUbicacion3.Visible = false;


            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = false;
            buttonBuscarLibro.Visible = false;

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button consulta

            buttonConsultorCupo.Visible = false;
            buttonConsultarEjemplar.Visible = false;
        }

        private void buttonConsulta_Click(object sender, EventArgs e)
        {
            //limpiar textbox
            textBoxNombreSocio.Text = "";
            textBoxApellidoSocio.Text = "";
            textBoxIdentificacionSocio.Text = "";
            textBoxCantidad.Text = "";
            textBoxEdicion1.Text = "";
            textBoxEdicion2.Text = "";
            textBoxEdicion3.Text = "";
            textBoxUbicacion1.Text = "";
            textBoxUbicacion2.Text = "";
            textBoxUbicacion3.Text = "";

            //buttons de uso
            labelNombreSocio.Text = "Ingresa el nombre del socio para realizar la consulta";
            labelNombreSocio.Visible = true;
            textBoxNombreSocio.Text = "";
            textBoxNombreSocio.Visible = true;
            buttonConsultorCupo.Visible = true;

            //button crear socio
            textBoxApellidoSocio.Visible = true;
            textBoxIdentificacionSocio.Visible = false;  
            labelApellidoSocio.Visible = true;
            labelIdentificacionSocio.Visible = false;
            checkBoxSocioComun.Visible = false;
            checkBoxSocioVIP.Visible = false;
            buttonAgregarSocio.Visible = false;
            labelMensajeSocioCreado.Visible = false;
            labelMensajeError.Visible = false;

            //button crear libro
            labelNombreSocio.Text = "Nombre del socio:";
            labelApellidoSocio.Text = "Nombre del libro:";
            labelCantidad.Visible = false;
            textBoxCantidad.Visible = false;
            buttonAgregarEjemplar.Visible = false;
            labelMjsLibroCreado.Visible = false;
            buttonAgregarLibro.Visible = false;

            //button crear ejemplar
            labelEjemplar1.Visible = false;
            labelEdicion1.Visible = false;
            labelUbicacio1.Visible = false;
            labelEjemplar2.Visible = false;
            labelEdicion2.Visible = false;
            labelUbicacion2.Visible = false;
            labelEjemplar3.Visible = false;
            labelEdicion3.Visible = false;
            labelUbicacion3.Visible = false;

            textBoxEdicion1.Visible = false;
            textBoxUbicacion1.Visible = false;
            textBoxEdicion2.Visible = false;
            textBoxUbicacion2.Visible = false;
            textBoxEdicion3.Visible = false;
            textBoxUbicacion3.Visible = false;


            labelMjsLibroCreado.Visible = false;

            //button prestar libro
            buttonBuscarSocio.Visible = false;
            buttonBuscarLibro.Visible = false;
            buttonAgregarPrestamo.Visible = false;

            //button devolver libro
            dataGridView1.Visible = false;
            buttonMostrarlistaEjemplares.Visible = false;
            labelMensajeDeCantidad.Text = "";

            //button consulta
            buttonConsultorCupo.Visible = true;
            label1.Visible = false;
            buttonConsultarEjemplar.Visible = true;


        }

        private void buttonConsultorCupo_Click(object sender, EventArgs e)
        {
            string target = textBoxNombreSocio.Text;

            labelMjsLibroCreado.Text = "";
            labelMjsLibroCreado.Visible = true;

            if (co.MostrarCupoDelSocio(target)!= "")
            {
                labelMjsLibroCreado.Text = co.MostrarCupoDelSocio(target);

            }
            else
            {
                labelMensajeError.Text = "Socio no encontrado o campo vacio";
                labelMensajeError.Visible = true;
            }
            


        }
        private void buttonConsultarEjemplar_Click(object sender, EventArgs e)
        {
            labelMensajeError.Text = "El nombre del libro no existe...";
            try
            {

                string target = textBoxApellidoSocio.Text;

                string cantidad = co.BuscarLibro(target);


                if (cantidad != "libro no encontrado")
                {
                    labelMensajeDeCantidad.Text = "Cantidad de ejempares disponibles: " + cantidad;
                    labelMensajeError.Visible = false;
                }
                else
                {
                    labelMensajeError.Visible = true;
                }

            }
            catch
            {

                labelMensajeError.Visible = true;



            }
        }

        private void buttonMostrarlistaEjemplares_Click(object sender, EventArgs e)
        {
            labelMensajeError.Visible = false;
            try {
               
                if(textBoxNombreSocio.Text == "")
                {
                    labelMensajeError.Text = "Socio no encontrado o campo vacio";
                    labelMensajeError.Visible= true;
                }
                else
                {
                    labelMensajeError.Visible = false;
                }


            } catch
            {
                labelMensajeError.Text = "Socio no encontrado o campo vacio";
                labelMensajeError.Visible = false;
            }

            if (!labelMensajeError.Visible)
            {
                
                if (co.BuscarSocio(textBoxNombreSocio.Text))
                {

                    //revisar si se puede delegar a controlador
                    foreach (Socio so in Biblioteca.ListaSocios)
                    {
                        if (so.Nombre == textBoxNombreSocio.Text)
                        {
                            if(so.EjemplaresRetirados.Count > 0) {

                                dataGridView1.Visible = true;
                                dataGridView1.Rows.Clear();

                                foreach (Ejemplar ej in so.EjemplaresRetirados)
                                {

                                    //creo columna
                                    int n = dataGridView1.Rows.Add();

                                    //colocamos info
                                    foreach (Libro li in Biblioteca.ListaLibros)
                                    {
                                        if (li.Codigo == ej.CodigoLibro)
                                        {
                                            dataGridView1.Rows[n].Cells[0].Value = li.Nombre;
                                        }

                                    }
                                    dataGridView1.Rows[n].Cells[1].Value = ej.NumEdicion;
                                    dataGridView1.Rows[n].Cells[2].Value = ej.Ubicacion;
                                }
                            }
                            else
                            {
                                dataGridView1.Visible = false;
                                labelMensajeError.Text = "El socio no ha retirado aún libros de la biblioteca o ya devolvio todos";
                                labelMensajeError.Visible = true;
                            }
                           
                        }

                    }

                }
                else
                {
                    dataGridView1.Visible = false;
                    labelMensajeError.Text = "El socio no ha sido encontrado";
                    labelMensajeError.Visible = true;
                }
            }
            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //limpiar el texto una vez termine la accion del boton
            if (e.ColumnIndex == 3)
            {
                int rowIndex = e.RowIndex;
                string nombre = textBoxNombreSocio.Text;

                if (co.DevolverEjemplar(rowIndex, nombre)) {

                    MessageBox.Show("Haz devuelto el ejemplar " + dataGridView1.Rows[e.RowIndex].Cells[0].Value);
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
                else
                {
                    MessageBox.Show("La casilla que seleccionaste no continene info ");
                    dataGridView1.Rows.Clear();
                    dataGridView1.Visible = false;
                }
                
            }
        }

        

        #region Validacion de textos 

        //validacion de textos solo con letras
        private void textBoxNombreSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }



        private void textBoxApellidoSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxUbicacion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void textBoxUbicacion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }
        private void textBoxUbicacion3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 64) || (e.KeyChar >= 91 && e.KeyChar <= 96) || (e.KeyChar >= 123 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo letras", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        //validacion de textos solo con numeros
        private void textBoxIdentificacionSocio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void textBoxCantidad_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void textBoxEdicion1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void textBoxEdicion2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }

        private void textBoxEdicion3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo Numeros", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;

            }
        }




        #endregion

       
    }
}
