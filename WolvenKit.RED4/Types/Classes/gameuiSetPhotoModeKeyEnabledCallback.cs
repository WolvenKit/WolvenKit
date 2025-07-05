
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSetPhotoModeKeyEnabledCallback : inkCallbackBase
	{
		public gameuiSetPhotoModeKeyEnabledCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
