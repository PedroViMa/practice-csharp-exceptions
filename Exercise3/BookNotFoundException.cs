using System;
using System.Runtime.Serialization;

namespace Exercise3
{
    internal class BookNotFoundException : Exception
    {
        protected BookNotFoundException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {

        }
        public BookNotFoundException()
        {
        }

        public BookNotFoundException(string message)
            : base(message)
        {
        }

        public BookNotFoundException(string message, Exception innerException)
            : base(message, innerException)
        {

        }
    }
}
