
namespace WolvenKit.RED4.Types
{
	public partial class gameuiLoadUISendModInfoToUpdateCallback : inkCallbackBase
	{
		public gameuiLoadUISendModInfoToUpdateCallback()
		{
			CallbackName = "";
			Listeners = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
