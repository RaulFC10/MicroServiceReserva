using Reservas.Domain.Model.Facturas;
using ShareKernel.Core;
using System;

namespace Reservas.Domain.Repositories
{
    public interface IFacturaRepository : IRepository<Factura, Guid>
    {
    }
}
