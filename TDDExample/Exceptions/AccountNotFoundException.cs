using System;
using System.Diagnostics.CodeAnalysis;

namespace TDDExample.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException()
        {
        }

        public AccountNotFoundException(string message)
            : base(message)
        {
        }

        public AccountNotFoundException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
