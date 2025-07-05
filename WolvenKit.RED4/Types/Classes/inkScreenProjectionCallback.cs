
namespace WolvenKit.RED4.Types
{
	public partial class inkScreenProjectionCallback : inkCallbackBase
	{
		public inkScreenProjectionCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
