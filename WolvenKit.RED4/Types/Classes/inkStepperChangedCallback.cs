
namespace WolvenKit.RED4.Types
{
	public partial class inkStepperChangedCallback : inkCallbackBase
	{
		public inkStepperChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
