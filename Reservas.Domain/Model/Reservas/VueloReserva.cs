using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Model.Reservas
{
    public class VueloReserva : Entity<Guid>
    {
        public Guid IdPasajero { get; private set; }
        public PrecioValue Costo { get; private set; }


        internal VueloReserva(Guid idPasajero, decimal costo)
        {
            Id = Guid.NewGuid();
            IdPasajero = idPasajero;
            Costo = costo;
        }

        internal void ModificarReserva(Guid idPasajero, decimal costo)
        {
            Costo = costo;
            IdPasajero = idPasajero;
        }
    }
}
