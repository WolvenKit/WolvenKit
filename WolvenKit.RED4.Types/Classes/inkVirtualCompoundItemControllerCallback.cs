
namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualCompoundItemControllerCallback : inkCallbackBase
	{
		public inkVirtualCompoundItemControllerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
