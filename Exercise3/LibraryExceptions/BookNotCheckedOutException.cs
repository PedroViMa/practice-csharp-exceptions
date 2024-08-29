using System;
using System.Runtime.Serialization;

namespace Exercise3.LibraryExceptions
{
    [Serializable]
    internal class BookNotCheckedOutException : Exception
    {
        protected BookNotCheckedOutException(
            SerializationInfo info,
            StreamingContext context) : base(info, context)
        {
        }

        public BookNotCheckedOutException()
        {
        }

        public BookNotCheckedOutException(string message)
            : base(message)
        {
        }

        public BookNotCheckedOutException(string message, Exception innerException)
            : base(message, innerException)
        {
        }
    }
}
