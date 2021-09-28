using System;
using System.Diagnostics.CodeAnalysis;

namespace TDDExample.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class AmountExceedException : Exception
    {
        public AmountExceedException()
        {
        }

        public AmountExceedException(string message)
            : base(message)
        {
        }

        public AmountExceedException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
