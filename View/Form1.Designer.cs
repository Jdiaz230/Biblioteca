
namespace Biblioteca
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCrearSocio = new System.Windows.Forms.Button();
            this.buttonCrearLibro = new System.Windows.Forms.Button();
            this.buttonPrestarEjemplar = new System.Windows.Forms.Button();
            this.buttonDevolver = new System.Windows.Forms.Button();
            this.buttonHistorial = new System.Windows.Forms.Button();
            this.buttonConsulta = new System.Windows.Forms.Button();
            this.textBoxNombreSocio = new System.Windows.Forms.TextBox();
            this.textBoxIdentificacionSocio = new System.Windows.Forms.TextBox();
            this.textBoxApellidoSocio = new System.Windows.Forms.TextBox();
            this.buttonAgregarSocio = new System.Windows.Forms.Button();
            this.labelNombreSocio = new System.Windows.Forms.Label();
            this.labelApellidoSocio = new System.Windows.Forms.Label();
            this.labelIdentificacionSocio = new System.Windows.Forms.Label();
            this.labelMensajeError = new System.Windows.Forms.Label();
            this.checkBoxSocioComun = new System.Windows.Forms.CheckBox();
            this.checkBoxSocioVIP = new System.Windows.Forms.CheckBox();
            this.labelMensajeSocioCreado = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCantidad = new System.Windows.Forms.Label();
            this.textBoxCantidad = new System.Windows.Forms.TextBox();
            this.labelEjemplar1 = new System.Windows.Forms.Label();
            this.textBoxEdicion1 = new System.Windows.Forms.TextBox();
            this.labelEdicion1 = new System.Windows.Forms.Label();
            this.labelUbicacio1 = new System.Windows.Forms.Label();
            this.textBoxUbicacion1 = new System.Windows.Forms.TextBox();
            this.textBoxUbicacion2 = new System.Windows.Forms.TextBox();
            this.labelUbicacion2 = new System.Windows.Forms.Label();
            this.labelEdicion2 = new System.Windows.Forms.Label();
            this.textBoxEdicion2 = new System.Windows.Forms.TextBox();
            this.labelEjemplar2 = new System.Windows.Forms.Label();
            this.textBoxUbicacion3 = new System.Windows.Forms.TextBox();
            this.labelUbicacion3 = new System.Windows.Forms.Label();
            this.labelEdicion3 = new System.Windows.Forms.Label();
            this.textBoxEdicion3 = new System.Windows.Forms.TextBox();
            this.labelEjemplar3 = new System.Windows.Forms.Label();
            this.buttonAgregarEjemplar = new System.Windows.Forms.Button();
            this.buttonAgregarLibro = new System.Windows.Forms.Button();
            this.labelMjsLibroCreado = new System.Windows.Forms.Label();
            this.buttonBuscarSocio = new System.Windows.Forms.Button();
            this.buttonBuscarLibro = new System.Windows.Forms.Button();
            this.buttonAgregarPrestamo = new System.Windows.Forms.Button();
            this.labelMensajeDeCantidad = new System.Windows.Forms.Label();
            this.buttonConsultorCupo = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Edicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ubicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Devolver = new System.Windows.Forms.DataGridViewButtonColumn();
            this.buttonMostrarlistaEjemplares = new System.Windows.Forms.Button();
            this.buttonConsultarEjemplar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonCrearSocio
            // 
            this.buttonCrearSocio.Location = new System.Drawing.Point(33, 54);
            this.buttonCrearSocio.Name = "buttonCrearSocio";
            this.buttonCrearSocio.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearSocio.TabIndex = 0;
            this.buttonCrearSocio.Text = "Crear Socio";
            this.buttonCrearSocio.UseVisualStyleBackColor = true;
            this.buttonCrearSocio.Click += new System.EventHandler(this.buttonCrearSocio_Click);
            // 
            // buttonCrearLibro
            // 
            this.buttonCrearLibro.Location = new System.Drawing.Point(33, 98);
            this.buttonCrearLibro.Name = "buttonCrearLibro";
            this.buttonCrearLibro.Size = new System.Drawing.Size(75, 23);
            this.buttonCrearLibro.TabIndex = 1;
            this.buttonCrearLibro.Text = "Crear Libro";
            this.buttonCrearLibro.UseVisualStyleBackColor = true;
            this.buttonCrearLibro.Click += new System.EventHandler(this.buttonCrearLibro_Click);
            // 
            // buttonPrestarEjemplar
            // 
            this.buttonPrestarEjemplar.Location = new System.Drawing.Point(33, 143);
            this.buttonPrestarEjemplar.Name = "buttonPrestarEjemplar";
            this.buttonPrestarEjemplar.Size = new System.Drawing.Size(75, 40);
            this.buttonPrestarEjemplar.TabIndex = 2;
            this.buttonPrestarEjemplar.Text = "Prestar Ejemplar";
            this.buttonPrestarEjemplar.UseVisualStyleBackColor = true;
            this.buttonPrestarEjemplar.Click += new System.EventHandler(this.buttonPrestarEjemplar_Click);
            // 
            // buttonDevolver
            // 
            this.buttonDevolver.Location = new System.Drawing.Point(33, 197);
            this.buttonDevolver.Name = "buttonDevolver";
            this.buttonDevolver.Size = new System.Drawing.Size(75, 35);
            this.buttonDevolver.TabIndex = 3;
            this.buttonDevolver.Text = "Devolver Libro";
            this.buttonDevolver.UseVisualStyleBackColor = true;
            this.buttonDevolver.Click += new System.EventHandler(this.buttonDevolver_Click);
            // 
            // buttonHistorial
            // 
            this.buttonHistorial.Location = new System.Drawing.Point(33, 245);
            this.buttonHistorial.Name = "buttonHistorial";
            this.buttonHistorial.Size = new System.Drawing.Size(75, 23);
            this.buttonHistorial.TabIndex = 4;
            this.buttonHistorial.Text = "Historial";
            this.buttonHistorial.UseVisualStyleBackColor = true;
            this.buttonHistorial.Click += new System.EventHandler(this.buttonHistorial_Click);
            // 
            // buttonConsulta
            // 
            this.buttonConsulta.Location = new System.Drawing.Point(33, 285);
            this.buttonConsulta.Name = "buttonConsulta";
            this.buttonConsulta.Size = new System.Drawing.Size(75, 23);
            this.buttonConsulta.TabIndex = 5;
            this.buttonConsulta.Text = "Consulta";
            this.buttonConsulta.UseVisualStyleBackColor = true;
            this.buttonConsulta.Click += new System.EventHandler(this.buttonConsulta_Click);
            // 
            // textBoxNombreSocio
            // 
            this.textBoxNombreSocio.Location = new System.Drawing.Point(256, 57);
            this.textBoxNombreSocio.Name = "textBoxNombreSocio";
            this.textBoxNombreSocio.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombreSocio.TabIndex = 7;
            this.textBoxNombreSocio.Visible = false;
            this.textBoxNombreSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxNombreSocio_KeyPress);
            // 
            // textBoxIdentificacionSocio
            // 
            this.textBoxIdentificacionSocio.Location = new System.Drawing.Point(545, 57);
            this.textBoxIdentificacionSocio.Name = "textBoxIdentificacionSocio";
            this.textBoxIdentificacionSocio.Size = new System.Drawing.Size(100, 20);
            this.textBoxIdentificacionSocio.TabIndex = 8;
            this.textBoxIdentificacionSocio.Visible = false;
            this.textBoxIdentificacionSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxIdentificacionSocio_KeyPress);
            // 
            // textBoxApellidoSocio
            // 
            this.textBoxApellidoSocio.Location = new System.Drawing.Point(409, 57);
            this.textBoxApellidoSocio.Name = "textBoxApellidoSocio";
            this.textBoxApellidoSocio.Size = new System.Drawing.Size(100, 20);
            this.textBoxApellidoSocio.TabIndex = 9;
            this.textBoxApellidoSocio.Visible = false;
            this.textBoxApellidoSocio.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxApellidoSocio_KeyPress);
            // 
            // buttonAgregarSocio
            // 
            this.buttonAgregarSocio.Location = new System.Drawing.Point(678, 55);
            this.buttonAgregarSocio.Name = "buttonAgregarSocio";
            this.buttonAgregarSocio.Size = new System.Drawing.Size(75, 23);
            this.buttonAgregarSocio.TabIndex = 10;
            this.buttonAgregarSocio.Text = "Crear";
            this.buttonAgregarSocio.UseVisualStyleBackColor = true;
            this.buttonAgregarSocio.Visible = false;
            this.buttonAgregarSocio.Click += new System.EventHandler(this.buttonAgregarSocio_Click);
            // 
            // labelNombreSocio
            // 
            this.labelNombreSocio.AutoSize = true;
            this.labelNombreSocio.Location = new System.Drawing.Point(253, 41);
            this.labelNombreSocio.Name = "labelNombreSocio";
            this.labelNombreSocio.Size = new System.Drawing.Size(50, 13);
            this.labelNombreSocio.TabIndex = 11;
            this.labelNombreSocio.Text = "Nombre: ";
            this.labelNombreSocio.Visible = false;
            // 
            // labelApellidoSocio
            // 
            this.labelApellidoSocio.AutoSize = true;
            this.labelApellidoSocio.Location = new System.Drawing.Point(406, 41);
            this.labelApellidoSocio.Name = "labelApellidoSocio";
            this.labelApellidoSocio.Size = new System.Drawing.Size(47, 13);
            this.labelApellidoSocio.TabIndex = 12;
            this.labelApellidoSocio.Text = "Apellido:";
            this.labelApellidoSocio.Visible = false;
            // 
            // labelIdentificacionSocio
            // 
            this.labelIdentificacionSocio.AutoSize = true;
            this.labelIdentificacionSocio.Location = new System.Drawing.Point(547, 41);
            this.labelIdentificacionSocio.Name = "labelIdentificacionSocio";
            this.labelIdentificacionSocio.Size = new System.Drawing.Size(76, 13);
            this.labelIdentificacionSocio.TabIndex = 13;
            this.labelIdentificacionSocio.Text = "Identificación: ";
            this.labelIdentificacionSocio.Visible = false;
            // 
            // labelMensajeError
            // 
            this.labelMensajeError.AutoSize = true;
            this.labelMensajeError.Location = new System.Drawing.Point(256, 362);
            this.labelMensajeError.Name = "labelMensajeError";
            this.labelMensajeError.Size = new System.Drawing.Size(285, 13);
            this.labelMensajeError.TabIndex = 14;
            this.labelMensajeError.Text = "Por favor ingrese datos correctos a los recuadros de texto!!";
            // 
            // checkBoxSocioComun
            // 
            this.checkBoxSocioComun.AutoSize = true;
            this.checkBoxSocioComun.Location = new System.Drawing.Point(364, 89);
            this.checkBoxSocioComun.Name = "checkBoxSocioComun";
            this.checkBoxSocioComun.Size = new System.Drawing.Size(89, 17);
            this.checkBoxSocioComun.TabIndex = 15;
            this.checkBoxSocioComun.Text = "Socio Común";
            this.checkBoxSocioComun.UseVisualStyleBackColor = true;
            this.checkBoxSocioComun.Visible = false;
            this.checkBoxSocioComun.CheckedChanged += new System.EventHandler(this.checkBoxSocioComun_CheckedChanged);
            // 
            // checkBoxSocioVIP
            // 
            this.checkBoxSocioVIP.AutoSize = true;
            this.checkBoxSocioVIP.Location = new System.Drawing.Point(473, 89);
            this.checkBoxSocioVIP.Name = "checkBoxSocioVIP";
            this.checkBoxSocioVIP.Size = new System.Drawing.Size(73, 17);
            this.checkBoxSocioVIP.TabIndex = 16;
            this.checkBoxSocioVIP.Text = "Socio VIP";
            this.checkBoxSocioVIP.UseVisualStyleBackColor = true;
            this.checkBoxSocioVIP.Visible = false;
            this.checkBoxSocioVIP.CheckedChanged += new System.EventHandler(this.checkBoxSocioVIP_CheckedChanged);
            // 
            // labelMensajeSocioCreado
            // 
            this.labelMensajeSocioCreado.AutoSize = true;
            this.labelMensajeSocioCreado.Location = new System.Drawing.Point(264, 73);
            this.labelMensajeSocioCreado.Name = "labelMensajeSocioCreado";
            this.labelMensajeSocioCreado.Size = new System.Drawing.Size(166, 13);
            this.labelMensajeSocioCreado.TabIndex = 17;
            this.labelMensajeSocioCreado.Text = "El socio ha sido creado con exito!";
            this.labelMensajeSocioCreado.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(256, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 13);
            this.label1.TabIndex = 18;
            // 
            // labelCantidad
            // 
            this.labelCantidad.AutoSize = true;
            this.labelCantidad.Location = new System.Drawing.Point(256, 108);
            this.labelCantidad.Name = "labelCantidad";
            this.labelCantidad.Size = new System.Drawing.Size(160, 13);
            this.labelCantidad.TabIndex = 19;
            this.labelCantidad.Text = "Cantidad de ejemplares (max 3): ";
            this.labelCantidad.Visible = false;
            // 
            // textBoxCantidad
            // 
            this.textBoxCantidad.Location = new System.Drawing.Point(422, 105);
            this.textBoxCantidad.Name = "textBoxCantidad";
            this.textBoxCantidad.Size = new System.Drawing.Size(100, 20);
            this.textBoxCantidad.TabIndex = 20;
            this.textBoxCantidad.Visible = false;
            this.textBoxCantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxCantidad_KeyPress);
            // 
            // labelEjemplar1
            // 
            this.labelEjemplar1.AutoSize = true;
            this.labelEjemplar1.Location = new System.Drawing.Point(256, 144);
            this.labelEjemplar1.Name = "labelEjemplar1";
            this.labelEjemplar1.Size = new System.Drawing.Size(65, 13);
            this.labelEjemplar1.TabIndex = 21;
            this.labelEjemplar1.Text = "Ejemplar 1 : ";
            this.labelEjemplar1.Visible = false;
            // 
            // textBoxEdicion1
            // 
            this.textBoxEdicion1.Location = new System.Drawing.Point(332, 160);
            this.textBoxEdicion1.Name = "textBoxEdicion1";
            this.textBoxEdicion1.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdicion1.TabIndex = 22;
            this.textBoxEdicion1.Visible = false;
            this.textBoxEdicion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdicion1_KeyPress);
            // 
            // labelEdicion1
            // 
            this.labelEdicion1.AutoSize = true;
            this.labelEdicion1.Location = new System.Drawing.Point(256, 165);
            this.labelEdicion1.Name = "labelEdicion1";
            this.labelEdicion1.Size = new System.Drawing.Size(70, 13);
            this.labelEdicion1.TabIndex = 23;
            this.labelEdicion1.Text = "Num Edición:";
            this.labelEdicion1.Visible = false;
            // 
            // labelUbicacio1
            // 
            this.labelUbicacio1.AutoSize = true;
            this.labelUbicacio1.Location = new System.Drawing.Point(256, 192);
            this.labelUbicacio1.Name = "labelUbicacio1";
            this.labelUbicacio1.Size = new System.Drawing.Size(58, 13);
            this.labelUbicacio1.TabIndex = 24;
            this.labelUbicacio1.Text = "Ubicación:";
            this.labelUbicacio1.Visible = false;
            // 
            // textBoxUbicacion1
            // 
            this.textBoxUbicacion1.Location = new System.Drawing.Point(332, 189);
            this.textBoxUbicacion1.Name = "textBoxUbicacion1";
            this.textBoxUbicacion1.Size = new System.Drawing.Size(100, 20);
            this.textBoxUbicacion1.TabIndex = 25;
            this.textBoxUbicacion1.Visible = false;
            this.textBoxUbicacion1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbicacion1_KeyPress);
            // 
            // textBoxUbicacion2
            // 
            this.textBoxUbicacion2.Location = new System.Drawing.Point(567, 189);
            this.textBoxUbicacion2.Name = "textBoxUbicacion2";
            this.textBoxUbicacion2.Size = new System.Drawing.Size(100, 20);
            this.textBoxUbicacion2.TabIndex = 30;
            this.textBoxUbicacion2.Visible = false;
            this.textBoxUbicacion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbicacion2_KeyPress);
            // 
            // labelUbicacion2
            // 
            this.labelUbicacion2.AutoSize = true;
            this.labelUbicacion2.Location = new System.Drawing.Point(491, 192);
            this.labelUbicacion2.Name = "labelUbicacion2";
            this.labelUbicacion2.Size = new System.Drawing.Size(58, 13);
            this.labelUbicacion2.TabIndex = 29;
            this.labelUbicacion2.Text = "Ubicación:";
            this.labelUbicacion2.Visible = false;
            // 
            // labelEdicion2
            // 
            this.labelEdicion2.AutoSize = true;
            this.labelEdicion2.Location = new System.Drawing.Point(491, 165);
            this.labelEdicion2.Name = "labelEdicion2";
            this.labelEdicion2.Size = new System.Drawing.Size(70, 13);
            this.labelEdicion2.TabIndex = 28;
            this.labelEdicion2.Text = "Num Edición:";
            this.labelEdicion2.Visible = false;
            // 
            // textBoxEdicion2
            // 
            this.textBoxEdicion2.Location = new System.Drawing.Point(567, 160);
            this.textBoxEdicion2.Name = "textBoxEdicion2";
            this.textBoxEdicion2.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdicion2.TabIndex = 27;
            this.textBoxEdicion2.Visible = false;
            this.textBoxEdicion2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdicion2_KeyPress);
            // 
            // labelEjemplar2
            // 
            this.labelEjemplar2.AutoSize = true;
            this.labelEjemplar2.Location = new System.Drawing.Point(491, 144);
            this.labelEjemplar2.Name = "labelEjemplar2";
            this.labelEjemplar2.Size = new System.Drawing.Size(65, 13);
            this.labelEjemplar2.TabIndex = 26;
            this.labelEjemplar2.Text = "Ejemplar 2 : ";
            this.labelEjemplar2.Visible = false;
            // 
            // textBoxUbicacion3
            // 
            this.textBoxUbicacion3.Location = new System.Drawing.Point(464, 269);
            this.textBoxUbicacion3.Name = "textBoxUbicacion3";
            this.textBoxUbicacion3.Size = new System.Drawing.Size(100, 20);
            this.textBoxUbicacion3.TabIndex = 35;
            this.textBoxUbicacion3.Visible = false;
            this.textBoxUbicacion3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxUbicacion3_KeyPress);
            // 
            // labelUbicacion3
            // 
            this.labelUbicacion3.AutoSize = true;
            this.labelUbicacion3.Location = new System.Drawing.Point(388, 272);
            this.labelUbicacion3.Name = "labelUbicacion3";
            this.labelUbicacion3.Size = new System.Drawing.Size(58, 13);
            this.labelUbicacion3.TabIndex = 34;
            this.labelUbicacion3.Text = "Ubicación:";
            this.labelUbicacion3.Visible = false;
            // 
            // labelEdicion3
            // 
            this.labelEdicion3.AutoSize = true;
            this.labelEdicion3.Location = new System.Drawing.Point(388, 245);
            this.labelEdicion3.Name = "labelEdicion3";
            this.labelEdicion3.Size = new System.Drawing.Size(70, 13);
            this.labelEdicion3.TabIndex = 33;
            this.labelEdicion3.Text = "Num Edición:";
            this.labelEdicion3.Visible = false;
            // 
            // textBoxEdicion3
            // 
            this.textBoxEdicion3.Location = new System.Drawing.Point(464, 242);
            this.textBoxEdicion3.Name = "textBoxEdicion3";
            this.textBoxEdicion3.Size = new System.Drawing.Size(100, 20);
            this.textBoxEdicion3.TabIndex = 32;
            this.textBoxEdicion3.Visible = false;
            this.textBoxEdicion3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBoxEdicion3_KeyPress);
            // 
            // labelEjemplar3
            // 
            this.labelEjemplar3.AutoSize = true;
            this.labelEjemplar3.Location = new System.Drawing.Point(388, 224);
            this.labelEjemplar3.Name = "labelEjemplar3";
            this.labelEjemplar3.Size = new System.Drawing.Size(65, 13);
            this.labelEjemplar3.TabIndex = 31;
            this.labelEjemplar3.Text = "Ejemplar 3 : ";
            this.labelEjemplar3.Visible = false;
            // 
            // buttonAgregarEjemplar
            // 
            this.buttonAgregarEjemplar.Location = new System.Drawing.Point(596, 103);
            this.buttonAgregarEjemplar.Name = "buttonAgregarEjemplar";
            this.buttonAgregarEjemplar.Size = new System.Drawing.Size(136, 23);
            this.buttonAgregarEjemplar.TabIndex = 36;
            this.buttonAgregarEjemplar.Text = "Agregar ejemplares";
            this.buttonAgregarEjemplar.UseVisualStyleBackColor = true;
            this.buttonAgregarEjemplar.Visible = false;
            this.buttonAgregarEjemplar.Click += new System.EventHandler(this.buttonAgregarEjemplar_Click);
            // 
            // buttonAgregarLibro
            // 
            this.buttonAgregarLibro.Location = new System.Drawing.Point(596, 307);
            this.buttonAgregarLibro.Name = "buttonAgregarLibro";
            this.buttonAgregarLibro.Size = new System.Drawing.Size(136, 23);
            this.buttonAgregarLibro.TabIndex = 37;
            this.buttonAgregarLibro.Text = "Crear";
            this.buttonAgregarLibro.UseVisualStyleBackColor = true;
            this.buttonAgregarLibro.Visible = false;
            this.buttonAgregarLibro.Click += new System.EventHandler(this.buttonAgregarLibro_Click);
            // 
            // labelMjsLibroCreado
            // 
            this.labelMjsLibroCreado.AutoSize = true;
            this.labelMjsLibroCreado.Location = new System.Drawing.Point(264, 130);
            this.labelMjsLibroCreado.Name = "labelMjsLibroCreado";
            this.labelMjsLibroCreado.Size = new System.Drawing.Size(160, 13);
            this.labelMjsLibroCreado.TabIndex = 38;
            this.labelMjsLibroCreado.Text = "El libro ha sido creado con exito!";
            this.labelMjsLibroCreado.Visible = false;
            // 
            // buttonBuscarSocio
            // 
            this.buttonBuscarSocio.Location = new System.Drawing.Point(256, 89);
            this.buttonBuscarSocio.Name = "buttonBuscarSocio";
            this.buttonBuscarSocio.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarSocio.TabIndex = 39;
            this.buttonBuscarSocio.Text = "Buscar";
            this.buttonBuscarSocio.UseVisualStyleBackColor = true;
            this.buttonBuscarSocio.Visible = false;
            this.buttonBuscarSocio.Click += new System.EventHandler(this.buttonBuscarSocio_Click);
            // 
            // buttonBuscarLibro
            // 
            this.buttonBuscarLibro.Location = new System.Drawing.Point(409, 89);
            this.buttonBuscarLibro.Name = "buttonBuscarLibro";
            this.buttonBuscarLibro.Size = new System.Drawing.Size(75, 23);
            this.buttonBuscarLibro.TabIndex = 40;
            this.buttonBuscarLibro.Text = "Buscar";
            this.buttonBuscarLibro.UseVisualStyleBackColor = true;
            this.buttonBuscarLibro.Visible = false;
            this.buttonBuscarLibro.Click += new System.EventHandler(this.buttonBuscarLibro_Click);
            // 
            // buttonAgregarPrestamo
            // 
            this.buttonAgregarPrestamo.Location = new System.Drawing.Point(546, 262);
            this.buttonAgregarPrestamo.Name = "buttonAgregarPrestamo";
            this.buttonAgregarPrestamo.Size = new System.Drawing.Size(118, 46);
            this.buttonAgregarPrestamo.TabIndex = 41;
            this.buttonAgregarPrestamo.Text = "Prestar ";
            this.buttonAgregarPrestamo.UseVisualStyleBackColor = true;
            this.buttonAgregarPrestamo.Visible = false;
            this.buttonAgregarPrestamo.Click += new System.EventHandler(this.buttonAgregarPrestamo_Click);
            // 
            // labelMensajeDeCantidad
            // 
            this.labelMensajeDeCantidad.AutoSize = true;
            this.labelMensajeDeCantidad.Location = new System.Drawing.Point(411, 128);
            this.labelMensajeDeCantidad.Name = "labelMensajeDeCantidad";
            this.labelMensajeDeCantidad.Size = new System.Drawing.Size(0, 13);
            this.labelMensajeDeCantidad.TabIndex = 42;
            // 
            // buttonConsultorCupo
            // 
            this.buttonConsultorCupo.Location = new System.Drawing.Point(256, 89);
            this.buttonConsultorCupo.Name = "buttonConsultorCupo";
            this.buttonConsultorCupo.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultorCupo.TabIndex = 46;
            this.buttonConsultorCupo.Text = "Consultar";
            this.buttonConsultorCupo.UseVisualStyleBackColor = false;
            this.buttonConsultorCupo.Visible = false;
            this.buttonConsultorCupo.Click += new System.EventHandler(this.buttonConsultorCupo_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Edicion,
            this.Ubicacion,
            this.Devolver});
            this.dataGridView1.Location = new System.Drawing.Point(256, 197);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(448, 150);
            this.dataGridView1.TabIndex = 47;
            this.dataGridView1.Visible = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre Libro";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Edicion
            // 
            this.Edicion.HeaderText = "Edicion";
            this.Edicion.Name = "Edicion";
            this.Edicion.ReadOnly = true;
            // 
            // Ubicacion
            // 
            this.Ubicacion.HeaderText = "Ubicacion";
            this.Ubicacion.Name = "Ubicacion";
            this.Ubicacion.ReadOnly = true;
            // 
            // Devolver
            // 
            this.Devolver.HeaderText = "";
            this.Devolver.Name = "Devolver";
            this.Devolver.ReadOnly = true;
            this.Devolver.Text = "Devolver";
            // 
            // buttonMostrarlistaEjemplares
            // 
            this.buttonMostrarlistaEjemplares.Location = new System.Drawing.Point(256, 118);
            this.buttonMostrarlistaEjemplares.Name = "buttonMostrarlistaEjemplares";
            this.buttonMostrarlistaEjemplares.Size = new System.Drawing.Size(149, 48);
            this.buttonMostrarlistaEjemplares.TabIndex = 48;
            this.buttonMostrarlistaEjemplares.Text = "Mostrar lista de ejemplares prestados";
            this.buttonMostrarlistaEjemplares.UseVisualStyleBackColor = true;
            this.buttonMostrarlistaEjemplares.Visible = false;
            this.buttonMostrarlistaEjemplares.Click += new System.EventHandler(this.buttonMostrarlistaEjemplares_Click);
            // 
            // buttonConsultarEjemplar
            // 
            this.buttonConsultarEjemplar.Location = new System.Drawing.Point(409, 89);
            this.buttonConsultarEjemplar.Name = "buttonConsultarEjemplar";
            this.buttonConsultarEjemplar.Size = new System.Drawing.Size(75, 23);
            this.buttonConsultarEjemplar.TabIndex = 49;
            this.buttonConsultarEjemplar.Text = "Consultar";
            this.buttonConsultarEjemplar.UseVisualStyleBackColor = false;
            this.buttonConsultarEjemplar.Visible = false;
            this.buttonConsultarEjemplar.Click += new System.EventHandler(this.buttonConsultarEjemplar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 513);
            this.Controls.Add(this.buttonConsultarEjemplar);
            this.Controls.Add(this.buttonMostrarlistaEjemplares);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonConsultorCupo);
            this.Controls.Add(this.labelMensajeDeCantidad);
            this.Controls.Add(this.buttonAgregarPrestamo);
            this.Controls.Add(this.buttonBuscarLibro);
            this.Controls.Add(this.buttonBuscarSocio);
            this.Controls.Add(this.labelMjsLibroCreado);
            this.Controls.Add(this.buttonAgregarLibro);
            this.Controls.Add(this.buttonAgregarEjemplar);
            this.Controls.Add(this.textBoxUbicacion3);
            this.Controls.Add(this.labelUbicacion3);
            this.Controls.Add(this.labelEdicion3);
            this.Controls.Add(this.textBoxEdicion3);
            this.Controls.Add(this.labelEjemplar3);
            this.Controls.Add(this.textBoxUbicacion2);
            this.Controls.Add(this.labelUbicacion2);
            this.Controls.Add(this.labelEdicion2);
            this.Controls.Add(this.textBoxEdicion2);
            this.Controls.Add(this.labelEjemplar2);
            this.Controls.Add(this.textBoxUbicacion1);
            this.Controls.Add(this.labelUbicacio1);
            this.Controls.Add(this.labelEdicion1);
            this.Controls.Add(this.textBoxEdicion1);
            this.Controls.Add(this.labelEjemplar1);
            this.Controls.Add(this.textBoxCantidad);
            this.Controls.Add(this.labelCantidad);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelMensajeSocioCreado);
            this.Controls.Add(this.checkBoxSocioVIP);
            this.Controls.Add(this.checkBoxSocioComun);
            this.Controls.Add(this.labelMensajeError);
            this.Controls.Add(this.labelIdentificacionSocio);
            this.Controls.Add(this.labelApellidoSocio);
            this.Controls.Add(this.labelNombreSocio);
            this.Controls.Add(this.buttonAgregarSocio);
            this.Controls.Add(this.textBoxApellidoSocio);
            this.Controls.Add(this.textBoxIdentificacionSocio);
            this.Controls.Add(this.textBoxNombreSocio);
            this.Controls.Add(this.buttonConsulta);
            this.Controls.Add(this.buttonHistorial);
            this.Controls.Add(this.buttonDevolver);
            this.Controls.Add(this.buttonPrestarEjemplar);
            this.Controls.Add(this.buttonCrearLibro);
            this.Controls.Add(this.buttonCrearSocio);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCrearSocio;
        private System.Windows.Forms.Button buttonCrearLibro;
        private System.Windows.Forms.Button buttonPrestarEjemplar;
        private System.Windows.Forms.Button buttonDevolver;
        private System.Windows.Forms.Button buttonHistorial;
        private System.Windows.Forms.Button buttonConsulta;
        private System.Windows.Forms.TextBox textBoxNombreSocio;
        private System.Windows.Forms.TextBox textBoxIdentificacionSocio;
        private System.Windows.Forms.TextBox textBoxApellidoSocio;
        private System.Windows.Forms.Button buttonAgregarSocio;
        private System.Windows.Forms.Label labelNombreSocio;
        private System.Windows.Forms.Label labelApellidoSocio;
        private System.Windows.Forms.Label labelIdentificacionSocio;
        private System.Windows.Forms.Label labelMensajeError;
        private System.Windows.Forms.CheckBox checkBoxSocioComun;
        private System.Windows.Forms.CheckBox checkBoxSocioVIP;
        private System.Windows.Forms.Label labelMensajeSocioCreado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCantidad;
        private System.Windows.Forms.TextBox textBoxCantidad;
        private System.Windows.Forms.Label labelEjemplar1;
        private System.Windows.Forms.TextBox textBoxEdicion1;
        private System.Windows.Forms.Label labelEdicion1;
        private System.Windows.Forms.Label labelUbicacio1;
        private System.Windows.Forms.TextBox textBoxUbicacion1;
        private System.Windows.Forms.TextBox textBoxUbicacion2;
        private System.Windows.Forms.Label labelUbicacion2;
        private System.Windows.Forms.Label labelEdicion2;
        private System.Windows.Forms.TextBox textBoxEdicion2;
        private System.Windows.Forms.Label labelEjemplar2;
        private System.Windows.Forms.TextBox textBoxUbicacion3;
        private System.Windows.Forms.Label labelUbicacion3;
        private System.Windows.Forms.Label labelEdicion3;
        private System.Windows.Forms.TextBox textBoxEdicion3;
        private System.Windows.Forms.Label labelEjemplar3;
        private System.Windows.Forms.Button buttonAgregarEjemplar;
        private System.Windows.Forms.Button buttonAgregarLibro;
        private System.Windows.Forms.Label labelMjsLibroCreado;
        private System.Windows.Forms.Button buttonBuscarSocio;
        private System.Windows.Forms.Button buttonBuscarLibro;
        private System.Windows.Forms.Button buttonAgregarPrestamo;
        private System.Windows.Forms.Label labelMensajeDeCantidad;
        private System.Windows.Forms.Button buttonConsultorCupo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Edicion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ubicacion;
        private System.Windows.Forms.DataGridViewButtonColumn Devolver;
        private System.Windows.Forms.Button buttonMostrarlistaEjemplares;
        private System.Windows.Forms.Button buttonConsultarEjemplar;
    }
}