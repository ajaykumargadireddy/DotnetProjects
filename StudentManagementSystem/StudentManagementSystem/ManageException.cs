using System;
using System.Runtime.Serialization;

namespace StudentManagementSystem
{
    public class ManageException : Exception
    {
        public ManageException()
        {
        }

        public ManageException(string message) : base(message)
        {
        }

        public ManageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected ManageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}