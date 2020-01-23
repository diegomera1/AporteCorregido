using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDato
{
    public class Carrera
    {
        public Carrera()
        {
        }
        public string Placa { get; set; }
        public string Cliente { get; set; }
        public DateTime Fecha { get; set; }
        public string OrigenDestino { get; set; }
        public double ValorPagado { get; set; }
    }
}
