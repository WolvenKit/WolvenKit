
namespace WolvenKit.RED4.Types
{
	public partial class gameuiNpcImageCallback : inkCallbackBase
	{
		public gameuiNpcImageCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
