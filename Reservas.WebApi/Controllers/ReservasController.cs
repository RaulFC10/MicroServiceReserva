using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Reservas.Application.Dto.Reserva;
using Reservas.Application.UseCases.Command.Reservas.actualizarReserva;
using Reservas.Application.UseCases.Command.Reservas.CrearReserva;
using Reservas.Application.UseCases.Queries.Reservas.GetReservaById;
using System;
using System.Threading.Tasks;

namespace Reservas.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservasController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ReservasController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] CrearReservaCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return BadRequest();

            return Ok(id);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ActualizarReservaCommand command)
        {
            Guid id = await _mediator.Send(command);

            if (id == Guid.Empty)
                return NotFound(id);

            return Ok(id);
        }

        [Route("{id:guid}")]
        [HttpGet]
        public async Task<IActionResult> GetPedidoById([FromRoute] GetReservaByIdQuery command)
        {
            ReservaDto result = await _mediator.Send(command);

            if (result == null)
                return NotFound();

            return Ok(result);
        }
    }
}
