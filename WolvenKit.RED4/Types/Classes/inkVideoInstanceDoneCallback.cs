
namespace WolvenKit.RED4.Types
{
	public partial class inkVideoInstanceDoneCallback : inkCallbackBase
	{
		public inkVideoInstanceDoneCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
