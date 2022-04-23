using MediatR;
using Microsoft.Extensions.Logging;
using Reservas.Application.Dto.Reserva;
using Reservas.Domain.Model.Reservas;
using Reservas.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Reservas.Application.UseCases.Queries.Reservas.GetReservaById
{
    public class GetReservaByIdHandler : IRequestHandler<GetReservaByIdQuery, ReservaDto>
    {
        private readonly IReservaRepository _reservaRepository;
        private readonly ILogger<GetReservaByIdQuery> _logger;

        public GetReservaByIdHandler(IReservaRepository reservaRepository, ILogger<GetReservaByIdQuery> logger)
        {
            _reservaRepository = reservaRepository;
            _logger = logger;
        }

        public async Task<ReservaDto> Handle(GetReservaByIdQuery request, CancellationToken cancellationToken)
        {
            ReservaDto result = null;
            try
            {
                Reserva objReserva = await _reservaRepository.FindByIdAsync(request.Id);

                result = new ReservaDto()
                {
                    Id = objReserva.Id,
                    NroReserva = objReserva.NroReserva,
                    IdVuelo = objReserva.IdVuelo,
                    Costo = objReserva.Costo
                };

                foreach (var item in objReserva.VueloReserva)
                {
                    result.VueloReserva.Add(new VueloReservaDto()
                    {
                        Costo = item.Costo,
                        IdPasajero = item.IdPasajero,
                    });
                }
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error al obtener la Reserva con id: { IdReserva }", request.Id);
            }

            return result;
        }
    }
}
