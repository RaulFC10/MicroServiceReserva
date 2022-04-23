using Reservas.Domain.Repositories;
using System.Threading.Tasks;

namespace Reservas.Infraestructure.EF
{
    public class UnitOfWork : IUnitOfWork
    {
        public Task Commit()
        {
            return Task.CompletedTask;
        }
    }
}
