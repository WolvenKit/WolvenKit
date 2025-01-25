
namespace WolvenKit.RED4.Types
{
	public partial class inkGameScreenshotCallback : inkCallbackBase
	{
		public inkGameScreenshotCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
