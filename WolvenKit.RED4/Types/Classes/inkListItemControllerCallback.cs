
namespace WolvenKit.RED4.Types
{
	public partial class inkListItemControllerCallback : inkCallbackBase
	{
		public inkListItemControllerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
