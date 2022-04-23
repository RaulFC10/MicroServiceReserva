using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Application.Dto.Reserva
{
    public class VueloReservaDto
    {
        public Guid IdPasajero { get; set; }
        public decimal Costo { get; set; }
    }
}
