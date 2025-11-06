using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
        private Paciente pacienteActual;
        private int contadorIngreso;

        public FormularioIngersos(Paciente paciente, int contador)
        {
            InitializeComponent();

            dtAlta.Enabled = false;

            pacienteActual = paciente;
            contadorIngreso = contador;

           

            // Mostrar los ingresos del paciente
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = pacienteActual.Ingresos;

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
            if (tbMotivo.Text == "" || tbHabitacion.Text == "" || tbEspecialidad.Text == "")
            {
                MessageBox.Show("No puedes dejar campos vacíos");
            }

            //Si no hay campos vacíos añadiremos los datos escritos en la lista de ingreso
                Ingreso ingreso = new Ingreso
                {
                    Id = contadorIngreso++,
                    Motivo = tbMotivo.Text,
                    FechaAlta = dtAlta.Value,
                    FechaIngreso = dtIngreso.Value,
                    Habitacion = tbHabitacion.Text,
                    Especialidad = tbEspecialidad.Text,
                };

                pacienteActual.Ingresos.Add(ingreso);

            
            //Refrescamos el grid view para que nos mueste los nuevos cambios
            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = pacienteActual.Ingresos;

            tbMotivo.Clear();
            tbEspecialidad.Clear();
            tbHabitacion.Clear();

            //Aqui volvemos a poner el group box en no visible, para que solo sea visible al pulsar una de las opciones de arriba
            gpbAgregarIngreso.Visible = false;
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

            if (tbMotivo.Text == "" || tbHabitacion.Text == "" || tbEspecialidad.Text == "")

            {
                MessageBox.Show("No puedes dejar campos vacíos.");
            }
            else
            {
                /*
                 Seguidamente si todo lo anterior se cumple, nos creamos una varible para luego asignar
                cada una de ellas a su text box
                 */


                Ingreso ingresoSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;

                ingresoSeleccionado.Motivo = tbMotivo.Text;
                ingresoSeleccionado.Especialidad = tbEspecialidad.Text;
                ingresoSeleccionado.Habitacion = tbHabitacion.Text;
                ingresoSeleccionado.FechaIngreso = dtIngreso.Value;
                ingresoSeleccionado.FechaAlta = dtAlta.Value;

                //Refrescamos la lista
                dgvIngresos.DataSource = null;
                dgvIngresos.DataSource = pacienteActual.Ingresos;

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

            DialogResult result = MessageBox.Show(
                "¿Seguro que deseas eliminar este ingreso?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (result == DialogResult.Yes)
            {
                Ingreso ingresoSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;
                pacienteActual.Ingresos.Remove(ingresoSeleccionado);

                dgvIngresos.DataSource = null;
                dgvIngresos.DataSource = pacienteActual.Ingresos;

                MessageBox.Show("Ingreso eliminado correctamente.");
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
            // Obtener la fila actual
            DataGridViewRow fila = dgvIngresos.Rows[e.RowIndex];

            // Asignar valores a controles
            tbMotivo.Text = fila.Cells["Motivo"].Value.ToString();
            tbEspecialidad.Text = fila.Cells["Especialidad"].Value.ToString();
            tbHabitacion.Text = fila.Cells["Habitacion"].Value.ToString();
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
    }
}
