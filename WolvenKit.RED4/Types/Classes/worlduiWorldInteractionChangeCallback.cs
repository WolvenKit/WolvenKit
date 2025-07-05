
namespace WolvenKit.RED4.Types
{
	public partial class worlduiWorldInteractionChangeCallback : inkCallbackBase
	{
		public worlduiWorldInteractionChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
