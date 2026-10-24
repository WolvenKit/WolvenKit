
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSendModGridInfoCallback : inkCallbackBase
	{
		public gameuiSendModGridInfoCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
