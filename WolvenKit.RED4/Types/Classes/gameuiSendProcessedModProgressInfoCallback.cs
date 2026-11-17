
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSendProcessedModProgressInfoCallback : inkCallbackBase
	{
		public gameuiSendProcessedModProgressInfoCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
