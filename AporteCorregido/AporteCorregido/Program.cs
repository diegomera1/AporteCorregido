using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeNegocio;

namespace AporteCorregido
{
    class Program
    {
        static void Main(string[] args)
        {
            NegocioUsuario usuario = new NegocioUsuario();
            //Instaciar los vehículos
            #region
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0001",
                Marca = "Toyota",
                Modelo = "Rx7",
                Color = "Negro"
            };
            usuario.InsertarVehiculo();
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0002",
                Marca = "Mazda",
                Modelo = "Mazda 3",
                Color = "Azul"
            };                       
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0003",
                Marca = "Chevrolet",
                Modelo = "Steem",
                Color = "Negro"
            };
            usuario.InsertarVehiculo();
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0004",
                Marca = "Mazda",
                Modelo = "Mazda 6",
                Color = "Gris"
            };
            usuario.InsertarVehiculo();
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0005",
                Marca = "Chevrolet",
                Modelo = "Mazda 2",
                Color = "Marrón"
            };
            usuario.InsertarVehiculo();
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0006",
                Marca = "Toyota",
                Modelo = "Hilux",
                Color = "Blanco"
            };
            usuario.InsertarVehiculo();
            usuario.Vehiculo = new CapaDeDato.Vehiculo()
            {
                Placa = "0007",
                Marca = "Suzuki",
                Modelo = "Forza",
                Color = "Plata"
            };
            usuario.InsertarVehiculo();
            #endregion
            //Instaciar las carreras
            #region
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0001",
                Cliente = "Cristhia Bacusoy",
                Fecha = new DateTime(2019, 01, 22),
                OrigenDestino = "Montecristi-Manta",
                ValorPagado = 1
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0001",
                Cliente = "Juan Romero",
                Fecha = new DateTime(2019, 01, 11),
                OrigenDestino = "Montecristi-Montañita",
                ValorPagado = 8
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0001",
                Cliente = "Raúl Zelaya",
                Fecha = new DateTime(2018, 01, 01),
                OrigenDestino = "Manta-Montecristi",
                ValorPagado = 9
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0002",
                Cliente = "Ariel Caminos",
                Fecha = new DateTime(2020, 01, 09),
                OrigenDestino = "Playa-Parque",
                ValorPagado = 2
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0002",
                Cliente = "Diego Mera",
                Fecha = new DateTime(2018, 01, 21),
                OrigenDestino = "Mall-Tarqui",
                ValorPagado = 2
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0003",
                Cliente = "José José",
                Fecha = new DateTime(2020, 01, 12),
                OrigenDestino = "Montecristi-Portoviejo",
                ValorPagado = 5
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0004",
                Cliente = "Juan Romero",
                Fecha = new DateTime(2019, 01, 11),
                OrigenDestino = "Montecristi-Montañita",
                ValorPagado = 8
            };
            usuario.InsertarCarrera();            
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0005",
                Cliente = "Juan Manuel",
                Fecha = new DateTime(2019, 01, 19),
                OrigenDestino = "Portoviejo-Rocafuerte",
                ValorPagado = 10
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0006",
                Cliente = "Chad Man",
                Fecha = new DateTime(2019, 08, 19),
                OrigenDestino = "Eden-Manta",
                ValorPagado = 10
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0003",
                Cliente = "Virgin guy",
                Fecha = new DateTime(2019, 07, 19),
                OrigenDestino = "Manta-Jaramijo",
                ValorPagado = 10
            };
            usuario.InsertarCarrera();
            usuario.Carrera = new CapaDeDato.Carrera()
            {
                Placa = "0006",
                Cliente = "Random",
                Fecha = new DateTime(2020, 07, 19),
                OrigenDestino = "Manta-Jaramijo",
                ValorPagado = 10
            };
            usuario.InsertarCarrera();
            #endregion
            //El que tiene más carreras
            #region
            var maximaCarrera = from carrera in usuario.ListaCarreras()
                                group carrera by carrera.Placa into cantidad
                                orderby cantidad.Count() descending
                                select cantidad;
            Console.WriteLine("La placa #{0} es la que obtuvo más carreras",maximaCarrera.First().Key);
            #endregion
            //Promedio por año
            #region
            var promediosPorAnio = from carrera in usuario.ListaCarreras()
                                   group carrera by carrera.Fecha.Year;
            foreach (var item in promediosPorAnio)
            {
                Console.WriteLine("Año: {0} el valor promedio por carrera fue {1}",item.Key,item.Average(x=> x.ValorPagado));
            };
            #endregion
            //Imprimir lista por carrera
            #region
            
            foreach (var x in usuario.ListaCarreras())
            {
                Console.WriteLine("Cliente:{0}     Valor:{1}", x.Cliente, x.ValorPagado);
            }
            #endregion
            Console.ReadKey();
        }
    }
}
