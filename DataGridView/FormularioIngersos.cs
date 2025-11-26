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
using System.Xml.Serialization;

namespace DataGridView
{
    public partial class FormularioIngersos : Form
    {

        private string cadena = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        private Paciente pacienteSeleccionado;
        public FormularioIngersos(Paciente paciente)
        {
            InitializeComponent();
            pacienteSeleccionado = paciente;
            RellenarDGV();
        }


        private void btbAgregarIngreso_Click(object sender, EventArgs e)
        {
            AgregarIngreso();
        }


        private void btbEditarIngresoFI_Click(object sender, EventArgs e)
        {
            EditarIngreso();

        }

        //Botón de eliminar
        private void button4_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }

        private void dgvIngresos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dtIngreso_ValueChanged(object sender, EventArgs e)
        {

        }

        private void dtAlta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbEspecialidad_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbMotivo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbHabitacion_TextChanged(object sender, EventArgs e)
        {

        }

        private void AgregarIngreso()
        {
            //Hacemos unas comprobaciones para que no hayan campos vacíos
            if (string.IsNullOrEmpty(tbMotivo.Text) || string.IsNullOrEmpty(tbHabitacion.Text) || string.IsNullOrEmpty(tbEspecialidad.Text))
            { 
                MessageBox.Show("No puedes dejar campos vacíos");
            }

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();

                string sql = "INSERT INTO Ingreso (fecha_ingreso, fecha_alta, motivo, habitacion, especialidad, id_paciente) VALUES (@fecha_ingreso, @fecha_alta, @motivo, @habitacion, @especialidad, @id_paciente)";

                SqlCommand cmd = new SqlCommand(sql, conn);
                
                
                cmd.Parameters.AddWithValue("@fecha_ingreso", dtIngreso.Value);
                cmd.Parameters.AddWithValue("@fecha_alta", dtAlta.Value);
                cmd.Parameters.AddWithValue("@motivo", tbMotivo.Text);
                cmd.Parameters.AddWithValue("@habitacion", tbHabitacion.Text);
                cmd.Parameters.AddWithValue("@especialidad", tbEspecialidad.Text);
                cmd.Parameters.AddWithValue("@id_paciente", pacienteSeleccionado.Id);
                

                int filas = cmd.ExecuteNonQuery();
                MessageBox.Show($"Filas insertadas: {filas}");
            }

            tbMotivo.Clear();
            tbEspecialidad.Clear();
            tbHabitacion.Clear();

            //Aqui volvemos a poner el group box en no visible, para que solo sea visible al pulsar una de las opciones de arriba
            gpbAgregarIngreso.Visible = false;
            RellenarDGV();
        }

        private void EditarIngreso()
        {
            //Para el botón de Editar lo que hacemos es, volver a poner visible el group box, cambiarle el texto para que ponga editar y
            //ocultar el botón de agregar y hacer visible el de editar
            gpbAgregarIngreso.Visible = true;
            gpbAgregarIngreso.Text = "Editar Ingreso";
            btEditarIngreso2.Visible = true;
            btbAgregarIngreso.Visible = false;

        }

        private void btEditarIngreso2_Click(object sender, EventArgs e)
        {
            /*
             Para editar, primero hacemos unas comprobaciones, comprobamos que hay seleccionado un ingreso
            y luego comprobamos que no hay ningún campo vacío
             */
            if (dgvIngresos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un ingreso para editar.");
                return;
            }

            if (string.IsNullOrEmpty(tbMotivo.Text) || string.IsNullOrEmpty(tbHabitacion.Text) || string.IsNullOrEmpty(tbEspecialidad.Text))

            {
                MessageBox.Show("No puedes dejar campos vacíos.");
            }
            else
            {
              
                int ingresoId = (int)dgvIngresos.CurrentRow.Cells[6].Value;

                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();

                    string sql = "UPDATE Ingreso SET fecha_alta = @fecha_alta, fecha_ingreso = @fecha_ingreso, motivo = @motivo, habitacion = @habitacion, especialidad = @especialidad WHERE id_ingreso = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", ingresoId);
                    //Lo de la fecha he recurrido ha buscarlo:
                    cmd.Parameters.Add("@fecha_alta", SqlDbType.Date).Value = dtAlta.Value.Date;
                    cmd.Parameters.Add("@fecha_ingreso", SqlDbType.Date).Value = dtIngreso.Value.Date;
                    cmd.Parameters.AddWithValue("@motivo", tbMotivo.Text);
                    cmd.Parameters.AddWithValue("@habitacion", tbHabitacion.Text);
                    cmd.Parameters.AddWithValue("@especialidad", tbEspecialidad.Text);

                    int filas = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Se han actualizado {filas} filas.");
                }

                //Refrescamos la lista
                RellenarDGV();

                //Volvemos a dar paso a la opción de agregar ingreso
                gpbAgregarIngreso.Text = "Agregar Ingreso";
                btEditarIngreso2.Visible = false;
                btbAgregarIngreso.Visible = true;
                tbEspecialidad.Clear();
                tbHabitacion.Clear();
                tbMotivo.Clear();
            }
        }

        private void EliminarIngreso()
        {

            /*
                 Si hay algún paciente ingreso lo que haremos es hacer saltar un mensaje de confirmación
                 
                 (Esta opción la hice con ayuda de la IA)

                 Esto lo haremos creando una variable result, que lo que hará es generar un messageBox
                 donde nos saltarán unos mensajes.
                 Seguidamente con el BoxButtons le diremos que botones queremos que salgan dentro del messageBox
                 Y luego le decimos que como botón pre seleccionado queremos el button2, que en este caso sería el no
                 */
            if (dgvIngresos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un ingreso para eliminar.");
                return;
            }

            int ingresoId = (int)dgvIngresos.CurrentRow.Cells[6].Value;

            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas eliminar este ingreso?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                using (SqlConnection conn = new SqlConnection(cadena))
                {
                    conn.Open();

                    string sql = "DELETE FROM Ingreso WHERE id_ingreso = @id";

                    SqlCommand cmd = new SqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@id", ingresoId);

                    int filas = cmd.ExecuteNonQuery();
                    MessageBox.Show($"Filas eliminadas: {filas}");
                }

                RellenarDGV();
            }
        }
        

        private void chbFechaAlta_CheckedChanged(object sender, EventArgs e)
        {
            //Hacemos un if para que si se selecciona el check box, la opción de las fechas sea true
            if (chbFechaAlta.Checked = true)
            {
                dtAlta.Enabled = true;
            }
        }

        private void dgvIngresos_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            //// Obtener la fila actual
            //DataGridViewRow fila = dgvIngresos.Rows[e.RowIndex];

            //// Asignar valores a controles
            //tbMotivo.Text = fila.Cells["Motivo"].Value.ToString();
            //tbEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
            //tbHabitacion.Text = fila.Cells["Habitacion"].Value.ToString();
        }

        //A partir de aquí solo son las funcionalidades de los botones para que variar entre el agregar y editar
        private void btAgregarIngreso2_Click(object sender, EventArgs e)
        {

            tbEspecialidad.Clear();
            tbHabitacion.Clear();
            tbMotivo.Clear();
            btbAgregarIngreso.Visible = true;
            btEditarIngreso2.Visible = false;
            gpbAgregarIngreso.Visible = true;
        }

        private void TLSagregar_Click(object sender, EventArgs e)
        {
            tbEspecialidad.Clear();
            tbHabitacion.Clear();
            tbMotivo.Clear();
            btbAgregarIngreso.Visible = true;
            btEditarIngreso2.Visible = false;
            gpbAgregarIngreso.Visible = true;
        }

        private void TLSeditar_Click(object sender, EventArgs e)
        {

            gpbAgregarIngreso.Visible = true;
            gpbAgregarIngreso.Text = "Editar Ingreso";
            btEditarIngreso2.Visible = true;
            btbAgregarIngreso.Visible = false;
        }

        private void TLSeliminar_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tbEspecialidad.Clear();
            tbHabitacion.Clear();
            tbMotivo.Clear();
            btbAgregarIngreso.Visible = true;
            btEditarIngreso2.Visible = false;
            gpbAgregarIngreso.Visible = true;
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gpbAgregarIngreso.Visible = true;
            gpbAgregarIngreso.Text = "Editar Ingreso";
            btEditarIngreso2.Visible = true;
            btbAgregarIngreso.Visible = false;
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EliminarIngreso();
        }

        private void saberMásMNU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aquí en este formulario podrás manipular cualquiera de los ingresos, añadir unos nuevos o eliminarlos.");
        }

        private void RellenarDGV()
        {

            using (SqlConnection conn = new SqlConnection(cadena))
            {
                conn.Open();

                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM Ingreso WHERE id_paciente = @id ", conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);

                da.SelectCommand.Parameters.AddWithValue("@id", pacienteSeleccionado.Id);


                DataTable dt = new DataTable();

                da.Fill(dt);

                dgvIngresos.DataSource = dt;
            }
        }
    }
}
