
namespace WolvenKit.RED4.Types
{
	public partial class inkButtonStateChangeCallback : inkCallbackBase
	{
		public inkButtonStateChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
