
namespace WolvenKit.RED4.Types
{
	public partial class inkRadioGroupChangedCallback : inkCallbackBase
	{
		public inkRadioGroupChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
