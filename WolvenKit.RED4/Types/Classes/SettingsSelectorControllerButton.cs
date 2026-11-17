using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SettingsSelectorControllerButton : inkSettingsSelectorController
	{
		[Ordinal(17)] 
		[RED("buttonBody")] 
		public inkWidgetReference ButtonBody
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(18)] 
		[RED("buttonText")] 
		public inkTextWidgetReference ButtonText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(19)] 
		[RED("settingsButtonType")] 
		public CName SettingsButtonType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("userSettings")] 
		public CWeakHandle<userSettingsUserSettings> UserSettings
		{
			get => GetPropertyValue<CWeakHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CWeakHandle<userSettingsUserSettings>>(value);
		}

		public SettingsSelectorControllerButton()
		{
			ButtonBody = new inkWidgetReference();
			ButtonText = new inkTextWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
