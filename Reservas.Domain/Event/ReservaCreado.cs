using ShareKernel.Core;
using System;

namespace Reservas.Domain.Event
{
    public record ReservaCreado : DomainEvent
    {
        public Guid IdReserva { get; }
        public string NroReserva { get; }
        public decimal Costo { get; }
        public Guid IdVuelo { get; }
        public ReservaCreado(Guid idReserva, string nroReserva, decimal costo, Guid idVuelo) : base(DateTime.Now)
        {
            IdReserva = idReserva;
            NroReserva= nroReserva;
            Costo = costo;
            IdVuelo = idVuelo;
        }
    }
}
