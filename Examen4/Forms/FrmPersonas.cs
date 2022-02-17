#region Usos
using Forms.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
#endregion

namespace Forms
{
    public partial class FrmPersonas : Form
    {
        #region Variables Globales
        List<Ingeniero> listaIngeniero = new List<Ingeniero>();
        Ingeniero ingeniero;
        List<Universitario> listaUniversitario = new List<Universitario>();
        Universitario universitario;
        List<Estudiante> listaEstudiante = new List<Estudiante>();
        Estudiante estudiante;
        List<Persona> listaPersona = new List<Persona>();
        Persona persona;

        //Cambiar Variable
        int contador = 0;
        int valor1 = 0;
        int valor2 = 0;
        #endregion

        #region Inicializar Componente frmPersona
        public FrmPersonas()
        {
            InitializeComponent();
            listaIngeniero = new List<Ingeniero>();
            listaUniversitario = new List<Universitario>();
            listaEstudiante = new List<Estudiante>();
            listaPersona = new List<Persona>();
        }
        #endregion

        #region Carga del formulario Persona
        private void FrmPersonas_Load(object sender, EventArgs e)
        {
            //if (cmbCarrera.Text == "IngenieriaComputacion")
            //{

            //}

            //if (cmbCarrera.Text == "IngenieriaElectrica")
            //{

            //}
            //if (cmbCarrera.Text == "IngenieriaIndustrial")
            //{

            //}
            //if (cmbCarrera.Text == "IngenieriaMecanica")
            //{

            //}
            //if (cmbCarrera.Text == "IngenieriaQuimica")
            //{

            //}
        }
        #endregion

        #region Boton Registrar Click
        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Ingenierio")
            {
                GuardarIngeniero();
            }
            if (cmbTipo.Text == "Universitario")
            {
                GuardarUniversitario();
            }
            if (cmbTipo.Text == "Estudiante")
            {
                GuardarEstudiante();
            }
            if (cmbTipo.Text == "Persona")
            {
                GuardarPersona();
            }
        }
        #endregion

        #region Boton Mostrar Click
        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            if (cmbTipo.Text == "Ingenierio")
            {
                MostrarIngeniero();
            }
            if (cmbTipo.Text == "Universitario")
            {
                MostrarUniversitario();
            }
            if (cmbTipo.Text == "Estudiante")
            {
                MostrarEstudiante();
            }
            if (cmbTipo.Text == "Persona")
            {
                MostrarPersona();
            }
            
        }
        #endregion

        #region Boton Salir Click
        private void BtnSalir_Click(object sender, EventArgs e)
        {
            DialogResult r = MessageBox.Show("¿Quieres Salir del Formulario?", "Persona",
                MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation);
            if (r == DialogResult.Yes) this.Close();
        }
        #endregion

        #region Metodos de Guardado
        public void GuardarIngeniero()
        {
            ingeniero = new Ingeniero(txtNombre.Text, cmbSexo.Text, int.Parse(txtEdad.Text),
                txtCarnet.Text, cmbNivel.Text, cmbUniversidad.Text,
                cmbCarrera.Text, cmbMaterias.Text, int.Parse(txtNotas.Text),
                txtProyecto.Text, int.Parse(txtHoraT.Text), int.Parse(txtHoraC.Text));
        }
        public void GuardarUniversitario()
        {
            universitario = new Universitario(txtNombre.Text, cmbSexo.Text, int.Parse(txtEdad.Text),
                txtCarnet.Text, cmbNivel.Text, cmbUniversidad.Text,
                cmbCarrera.Text, cmbMaterias.Text, int.Parse(txtNotas.Text));
        }
        public void GuardarEstudiante()
        {
            estudiante = new Estudiante(txtNombre.Text, cmbSexo.Text, int.Parse(txtEdad.Text),
                txtCarnet.Text, cmbNivel.Text);
        }
        public void GuardarPersona()
        {
            persona = new Persona(txtNombre.Text, cmbSexo.Text, int.Parse(txtEdad.Text));
        }
        #endregion

        #region Metodos Mostrado
        public void MostrarIngeniero()
        {
            listaIngeniero.Add(ingeniero);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaIngeniero;
        }
        public void MostrarUniversitario()
        {
            listaUniversitario.Add(universitario);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaUniversitario;
        }
        public void MostrarEstudiante()
        {
            listaEstudiante.Add(estudiante);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaEstudiante;
        }
        public void MostrarPersona()
        {
            listaPersona.Add(persona);

            dgvPersona.DataSource = null;
            dgvPersona.DataSource = listaPersona;
        }

        #endregion

        #region Metodo Combo Box Seleccion de Tipo
        private void CmbTipo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cmbTipo.Text)
            {
                case "Persona":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = false;
                        lblNivel.Visible = false;
                        txtCarnet.Visible = false;
                        cmbNivel.Visible = false;

                        lblUniversidad.Visible = false;
                        lblCarrera.Visible = false;
                        lblMaterias.Visible = false;
                        lblNotas.Visible = false;
                        cmbUniversidad.Visible = false;
                        cmbCarrera.Visible = false;
                        cmbMaterias.Visible = false;
                        txtNotas.Visible = false;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;

                case "Estudiante":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = false;
                        lblCarrera.Visible = false;
                        lblMaterias.Visible = false;
                        lblNotas.Visible = false;
                        cmbUniversidad.Visible = false;
                        cmbCarrera.Visible = false;
                        cmbMaterias.Visible = false;
                        txtNotas.Visible = false;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;
                case "Universitario":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = true;
                        lblCarrera.Visible = true;
                        lblMaterias.Visible = true;
                        lblNotas.Visible = true;
                        cmbUniversidad.Visible = true;
                        cmbCarrera.Visible = true;
                        cmbMaterias.Visible = true;
                        txtNotas.Visible = true;

                        lblProyecto.Visible = false;
                        lblHorasT.Visible = false;
                        lblHorasC.Visible = false;
                        txtProyecto.Visible = false;
                        txtHoraT.Visible = false;
                        txtHoraC.Visible = false;
                    }
                    break;
                case "Ingeniero":
                    {
                        lblNombre.Visible = true;
                        lblSexo.Visible = true;
                        lblEdad.Visible = true;
                        txtNombre.Visible = true;
                        cmbSexo.Visible = true;
                        txtEdad.Visible = true;

                        lblCarnet.Visible = true;
                        lblNivel.Visible = true;
                        txtCarnet.Visible = true;
                        cmbNivel.Visible = true;

                        lblUniversidad.Visible = true;
                        lblCarrera.Visible = true;
                        lblMaterias.Visible = true;
                        lblNotas.Visible = true;
                        cmbUniversidad.Visible = true;
                        cmbCarrera.Visible = true;
                        cmbMaterias.Visible = true;
                        txtNotas.Visible = true;

                        lblProyecto.Visible = true;
                        lblHorasT.Visible = true;
                        lblHorasC.Visible = true;
                        txtProyecto.Visible = true;
                        txtHoraT.Visible = true;
                        txtHoraC.Visible = true;
                    }
                    break;
            }
        }
        #endregion

        public void ObtenerPromedio()
        {
            //IEnumerable<Ingeniero> Promedio = from Pro in listaIngeniero;
                                
                            
        }

        //Cambiar Variables
        #region LINQ
        public void getUniversidadMasEstudiantes()
        {
            IEnumerable<Ingeniero> UniversidadUNI = from uni in listaIngeniero where uni.Universidades == "UNI" select uni;

            foreach (var Uni in UniversidadUNI)
            {
                txtConsulta.Clear();
                txtConsulta.Text = "la Universidad Con Mayor Numero de Ingenieros Es: " + Uni.Universidades + "\r\n";
            }
        }
        public void getEstudianteYUniversidad()
        {
            Ingeniero d = new Ingeniero();

            IEnumerable<Ingeniero> EstudiantesIng = from uni in listaIngeniero select uni;
            IEnumerable<Universitario> EstudiantesUniv = from univer in listaUniversitario select univer;

            foreach (Ingeniero xd in EstudiantesIng)
            {
                txtConsulta.AppendText(xd.ImprimirIngenieria());
            }
            foreach (Universitario xd2 in EstudiantesUniv)
            {
                txtConsulta.AppendText(xd2.ImprimirUniversitario());
            }
        }
        public void getPromedio()
        {

            IEnumerable<Ingeniero> promedio = from p in listaIngeniero select p;
            IEnumerable<Universitario> promedio2 = from f in listaUniversitario select f;

            foreach (Ingeniero d in listaIngeniero)
            {
                contador++;
                valor1 = +d.Promedio1();
            }
            foreach (Universitario xd in listaIngeniero)
            {
                contador++;
                valor2 = +xd.Promedio2();
            }
            int Valorcompleto = valor1 + valor2;
            double Promedio = Valorcompleto / contador;
            txtConsulta.AppendText("El promedio notas aproximado de los todos los Estudiantes es de: " + Promedio);
        }
        #endregion

        //Cambiar Variables
        #region Radio Boton
        private void RbUniversidadMasEstudiantes_CheckedChanged(object sender, EventArgs e)
        {
            getUniversidadMasEstudiantes();
        }

        private void RbPromediio_CheckedChanged(object sender, EventArgs e)
        {
            getPromedio();
        }

        private void RbNameyUniver_CheckedChanged(object sender, EventArgs e)
        {
            getEstudianteYUniversidad();
        }
        #endregion
    }
}