using Reservas.Domain.Model.Pasajeros;
using ShareKernel.Core;
using System;
using System.Threading.Tasks;

namespace Reservas.Domain.Repositories
{
    public interface IPasajeroRepository : IRepository<Pasajero, Guid>
    {
        Task UpdateAsync(Pasajero obj);
    }
}
