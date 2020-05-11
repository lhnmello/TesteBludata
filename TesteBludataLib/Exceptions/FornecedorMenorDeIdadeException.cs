using System;
using System.Runtime.Serialization;

namespace TesteBludataLib.Exceptions
{
    [Serializable]
    internal class FornecedorMenorDeIdadeException : Exception
    {
        public FornecedorMenorDeIdadeException()
        {
        }

        public FornecedorMenorDeIdadeException(string message) : base(message)
        {
        }

        public FornecedorMenorDeIdadeException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected FornecedorMenorDeIdadeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}