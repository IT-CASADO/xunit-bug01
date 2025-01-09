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

		public ValueTask InitializeAsync()
		{
			_testOutputHelper.WriteLine("InitializeAsync");
			return ValueTask.CompletedTask;
		}

		public ValueTask DisposeAsync()
		{
			_testOutputHelper.WriteLine("DisposeAsync");
			return ValueTask.CompletedTask;
		}

		public void Dispose()
		{
			_testOutputHelper.WriteLine("Dispose");
		}
	}
}