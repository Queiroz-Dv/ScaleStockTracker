using System;
using System.Text.RegularExpressions;

namespace ScaleStockTracker.Models.ValueObjects
{
    public class Email
    {
        private readonly string _value;

        public Email(string value)
        {
            if (string.IsNullOrWhiteSpace(value))
            {
                throw new ArgumentException("O endereço de e-mail não pode ser vazio.", nameof(value));
            }

            // Expressão regular para validar o formato do e-mail
            var regex = new Regex(@"^[^@\s]+@[^@\s]+\.[^@\s]+$");

            if (!regex.IsMatch(value))
            {
                throw new ArgumentException("O endereço de e-mail informado é inválido.", nameof(value));
            }

            _value = value;
        }

        public override string ToString() => _value;

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Email))
            {
                return false;
            }

            return ((Email)obj)._value == _value;
        }

        public override int GetHashCode() => _value.GetHashCode();
    }
}