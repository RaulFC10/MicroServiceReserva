using Reservas.Domain.Model.Checkins;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Repositories
{
    public interface ICheckInRepository : IRepository<Checkin, Guid>
    {
    }
}
