using Reservas.Domain.ValueObjects;
using ShareKernel.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Domain.Model.Vuelos
{
    public class Vuelo : AggregateRoot<Guid>
    {
        public TimeSpan HoraSalida{ get; private set; }
        public TimeSpan HoraLlegada { get; private set; }
        public string Estado { get; private set; }
        public PrecioValue Precio { get; private set; }
        public DateTime Fecha{ get; private set; }
        public Guid IdDestino { get; private set; }
        public Guid IdAeronave { get; private set; }
        public bool Activo{ get; private set; }

        public Vuelo(TimeSpan horaSalida, TimeSpan horaLlegada, string estado, decimal precio, Guid idDestino, Guid idAeronave, bool activo)
        {
            Id = Guid.NewGuid();
            HoraSalida = horaSalida;
            HoraLlegada = horaLlegada;
            Estado = estado;
            Precio = precio;
            Fecha = DateTime.Now;
            IdDestino = idDestino;
            IdAeronave = idAeronave;
            Activo = activo;
        }
    }
}
