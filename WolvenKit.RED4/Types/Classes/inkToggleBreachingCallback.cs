
namespace WolvenKit.RED4.Types
{
	public partial class inkToggleBreachingCallback : inkCallbackBase
	{
		public inkToggleBreachingCallback()
		{
			CallbackName = "ToggleBreachingCallback";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
