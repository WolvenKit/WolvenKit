
namespace WolvenKit.RED4.Types
{
	public partial class gameuiSendModUpdateVerificationInfo : inkCallbackBase
	{
		public gameuiSendModUpdateVerificationInfo()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
