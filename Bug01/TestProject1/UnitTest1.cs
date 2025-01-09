using Xunit.Abstractions;

namespace TestProject1
{
	public class UnitTest1 : IAsyncLifetime, IDisposable
	{
		private readonly ITestOutputHelper _testOutputHelper;

		public UnitTest1(ITestOutputHelper testOutputHelper)
		{
			_testOutputHelper = testOutputHelper;
		}

		[Fact]
		public void Test1()
		{
			Assert.Equal(1, 1);
		}

		public Task InitializeAsync()
		{
			_testOutputHelper.WriteLine("InitializeAsync");

			throw new Exception();

			return Task.CompletedTask;
		}

		public Task DisposeAsync()
		{
			_testOutputHelper.WriteLine("DisposeAsync");
			return Task.CompletedTask;
		}

		public void Dispose()
		{
			_testOutputHelper.WriteLine("Dispose");
		}
	}
}