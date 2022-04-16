using ShareKernel.Core;
using System;

namespace Reservas.Domain.Model.Reservas
{
    public class VueloReserva : Entity<Guid>
    {
        public Guid IdPasajero { get; private set; }
        public decimal Costo { get; private set; }


        internal VueloReserva(Guid idPasajero, decimal costo)
        {
            Id = Guid.NewGuid();
            IdPasajero = idPasajero;
            Costo = costo;
        }
    }
}
