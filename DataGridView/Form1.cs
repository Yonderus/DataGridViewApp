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

    public partial class Form1 : Form
    {
        string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;


        public Form1()
        {
            InitializeComponent();
            RellenarDGV();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            RellenarDGV();
        }

        
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(null);
            frm.ShowDialog();
            RellenarDGV();

        }

        /*
         En cambio aquí en el botón de editar si que cambiamos el null a por un paciente, por eso primero comprobamos que hay algún paciente
         seleccionado, si lo está creamos la variable de pacienteSeleccionado y le asignamos desde el GridView la línea
         */
        private void botonEditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para editar.");
                return;
            }

            int pacienteId= (int)dataGridViewForm1.CurrentRow.Cells[3].Value;

            Paciente pacienteSeleccionado = new Paciente { Id = pacienteId };

            var frm = new FormularioPaciente(pacienteSeleccionado);
            frm.ShowDialog();

            RellenarDGV();

        }

        private void botonListar_Click(object sender, EventArgs e)
        {
            abrirIngresos();
        }

        private void botonEliminar_Click(object sender, EventArgs e)
        {
          eliminarPaciente();
        }
            

        private void dataGridViewForm1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void abrirIngresos()
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para ver sus ingresos.");
                return;
            }

            int pacienteId = (int)dataGridViewForm1.CurrentRow.Cells[3].Value;

            Paciente pacienteSeleccionado = new Paciente { Id = pacienteId };

            var frm = new FormularioIngersos(pacienteSeleccionado);
            frm.ShowDialog();

        }

        private void saberMásMNU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una aplicación de hospital donde podrás agregar, editar y eliminar pacientes y donde podrás comprobar si esos tienen ingresos o no, al igual, podrás agregar, editar y eliminar ingresos.");
        }

        private void TLSagregar_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(null);
            frm.ShowDialog();

        }

        private void TLSeditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para editar.");
                return;
            }

            int pacienteId = (int)dataGridViewForm1.CurrentRow.Cells[3].Value;

            Paciente pacienteSeleccionado = new Paciente { Id = pacienteId };

            var frm = new FormularioPaciente(pacienteSeleccionado);
            frm.ShowDialog();

            RellenarDGV();
        }

        private void TLSeliminar_Click(object sender, EventArgs e)
        {
            eliminarPaciente();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(null);
            frm.ShowDialog();

        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para editar.");
                return;
            }

            int pacienteId = (int)dataGridViewForm1.CurrentRow.Cells[3].Value;

            Paciente pacienteSeleccionado = new Paciente { Id = pacienteId };

            var frm = new FormularioPaciente(pacienteSeleccionado);
            frm.ShowDialog();

            RellenarDGV();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaciente();
        }



        private void eliminarPaciente()
        {
            /*
           Para eliminar un paciente lo que hacemos primero es comprobar que hay alguno seleccionado
           de lo contrario nos saltará un messageBox
           */
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona al paciente que quieres eliminar");
            }

            int pacienteId = (int)dataGridViewForm1.CurrentRow.Cells[3].Value;

            Paciente pacienteSeleccionado = new Paciente { Id = pacienteId };

            if (pacienteSeleccionado != null)
            {
                /*
                 Si hay algún paciente seleccionado lo que haremos es hacer saltar un mensaje de confirmación
                 
                 (Esta opción la hice con ayuda de la IA)

                 Esto lo haremos creando una variable result, que lo que hará es generar un messageBox
                 donde nos saltarán unos mensajes.
                 Seguidamente con el BoxButtons le diremos que botones queremos que salgan dentro del messageBox
                 Y luego le decimos que como botón pre seleccionado queremos el button2, que en este caso sería el no
                 */
                DialogResult result = MessageBox.Show(
                    "¿Seguro que quieres eliminar este paciente?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button2
                );

                //En este if lo que hacemos es que si anteriormente el resultado es Yes, lo eliminaremos de la lista

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection conn = new SqlConnection(cadena))
                    {
                        conn.Open();

                        string sql = "DELETE FROM Pacientes WHERE id_paciente = @id";

                        SqlCommand cmd = new SqlCommand(sql, conn);

                        cmd.Parameters.AddWithValue("@id", pacienteId);

                        int filas = cmd.ExecuteNonQuery();
                        MessageBox.Show($"Filas eliminadas: {filas}");
                    }


                }
                RellenarDGV();
            }
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

                dataGridViewForm1.DataSource = dt;
            }
        }
    }
}
