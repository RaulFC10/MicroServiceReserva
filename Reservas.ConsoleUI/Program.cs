using Reservas.Domain.Model.Pasajeros;
using Reservas.Domain.Model.Reservas;
using Reservas.Domain.Model.Vuelos;
using System;

namespace Reservas.ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Vuelo objVuelo = new Vuelo(TimeSpan.Parse("08:30"), TimeSpan.Parse("11:30"), "salida",400, Guid.NewGuid(), Guid.NewGuid(), true);

            Pasajero objPasajero1 = new Pasajero("9645624", "Raul fulguera");
            Pasajero objPasajero2 = new Pasajero("9536428", "Juan Perez");

            Reserva objReserva = new Reserva(objVuelo.Id, "1");
            objReserva.AgregarItem(objPasajero1.Id, objVuelo.Precio);
            objReserva.AgregarItem(objPasajero2.Id, objVuelo.Precio);

            objReserva.ConsolidarReserva();


            

        }
    }
}
