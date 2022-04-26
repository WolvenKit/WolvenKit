
namespace WolvenKit.RED4.Types
{
	public partial class inkFocusEventCallback : inkCallbackBase
	{
		public inkFocusEventCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
