using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AimAssistSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<PlayerPuppet> Ctrl
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
		[RED("aimAssistLevel")] 
		public CEnum<EAimAssistLevel> AimAssistLevel
		{
			get => GetPropertyValue<CEnum<EAimAssistLevel>>();
			set => SetPropertyValue<CEnum<EAimAssistLevel>>(value);
		}

		[Ordinal(4)] 
		[RED("aimAssistMeleeLevel")] 
		public CEnum<EAimAssistLevel> AimAssistMeleeLevel
		{
			get => GetPropertyValue<CEnum<EAimAssistLevel>>();
			set => SetPropertyValue<CEnum<EAimAssistLevel>>(value);
		}

		[Ordinal(5)] 
		[RED("aimAssistDriverCombatEnabled")] 
		public CBool AimAssistDriverCombatEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("aimAssistSnapEnabled")] 
		public CBool AimAssistSnapEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("currentConfig")] 
		public CEnum<AimAssistSettingConfig> CurrentConfig
		{
			get => GetPropertyValue<CEnum<AimAssistSettingConfig>>();
			set => SetPropertyValue<CEnum<AimAssistSettingConfig>>(value);
		}

		[Ordinal(8)] 
		[RED("settingsRecords")] 
		public CArray<CWeakHandle<gamedataAimAssistSettings_Record>> SettingsRecords
		{
			get => GetPropertyValue<CArray<CWeakHandle<gamedataAimAssistSettings_Record>>>();
			set => SetPropertyValue<CArray<CWeakHandle<gamedataAimAssistSettings_Record>>>(value);
		}

		public AimAssistSettingsListener()
		{
			SettingsRecords = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
