
namespace WolvenKit.RED4.Types
{
	public partial class inkToggleChangedCallback : inkCallbackBase
	{
		public inkToggleChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
