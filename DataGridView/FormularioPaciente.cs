using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class FormularioPaciente : Form
    {
        //Creamos estas tres variables para poder utilizarlas con la información que nos trae el otro formulario
        private Paciente actualPacient;
        private List<Paciente> listapacientes;
        private int contadorId;

        public FormularioPaciente(List<Paciente> pacientes, Paciente paciente, int contador)
        {
            InitializeComponent();
            //Aquí asignamos tanto la lista como el contador
            listapacientes = pacientes;
            contadorId = contador;

            //Volvemos a cargar el dataGridView
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listapacientes;

            /*
             Comprobamos primero que la opción que queremos es editar, eso quiere decir que si es diferente a null es decir
             la opción que habíamos puesto anteriormente en el Form1, si esta el pacienteSeleccionado, pasaremos a hacer el if, 
             de lo contrario no lo haremos.
             */

            if (paciente != null)
            {
                actualPacient = paciente;

                tbNombrePaciente.Text = actualPacient.Name;
                tbApellidoPaciente.Text = actualPacient.Surname;
                tbEdadPaciente.Text = actualPacient.Age.ToString();

                btEditarPaciente.Visible = true;
                btEditarPaciente.Enabled = true;
                btRegistrarPaciente.Visible = false;
                btRegistrarPaciente.Enabled = false;

                label1.Visible = true;
                lblPacienteTitulo.Visible = false;

            }


        }

        //Aquí lo que hacemos es en base la variable creada, recibir el contador anterior
        public int UltimoId
        {
            get { return contadorId; }
        }

        private void tbNombrePaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbApellidoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbEdadPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void btRegistrarPaciente_Click(object sender, EventArgs e)
        {
            AgregarPaciente();

        }

        /*
         Aquí en Editar el paciente, he tenido varios problemas al editar ya una persona y seleccionar otra
         esa se queda seleccionada y hay que cambiarlo manualmente todo otra vez.
         */
        private void btEditarPaciente_Click(object sender, EventArgs e)
        {

            EditarPaciente();
        }

        private void dgvRegistro_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void AgregarPaciente()
        {
            /*
           Creamos unas variables para asignar los textbox
           */
            String nombre;
            String apellido;
            int edad;

            /*
             Hacemos unas comprobaciones (no correctas porque los espacios en blanco se los come) para que si hay algún campo vacío
             salte un messageBox
             */
            if (tbNombrePaciente.Text == "" || tbApellidoPaciente.Text == "" || tbEdadPaciente == null)
            {
                MessageBox.Show("No puedes dejar campos vacíos.");

                //Si pasa las comprobaciones anteriores, ahora comprobaremos que la edad es un número y que no es menor que 0
            }
            else if (!int.TryParse(tbEdadPaciente.Text, out edad) || edad < 0)
            {
                MessageBox.Show("Tienes que introducir una edad que sea correcta.");
            }
            //Una vez se cumplan los anteriores, añadimos los datos a la lista
            else
            {
                nombre = tbNombrePaciente.Text;
                apellido = tbApellidoPaciente.Text;

                listapacientes.Add(new Paciente { Id = contadorId++, Name = nombre, Surname = apellido, Age = edad });
            }
            tbApellidoPaciente.Clear();
            tbEdadPaciente.Clear();
            tbNombrePaciente.Clear();
            //Y aquí volvemos a cargar la lista
            dgvRegistro.DataSource = null;
            dgvRegistro.DataSource = listapacientes;
        }

        private void EditarPaciente()
        {
            if (dgvRegistro.CurrentRow != null)
            {
                //Paciente pacienteSeleccionado = (Paciente)dgvRegistro.CurrentRow.DataBoundItem;
                actualPacient.Name = tbNombrePaciente.Text;
                actualPacient.Surname = tbApellidoPaciente.Text;
                int edad;
                if (tbNombrePaciente.Text == "" || tbApellidoPaciente.Text == "" || tbEdadPaciente == null)
                {
                    MessageBox.Show("No puedes dejar campos vacíos.");

                    //Si pasa las comprobaciones anteriores, ahora comprobaremos que la edad es un número y que no es menor que 0
                }
                else if (!int.TryParse(tbEdadPaciente.Text, out edad) || edad < 0)
                {
                    MessageBox.Show("Tienes que introducir una edad que sea correcta.");
                }
                //Una vez se cumplan los anteriores, añadimos los datos a la lista
                else
                {
                    actualPacient.Age = edad;

                }
                tbApellidoPaciente.Clear();
                tbEdadPaciente.Clear();
                tbNombrePaciente.Clear();
                //Y aquí volvemos a cargar la lista
                dgvRegistro.DataSource = null;
                dgvRegistro.DataSource = listapacientes;

                this.Close();

            }
        }

        private void TLSeditar_Click(object sender, EventArgs e)
        {
            //Habilitamos todas las funciones para que el titulo cambie y el botón de editar sea visible
            btEditarPaciente.Visible = true;
            btEditarPaciente.Enabled = true;
            btRegistrarPaciente.Visible = false;
            btRegistrarPaciente.Enabled = false;

            label1.Visible = true;
            lblPacienteTitulo.Visible = false;


        }

        private void dgvRegistro_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //// Obtener la fila actual
            //DataGridViewRow fila = dgvRegistro.Rows[e.RowIndex];

            //// Asignar valores a controles
            //tbNombrePaciente.Text = fila.Cells["Name"].Value.ToString();
            //tbApellidoPaciente.Text = fila.Cells["Surname"].Value.ToString();
            //tbEdadPaciente.Text = fila.Cells["Age"].Value.ToString();

            



        }

        private void TLSagregar_Click(object sender, EventArgs e)
        {
            
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void saberMásMNU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("En este apartado podrás tanto editar, como ingresar pacientes.");
        }
    }
}
