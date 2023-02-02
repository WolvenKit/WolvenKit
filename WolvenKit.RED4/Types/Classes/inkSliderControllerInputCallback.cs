
namespace WolvenKit.RED4.Types
{
	public partial class inkSliderControllerInputCallback : inkCallbackBase
	{
		public inkSliderControllerInputCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
