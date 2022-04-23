using Reservas.Domain.Model.Reservas;
using Reservas.Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF.Repository
{
    public class ReservaRepository : IReservaRepository
    {
        public Task CreateAsync(Reserva obj)
        {
            Console.WriteLine($"Insertando la reserva { obj.NroReserva }");

            return Task.CompletedTask;
        }

        public Task<Reserva> FindByIdAsync(Guid id)
        {
            Console.WriteLine($"Retornando la reserva { id }");

            return null;
        }

        public Task UpdateAsync(Reserva obj)
        {
            Console.WriteLine($"Actualizando ls reserva { obj.NroReserva }");

            return Task.CompletedTask;
        }
    }
}
