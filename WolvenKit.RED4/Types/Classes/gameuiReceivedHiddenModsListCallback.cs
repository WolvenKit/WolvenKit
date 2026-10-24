
namespace WolvenKit.RED4.Types
{
	public partial class gameuiReceivedHiddenModsListCallback : inkCallbackBase
	{
		public gameuiReceivedHiddenModsListCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
