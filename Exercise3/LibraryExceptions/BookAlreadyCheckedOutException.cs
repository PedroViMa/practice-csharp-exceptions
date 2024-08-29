using System;
using System.Runtime.Serialization;

namespace Exercise3.LibraryExceptions
{
    internal class BookAlreadyCheckedOutException : Exception
    {
        protected BookAlreadyCheckedOutException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

        public BookAlreadyCheckedOutException()
        {
        }

        public BookAlreadyCheckedOutException(string message)
            : base(message)
        {
        }

        public BookAlreadyCheckedOutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
