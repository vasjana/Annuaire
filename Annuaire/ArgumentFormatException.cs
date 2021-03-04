using System;
using System.Runtime.Serialization;

namespace Annuaire
{
    [Serializable]
    internal class ArgumentFormatException : Exception
    {
        public ArgumentFormatException()
        {
        }

        public ArgumentFormatException(string message) : base(message)
        {
        }

        public ArgumentFormatException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ArgumentFormatException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}