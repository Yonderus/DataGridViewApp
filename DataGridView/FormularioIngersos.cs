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
            if (tbMotivo.Text == "" || tbHabitacion.Text == "" || tbEspecialidad.Text == "")
            {
                MessageBox.Show("No puedes dejar campos vacíos");
            }

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

            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = pacienteActual.Ingresos;

            tbMotivo.Clear();
            tbEspecialidad.Clear();
            tbHabitacion.Clear();
        }

        private void EditarIngreso()
        {
            if (dgvIngresos.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un ingreso para editar.");
                return;
            }

            if (tbMotivo.Text == "" || tbHabitacion.Text == "" || tbEspecialidad.Text == "")

            {
                MessageBox.Show("No puedes dejar campos vacíos.");
            }

            Ingreso ingresoSeleccionado = (Ingreso)dgvIngresos.CurrentRow.DataBoundItem;

            ingresoSeleccionado.Motivo = tbMotivo.Text;
            ingresoSeleccionado.Especialidad = tbEspecialidad.Text;
            ingresoSeleccionado.Habitacion = tbHabitacion.Text;
            ingresoSeleccionado.FechaIngreso = dtIngreso.Value;
            ingresoSeleccionado.FechaAlta = dtAlta.Value;

            dgvIngresos.DataSource = null;
            dgvIngresos.DataSource = pacienteActual.Ingresos;
        }

        private void EliminarIngreso()
        {
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
    }
}
