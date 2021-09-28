using System;
using System.Diagnostics.CodeAnalysis;

namespace TDDExample.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class ArgumentInvalidException : Exception
    {
        public ArgumentInvalidException()
        {
        }

        public ArgumentInvalidException(string message)
            : base(message)
        {
        }

        public ArgumentInvalidException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
