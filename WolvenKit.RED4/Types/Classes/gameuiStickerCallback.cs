
namespace WolvenKit.RED4.Types
{
	public partial class gameuiStickerCallback : inkCallbackBase
	{
		public gameuiStickerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
