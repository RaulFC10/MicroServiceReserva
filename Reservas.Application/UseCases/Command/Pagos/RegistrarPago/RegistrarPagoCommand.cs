using MediatR;
using Reservas.Application.Dto.Pago;
using System;

namespace Reservas.Application.UseCases.Command.Pagos.RegistrarPago
{
    public class RegistrarPagoCommand : IRequest<(Guid,string)>
    {
        private RegistrarPagoCommand() { }

        public RegistrarPagoCommand(PagoDto pago) {
            Pago = pago;
        }

        public PagoDto Pago { get; set; }
    }
}
