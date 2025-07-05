
namespace WolvenKit.RED4.Types
{
	public partial class inkVector2Callback : inkCallbackBase
	{
		public inkVector2Callback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
