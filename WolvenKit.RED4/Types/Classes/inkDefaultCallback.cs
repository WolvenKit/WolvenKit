
namespace WolvenKit.RED4.Types
{
	public partial class inkDefaultCallback : inkCallbackBase
	{
		public inkDefaultCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
