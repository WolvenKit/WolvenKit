
namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnCollideCallbackAdvanced : inkCallbackBase
	{
		public gameuiOnCollideCallbackAdvanced()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
