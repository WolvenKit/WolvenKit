using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModioConfirmUninstallPopupEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("data")] 
		public CHandle<ModioConfirmUninstallData> Data
		{
			get => GetPropertyValue<CHandle<ModioConfirmUninstallData>>();
			set => SetPropertyValue<CHandle<ModioConfirmUninstallData>>(value);
		}

		public ModioConfirmUninstallPopupEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
