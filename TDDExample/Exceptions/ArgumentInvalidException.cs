using System;
using System.Diagnostics.CodeAnalysis;

namespace TDDExample.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class ArgumentInvalidException : Exception
    {
        public ArgumentInvalidException(string message)
            : base(message)
        {
        }
    }
}
