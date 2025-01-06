using Xunit;

namespace TestHelper
{
	public abstract class UnitTest
	{
		protected ITestOutputHelper Logger { get; }

		protected UnitTest(ITestOutputHelper logger)
		{
			Logger = logger;
		}
	}
}
