using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDato
{
    public sealed class Singleton
    {
        public Singleton()
        {
            this.Vehiculos = new List<Vehiculo>();
            this.Carreras = new List<Carrera>();
        }
        private static Singleton instancia = null;
        public static Singleton Instancia
        {
            get
            {
                if (instancia == null)
                {
                    instancia = new Singleton();
                }
                return instancia;
            }
        }

        public List<Vehiculo> Vehiculos { get; set; }
        public List<Carrera> Carreras { get; set; }
    }
}

