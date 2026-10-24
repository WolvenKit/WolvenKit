
namespace WolvenKit.RED4.Types
{
	public partial class gameuiMenuIntIntCallback : inkCallbackBase
	{
		public gameuiMenuIntIntCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
