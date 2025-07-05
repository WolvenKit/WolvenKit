
namespace WolvenKit.RED4.Types
{
	public partial class gameuiOnHitCallback : inkCallbackBase
	{
		public gameuiOnHitCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
