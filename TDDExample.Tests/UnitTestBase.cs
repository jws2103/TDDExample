using System.Globalization;
using Moq.AutoMock;

namespace TDDExample.Tests
{
    public abstract class UnitTestBase<T> where T : class
    {
        protected UnitTestBase()
        {
            Sut = Mocker.CreateInstance<T>();
            CultureInfo.CurrentCulture = new CultureInfo("en-AU");
            Mocker = new AutoMocker();
        }

        protected AutoMocker Mocker { get; }    // Mocker

        protected T Sut { get; }    // System under test
    }
}
