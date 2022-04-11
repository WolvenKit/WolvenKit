
namespace WolvenKit.RED4.Types
{
	public partial class inkListControllerCallback : inkCallbackBase
	{
		public inkListControllerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
