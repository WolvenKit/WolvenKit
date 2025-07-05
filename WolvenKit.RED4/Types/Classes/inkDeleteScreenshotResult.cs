
namespace WolvenKit.RED4.Types
{
	public partial class inkDeleteScreenshotResult : inkCallbackBase
	{
		public inkDeleteScreenshotResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
