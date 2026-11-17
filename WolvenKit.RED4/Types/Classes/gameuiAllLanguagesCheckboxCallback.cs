
namespace WolvenKit.RED4.Types
{
	public partial class gameuiAllLanguagesCheckboxCallback : inkCallbackBase
	{
		public gameuiAllLanguagesCheckboxCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
