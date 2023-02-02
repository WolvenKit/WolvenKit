
namespace WolvenKit.RED4.Types
{
	public partial class gameuiStickerImageCallback : inkCallbackBase
	{
		public gameuiStickerImageCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
