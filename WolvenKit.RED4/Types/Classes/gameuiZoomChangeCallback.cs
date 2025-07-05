
namespace WolvenKit.RED4.Types
{
	public partial class gameuiZoomChangeCallback : inkCallbackBase
	{
		public gameuiZoomChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
