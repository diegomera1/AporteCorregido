using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDeDato
{
    public class Gestion
    {
        public void InsertarVehiculo(Vehiculo vehiculo)
        {
            Singleton.Instancia.Vehiculos.Add(vehiculo);
        }
        public void InsertarCarrera(Carrera carrera)
        {
            Singleton.Instancia.Carreras.Add(carrera);
        }
        public List<Vehiculo> ListaVehiculos()
        {
            return Singleton.Instancia.Vehiculos;
        }
        public List<Carrera> ListaCarreras()
        {
            return Singleton.Instancia.Carreras;
        }
        public Gestion()
        {
        }
    }
}

