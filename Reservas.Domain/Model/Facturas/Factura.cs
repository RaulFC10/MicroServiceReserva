using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Model.Facturas
{
    public class Factura : AggregateRoot<Guid>
    {
        public Guid IdReserva { get; private set; }
        public DateTime Fecha { get; private set; }
        public PrecioValue Monto { get; private set; }

        public Factura(decimal monto)
        {
            Fecha = DateTime.Now;
            Monto = monto;
        }
    }
}
