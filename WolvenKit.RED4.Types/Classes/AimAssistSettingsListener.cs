using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("currentConfigString")] 
		public CString CurrentConfigString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("settingsRecord")] 
		public CHandle<gamedataAimAssistSettings_Record> SettingsRecord
		{
			get => GetPropertyValue<CHandle<gamedataAimAssistSettings_Record>>();
			set => SetPropertyValue<CHandle<gamedataAimAssistSettings_Record>>(value);
		}
	}
}
