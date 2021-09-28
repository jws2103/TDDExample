using System.Diagnostics;

namespace TDDExample
{
    [ExcludeFromCoverage]
    public class Logger : ILogger
    {
        public void Log(string exception)
        {
            Debug.WriteLine(exception);
        }
    }
}
