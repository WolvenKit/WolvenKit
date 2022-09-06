
namespace WolvenKit.RED4.Types
{
	public partial class inkOnGogLoginStatusChangedResult : inkCallbackBase
	{
		public inkOnGogLoginStatusChangedResult()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
