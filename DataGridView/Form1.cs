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
    public partial class Form1 : Form
    {

        private List<Paciente> pacientes = new List<Paciente>();
        private int contadorId = 1;
        private int contadorIdIngreso = 1;
        public Form1()
        {
            InitializeComponent();
        }

        private void RefrescarGrid()
        {
            //Relleno el textbox con  la lista
            dataGridViewForm1.DataSource = null;
            dataGridViewForm1.DataSource = pacientes;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Creo unos cuantos registros pero para comprobar el funcionamiento de la App

            pacientes.Add(new Paciente { Id = contadorId++, Name = "Javier", Surname = "Gisbert", Age = 20, Ingresos = new List<Ingreso> { new Ingreso { Id = contadorIdIngreso++,  
            FechaIngreso = new DateTime(2025, 10, 10),
            FechaAlta = new DateTime(),
            Motivo = "Fractura de hueso",
            Especialidad = "Traumatología",
            Habitacion = "204H"  } } });

            pacientes.Add(new Paciente { Id = contadorId++, Name = "Finca", Surname = "Terrasa", Age = 16 });
            pacientes.Add(new Paciente { Id = contadorId++, Name = "Pago", Surname = "Carraovejas", Age = 50 });
            RefrescarGrid();
        }

        /*
         El cambio que he hecho ha sido porque no puedo poner una función genérica en los botones, ya que cada uno va a hacer algo diferente
         el de agregar si que hará como lo teniamos antes, introducimos la lista, introducimos un null porque no queremos editar ningún paciente
         y luego le asignamos el contador para poder seguir desde el que teníamos anteriormente utilizando.
         */
        private void botonAgregar_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(pacientes, null, contadorId);
            frm.ShowDialog();

            contadorId = frm.UltimoId;
            RefrescarGrid();
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

            Paciente pacienteSeleccionado = (Paciente)dataGridViewForm1.CurrentRow.DataBoundItem;

            var frm = new FormularioPaciente(pacientes, pacienteSeleccionado, contadorId);
            frm.ShowDialog();
            RefrescarGrid();
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

            Paciente pacienteSeleccionado = (Paciente)dataGridViewForm1.CurrentRow.DataBoundItem;

            var frm = new FormularioIngersos(pacienteSeleccionado, contadorIdIngreso);
            frm.ShowDialog();

            RefrescarGrid();
        }

        private void saberMásMNU_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Esta es una aplicación de hospital donde podrás agregar, editar y eliminar pacientes y donde podrás comprobar si esos tienen ingresos o no, al igual, podrás agregar, editar y eliminar ingresos.");
        }

        private void TLSagregar_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(pacientes, null, contadorId);
            frm.ShowDialog();

            contadorId = frm.UltimoId;
            RefrescarGrid();
        }

        private void TLSeditar_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para editar.");
                return;
            }

            Paciente pacienteSeleccionado = (Paciente)dataGridViewForm1.CurrentRow.DataBoundItem;

            var frm = new FormularioPaciente(pacientes, pacienteSeleccionado, contadorId);
            frm.ShowDialog();
            RefrescarGrid();
        }

        private void TLSeliminar_Click(object sender, EventArgs e)
        {
            eliminarPaciente();
        }

        private void agregarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frm = new FormularioPaciente(pacientes, null, contadorId);
            frm.ShowDialog();

            contadorId = frm.UltimoId;
            RefrescarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridViewForm1.CurrentRow == null)
            {
                MessageBox.Show("Selecciona un paciente para editar.");
                return;
            }

            Paciente pacienteSeleccionado = (Paciente)dataGridViewForm1.CurrentRow.DataBoundItem;

            var frm = new FormularioPaciente(pacientes, pacienteSeleccionado, contadorId);
            frm.ShowDialog();
            RefrescarGrid();
        }

        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eliminarPaciente();
        }

        //private void abrirPaciente()
        //{
        //    /*
        //     Aquí introduzco la lista de pacientes, un null y el contador del Id de los pacientes
        //     Que seguidamente le decimos que el contadorId es la variable creada en el formulario de paciente
        //     */
        //    var frm = new FormularioPaciente(pacientes, null, contadorId);
        //    frm.ShowDialog();

        //    contadorId = frm.UltimoId;

        //    RefrescarGrid();
        //}

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


            if (pacientes != null)
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
                    Paciente pacienteSeleccionado = (Paciente)dataGridViewForm1.CurrentRow.DataBoundItem;
                    pacientes.Remove(pacienteSeleccionado);

                    RefrescarGrid();

                }
            }
        }

       
    }
}
