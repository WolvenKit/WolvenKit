
namespace WolvenKit.RED4.Types
{
	public partial class inkButtonSelectionCallback : inkCallbackBase
	{
		public inkButtonSelectionCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
