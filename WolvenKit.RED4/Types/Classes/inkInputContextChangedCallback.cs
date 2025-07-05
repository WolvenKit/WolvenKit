
namespace WolvenKit.RED4.Types
{
	public partial class inkInputContextChangedCallback : inkCallbackBase
	{
		public inkInputContextChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
