
namespace WolvenKit.RED4.Types
{
	public partial class inkBoolCallback : inkCallbackBase
	{
		public inkBoolCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
