
namespace WolvenKit.RED4.Types
{
	public partial class inkComboBoxVisibleChangedCallback : inkCallbackBase
	{
		public inkComboBoxVisibleChangedCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
