using ShareKernel.Core;
using ShareKernel.ValueObjects;
using System;

namespace Reservas.Domain.Model.Pasajeros
{
    public class Pasajero : AggregateRoot<Guid>
    {
        public string Ci { get; set; }
        public PasajeroNameValue NombreCompleto { get; set; }

        public Pasajero(string ci,string nombreCompleto)
        {
            Id = Guid.NewGuid();
            Ci = ci;
            NombreCompleto = nombreCompleto;
        }
    }
}
