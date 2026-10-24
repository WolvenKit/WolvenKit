
namespace WolvenKit.RED4.Types
{
	public partial class gameuiMenuIntCallback : inkCallbackBase
	{
		public gameuiMenuIntCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
