using MediatR;
using Reservas.Application.Dto.Reserva;
using System;
using System.Collections.Generic;

namespace Reservas.Application.UseCases.Command.Reservas.CrearReserva
{
    public class CrearReservaCommand : IRequest<Guid>
    {
        private CrearReservaCommand() { }

        public CrearReservaCommand(List<VueloReservaDto> detalle)
        {
            Detalle = detalle;
        }
        public Guid IdVuelo { get; set; }
        public List<VueloReservaDto> Detalle { get; set; }
    }
}
