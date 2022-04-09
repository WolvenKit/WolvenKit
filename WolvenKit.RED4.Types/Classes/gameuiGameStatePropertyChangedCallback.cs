
namespace WolvenKit.RED4.Types
{
	public partial class gameuiGameStatePropertyChangedCallback : inkCallbackBase
	{
		public gameuiGameStatePropertyChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
