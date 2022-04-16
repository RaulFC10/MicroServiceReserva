using Reservas.Domain.Event;
using Reservas.Domain.Model.Reservas.ValueObjects;
using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Reservas.Domain.Model.Reservas
{
    public class Reserva : AggregateRoot<Guid>
    {
        public Guid IdVuelo { get; private set; }
        public NumeroReserva NroReserva { get; private set; }
        public PrecioValue Costo { get; private set; }
        public ICollection<VueloReserva> VueloReserva { get; private set; }

        public Reserva(Guid idVuelo, string nroReserva)
        {
            Id = Guid.NewGuid();
            IdVuelo = idVuelo;
            NroReserva = nroReserva;
            Costo = new PrecioValue(0m);
            VueloReserva = new List<VueloReserva>();
        }

        public void AgregarItem(Guid idPasajero, decimal costo)
        {
            var detallePedido = VueloReserva.FirstOrDefault(x => x.IdPasajero == idPasajero);
            if (detallePedido is null)
            {
                detallePedido = new VueloReserva(idPasajero, costo);
                VueloReserva.Add(detallePedido);
            }
            Costo += costo;
            AddDomainEvent(new ItemVueloReservaAgregado(idPasajero, Costo));
        }

        public void ConsolidarReserva()
        {
            var evento = new ReservaCreado(Id, NroReserva, Costo, IdVuelo);
            AddDomainEvent(evento);
        }
    }
}
