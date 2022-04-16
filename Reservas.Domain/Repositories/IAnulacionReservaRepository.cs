using Reservas.Domain.Model.Anulacion;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Repositories
{
    public interface IAnulacionReservaRepository : IRepository<AnulacionReserva, Guid>
    {
    }
}
