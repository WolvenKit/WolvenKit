
namespace WolvenKit.RED4.Types
{
	public partial class gameuiZoomLevelChangeCallback : inkCallbackBase
	{
		public gameuiZoomLevelChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
