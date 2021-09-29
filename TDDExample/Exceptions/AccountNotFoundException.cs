using System;
using System.Diagnostics.CodeAnalysis;

namespace TDDExample.Exceptions
{
    [ExcludeFromCodeCoverage]
    public class AccountNotFoundException : Exception
    {
        public AccountNotFoundException(string message)
            : base(message)
        {
        }
    }
}
