
namespace WolvenKit.RED4.Types
{
	public partial class gameuiRequestMediaForWidgetCallback : inkCallbackBase
	{
		public gameuiRequestMediaForWidgetCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
