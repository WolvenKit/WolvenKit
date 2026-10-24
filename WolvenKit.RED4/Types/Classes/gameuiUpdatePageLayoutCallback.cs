
namespace WolvenKit.RED4.Types
{
	public partial class gameuiUpdatePageLayoutCallback : inkCallbackBase
	{
		public gameuiUpdatePageLayoutCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
