using Aspose.Slides;

namespace TestProject1
{
	public class UnitTest1 : IDisposable
	{
		private readonly IPresentation _presentation;

		public UnitTest1()
		{
			_presentation = new Aspose.Slides.Presentation();
		}

		[Fact]
		public void Test1()
		{
			Assert.Equal(1, 1);
		}

		[Fact]
		public void Test_for_Aspose()
		{
			Assert.Equal(1, 1);
		}

		public void Dispose() => _presentation.Dispose();

	}
}