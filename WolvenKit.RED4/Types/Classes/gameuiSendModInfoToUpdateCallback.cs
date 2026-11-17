
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSendModInfoToUpdateCallback : inkCallbackBase
	{
		public gameuiSendModInfoToUpdateCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
