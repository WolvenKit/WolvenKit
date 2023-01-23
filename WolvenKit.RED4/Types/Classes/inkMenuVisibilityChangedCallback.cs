
namespace WolvenKit.RED4.Types
{
	public partial class inkMenuVisibilityChangedCallback : inkCallbackBase
	{
		public inkMenuVisibilityChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
