using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DlcMenuGameController : gameuiMenuGameController
	{
		[Ordinal(3)] 
		[RED("buttonHintsRef")] 
		public inkWidgetReference ButtonHintsRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("containersRef")] 
		public inkCompoundWidgetReference ContainersRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(6)] 
		[RED("dlcSettingsGroup")] 
		public CHandle<userSettingsGroup> DlcSettingsGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		public DlcMenuGameController()
		{
			ButtonHintsRef = new inkWidgetReference();
			ContainersRef = new inkCompoundWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
