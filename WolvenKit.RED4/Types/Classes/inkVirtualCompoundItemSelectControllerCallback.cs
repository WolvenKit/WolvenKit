
namespace WolvenKit.RED4.Types
{
	public partial class inkVirtualCompoundItemSelectControllerCallback : inkCallbackBase
	{
		public inkVirtualCompoundItemSelectControllerCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
