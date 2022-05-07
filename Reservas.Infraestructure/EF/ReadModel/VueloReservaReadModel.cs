using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF.ReadModel
{
    public class VueloReservaReadModel
    {
        public Guid Id { get; set; }
        public decimal Costo { get; private set; }
        public bool Activo { get; private set; }
        public Guid IdPasajero { get; set; }
        public ReservaReadModel Reserva { get; set; }
    }
}
