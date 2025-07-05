
namespace WolvenKit.RED4.Types
{
	public partial class inkCustomCallback : inkCallbackBase
	{
		public inkCustomCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
