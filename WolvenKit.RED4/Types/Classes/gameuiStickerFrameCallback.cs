
namespace WolvenKit.RED4.Types
{
	public partial class gameuiStickerFrameCallback : inkCallbackBase
	{
		public gameuiStickerFrameCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
