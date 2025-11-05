using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace DataGridView
{
    public class Paciente
    {
        public int Id {  get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public List<Ingreso> Ingresos { get; set; } = new List<Ingreso>();
    }
}
