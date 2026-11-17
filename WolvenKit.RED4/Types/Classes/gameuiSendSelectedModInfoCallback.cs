
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSendSelectedModInfoCallback : inkCallbackBase
	{
		public gameuiSendSelectedModInfoCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
