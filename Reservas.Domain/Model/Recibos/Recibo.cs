using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Model.Recibos
{
    public class Recibo : AggregateRoot<Guid>
    {
        public Guid IdReserva { get; private set; }
        public DateTime Fecha { get; private set; }
        public PrecioValue Monto { get; private set; }

        public Recibo(decimal monto)
        {
            Fecha = DateTime.Now;
            Monto = monto;
        }
    }
}
