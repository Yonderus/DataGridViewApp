using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class Ingreso
    {
        public int Id { get; set; }
        public DateTime FechaIngreso { get; set; }
        public DateTime? FechaAlta { get; set; }
        public string Motivo { get; set; }
        public string Habitacion { get; set; }
        public string Especialidad { get; set; }


        

    }
}
