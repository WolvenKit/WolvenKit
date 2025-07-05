
namespace WolvenKit.RED4.Types
{
	public partial class inkCharacterEventCallback : inkCallbackBase
	{
		public inkCharacterEventCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
