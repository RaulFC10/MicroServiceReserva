using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Model.Anulacion
{
    public class AnulacionReserva : AggregateRoot<Guid>
    {
        public Guid IdReserva { get; private set; }
        public DateTime Fecha { get; private set; }
        public string Motivo { get; private set; }

        public AnulacionReserva(string motivo)
        {
            Fecha = DateTime.Now;
            Motivo = motivo;

        }
    }
}
