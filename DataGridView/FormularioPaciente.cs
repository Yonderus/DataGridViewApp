using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DataGridView
{
    public partial class FormularioPaciente : Form
    {
        string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private Paciente actualPacient;

        public FormularioPaciente(Paciente paciente)
        {
            InitializeComponent();
            RellenarDGV();


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
            int edad;

            /*
             Hacemos unas comprobacionespara que si hay algún campo vacío
             salte un messageBox
             */
            if (string.IsNullOrEmpty(tbNombrePaciente.Text) || string.IsNullOrEmpty(tbApellidoPaciente.Text) || tbEdadPaciente == null)
            {
                MessageBox.Show("No puedes dejar campos vacíos.");

                //Si pasa las comprobaciones anteriores, ahora comprobaremos que la edad es un número y que no es menor que 0
            }
            else if (!int.TryParse(tbEdadPaciente.Text, out edad) || edad < 0)
            {
                MessageBox.Show("Tienes que introducir una edad que sea correcta.");
            } else
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();

                    string sql = "INSERT INTO Pacientes (name, surname, age) VALUES (@name, @surname, @age)";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@name", tbNombrePaciente.Text);
                    cmd.Parameters.AddWithValue("@surname", tbApellidoPaciente.Text);
                    cmd.Parameters.AddWithValue("@age", tbEdadPaciente.Text);


                    int filas = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Se han introducido {filas} filas.");
                }
            }

            tbApellidoPaciente.Clear();
            tbEdadPaciente.Clear();
            tbNombrePaciente.Clear();
            RellenarDGV();
        }

        private void EditarPaciente()
        {
            if (dgvRegistro.CurrentRow != null)
            {
                int edad;
                if (string.IsNullOrEmpty(tbNombrePaciente.Text) || string.IsNullOrEmpty(tbApellidoPaciente.Text) || tbEdadPaciente == null)
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
                    int pacienteId = (int)dgvRegistro.CurrentRow.Cells[3].Value;

                    using (SqlConnection conn = new SqlConnection(cadena))
                    {
                        conn.Open();

                        string sql = "UPDATE Pacientes SET name = @name, surname = @surname, @age = age WHERE id_paciente = @id";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@id", pacienteId);
                        cmd.Parameters.AddWithValue("@name", tbNombrePaciente.Text);
                        cmd.Parameters.AddWithValue("@surname", tbApellidoPaciente.Text);
                        cmd.Parameters.AddWithValue("@age", tbEdadPaciente.Text);

                        int filas = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Se han actualizado {filas} filas.");

                        
                    }
                }
                tbApellidoPaciente.Clear();
                tbEdadPaciente.Clear();
                tbNombrePaciente.Clear();

                RellenarDGV();
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

        private void RellenarDGV()
        {

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Pacientes", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvRegistro.DataSource = dt;
            }
        }
    }
}
