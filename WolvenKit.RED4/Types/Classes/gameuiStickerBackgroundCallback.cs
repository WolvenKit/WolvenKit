
namespace WolvenKit.RED4.Types
{
	public partial class gameuiStickerBackgroundCallback : inkCallbackBase
	{
		public gameuiStickerBackgroundCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
