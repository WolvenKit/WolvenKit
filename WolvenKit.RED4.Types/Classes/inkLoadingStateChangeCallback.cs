
namespace WolvenKit.RED4.Types
{
	public partial class inkLoadingStateChangeCallback : inkCallbackBase
	{
		public inkLoadingStateChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
