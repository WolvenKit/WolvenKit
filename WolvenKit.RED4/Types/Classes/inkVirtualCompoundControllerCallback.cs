
namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualCompoundControllerCallback : inkCallbackBase
	{
		public inkVirtualCompoundControllerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
