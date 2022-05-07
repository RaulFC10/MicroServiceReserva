using ShareKernel.Core;
using ShareKernel.Rules;

namespace ShareKernel.ValueObjects
{
    public record PasajeroNameValue : ValueObject
    {
        public string Name { get; }

        public PasajeroNameValue(string name)
        {
            CheckRule(new StringNotNullOrEmptyRule(name));
            if (name.Length > 100)
            {
                throw new BussinessRuleValidationException("El Pasajero no puede tener más de 100 caracteres");
            }
            Name = name;
        }

        public static implicit operator string(PasajeroNameValue value)
        {
            return value.Name;
        }

        public static implicit operator PasajeroNameValue(string name)
        {
            return new PasajeroNameValue(name);
        }
    }
}
