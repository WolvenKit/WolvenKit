using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RadioportSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("player")] 
		public CWeakHandle<PlayerPuppet> Player
		{
			get => GetPropertyValue<CWeakHandle<PlayerPuppet>>();
			set => SetPropertyValue<CWeakHandle<PlayerPuppet>>(value);
		}

		[Ordinal(1)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(2)] 
		[RED("settingsGroup")] 
		public CHandle<userSettingsGroup> SettingsGroup
		{
			get => GetPropertyValue<CHandle<userSettingsGroup>>();
			set => SetPropertyValue<CHandle<userSettingsGroup>>(value);
		}

		[Ordinal(3)] 
		[RED("syncToCarRadio")] 
		public CBool SyncToCarRadio
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("cycleOnButtonPress")] 
		public CBool CycleOnButtonPress
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("saveStation")] 
		public CBool SaveStation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("syncToCarRadioName")] 
		public CName SyncToCarRadioName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("cycleOnButtonPressName")] 
		public CName CycleOnButtonPressName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("saveStationName")] 
		public CName SaveStationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("radioportSettingsPath")] 
		public CName RadioportSettingsPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public RadioportSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
