
namespace WolvenKit.RED4.Types
{
	public partial class ModReloadingPopupEvent : redEvent
	{
		public ModReloadingPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
