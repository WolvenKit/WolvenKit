
namespace WolvenKit.RED4.Types
{
	public partial class inkSelectionChangeCallback : inkCallbackBase
	{
		public inkSelectionChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
