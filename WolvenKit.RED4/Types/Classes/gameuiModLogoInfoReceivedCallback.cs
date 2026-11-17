
namespace WolvenKit.RED4.Types
{
	public partial class gameuiModLogoInfoReceivedCallback : inkCallbackBase
	{
		public gameuiModLogoInfoReceivedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
