
namespace WolvenKit.RED4.Types
{
	public partial class inkSliderControllerValueChangeCallback : inkCallbackBase
	{
		public inkSliderControllerValueChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
