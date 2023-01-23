
namespace WolvenKit.RED4.Types
{
	public partial class inkSliderControllerHandleReleasedCallback : inkCallbackBase
	{
		public inkSliderControllerHandleReleasedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
