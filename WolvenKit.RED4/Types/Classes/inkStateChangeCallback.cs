
namespace WolvenKit.RED4.Types
{
	public partial class inkStateChangeCallback : inkCallbackBase
	{
		public inkStateChangeCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
