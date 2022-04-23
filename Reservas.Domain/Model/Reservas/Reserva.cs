using Reservas.Domain.Event;
using Reservas.Domain.Model.Reservas.ValueObjects;
using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Reservas.Domain.Model.Reservas
{
    public class Reserva : AggregateRoot<Guid>
    {
        public Guid IdVuelo { get; private set; }
        public NumeroReserva NroReserva { get; private set; }
        public PrecioValue Costo { get; private set; }
        public readonly ICollection<VueloReserva> VueloReserva;


        public IReadOnlyCollection<VueloReserva> Detalle
        {
            get
            {
                return new ReadOnlyCollection<VueloReserva>(VueloReserva.ToList());
            }
        }
        private Reserva() { }
        internal Reserva(Guid idVuelo, string nroReserva)
        {
            Id = Guid.NewGuid();
            IdVuelo = idVuelo;
            NroReserva = nroReserva;
            Costo = new PrecioValue(0m);
            VueloReserva = new List<VueloReserva>();
        }

        public void AgregarItem(Guid idPasajero, decimal costo)
        {
            var detalleReserva = VueloReserva.FirstOrDefault(x => x.IdPasajero == idPasajero);
            if (detalleReserva is null)
            {
                detalleReserva = new VueloReserva(idPasajero, costo);
                VueloReserva.Add(detalleReserva);
            }
            else
            {
                detalleReserva.ModificarReserva(idPasajero, costo);
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
