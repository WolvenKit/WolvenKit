
namespace WolvenKit.RED4.Types
{
	public partial class gameuiChangeAspectRatioCallback : inkCallbackBase
	{
		public gameuiChangeAspectRatioCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
