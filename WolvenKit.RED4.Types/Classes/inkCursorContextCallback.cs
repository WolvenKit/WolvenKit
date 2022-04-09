
namespace WolvenKit.RED4.Types
{
	public partial class inkCursorContextCallback : inkCallbackBase
	{
		public inkCursorContextCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
