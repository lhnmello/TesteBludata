using System;
using System.Runtime.Serialization;

namespace TesteBludataLib.Exceptions
{
    [Serializable]
    internal class CampoVazioException : Exception
    {
        public CampoVazioException()
        {
        }

        public CampoVazioException(string message) : base(message)
        {
            
        }

        public CampoVazioException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected CampoVazioException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}