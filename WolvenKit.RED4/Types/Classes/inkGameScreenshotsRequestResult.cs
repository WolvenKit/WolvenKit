
namespace WolvenKit.RED4.Types
{
	public partial class inkGameScreenshotsRequestResult : inkCallbackBase
	{
		public inkGameScreenshotsRequestResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
