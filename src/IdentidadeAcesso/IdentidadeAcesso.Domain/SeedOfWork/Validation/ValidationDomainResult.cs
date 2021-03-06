﻿using System.Collections.Generic;
using System.Linq;

namespace IdentidadeAcesso.Domain.SeedOfWork.Validation
{
    public sealed class ValidationDomainResult
    {
        private List<ValidationError> _erros;
        public IReadOnlyList<ValidationError> Erros => _erros;

        public bool IsValid
        {
            get
            {
                return !_erros.Any();
            }
        }

        public ValidationDomainResult()
        {
            _erros = new List<ValidationError>();
        }

        public void AddError(string property, string message)
        {
            _erros.Add(new ValidationError(property, message));
        }
    }

    public class ValidationError
    {
        public ValidationError(string property, string messageError)
        {
            Property = property;
            MessageError = messageError;
        }

        public string Property { get; private set; }
        public string MessageError { get; private set; }

        public override bool Equals(object other)
        {
            var compareTo = other as ValidationError;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return compareTo.Property == Property && compareTo.MessageError == MessageError;
        }


        public static bool operator ==(ValidationError a, ValidationError b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null))
                return true;

            if (ReferenceEquals(a, null) || ReferenceEquals(b, null))
                return false;

            return a.Equals(b);
        }

        public static bool operator !=(ValidationError a, ValidationError b)
        {
            return !(a == b);
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hashCode = MessageError.GetHashCode();
                hashCode += (Property.GetHashCode() * 907) ^ Property.GetHashCode();

                return hashCode;
            }
        }
    }
}