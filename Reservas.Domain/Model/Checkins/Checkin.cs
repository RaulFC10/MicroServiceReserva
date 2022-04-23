using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Model.Checkins
{
    public class Checkin : AggregateRoot<Guid>
    {
        public Guid IdPasajero { get; private set; }
        public Guid IdReserva { get; private set; }
        public DateTime Fecha { get; private set; }
        public DateTime HoraAbordaje { get; private set; }
        public CantidadValue NroAsiento { get; private set; }
        public CantidadValue PuertaEmbarque { get; private set; }
        public Checkin(DateTime horaAbordaje, int nroAsiento, int puertaEmbarque)
        {
            Fecha = DateTime.Now;
            HoraAbordaje = horaAbordaje;
            NroAsiento = nroAsiento;
            PuertaEmbarque = puertaEmbarque;

        }
    }
}
