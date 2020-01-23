using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeDato;
namespace CapaDeNegocio
{
    public class NegocioUsuario
    {
        Gestion gestion;
        public NegocioUsuario()
        {
            gestion = new Gestion();
        }

        public void InsertarVehiculo()
        {
            gestion.InsertarVehiculo(this.Vehiculo);
        }
        public void InsertarCarrera()
        {
            gestion.InsertarCarrera(this.Carrera);
        }
        public List<Vehiculo> ListaVehiculos()
        {
            return gestion.ListaVehiculos();
        }
        public List<Carrera> ListaCarreras()
        {
            return gestion.ListaCarreras();
        }
        public Vehiculo Vehiculo { get; set; }
        public Carrera Carrera { get; set; }
    }
}
