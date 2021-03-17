using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AimAssistSettingsListener : userSettingsVarListener
	{
		private wCHandle<PlayerPuppet> _ctrl;
		private CHandle<userSettingsUserSettings> _settings;
		private CHandle<userSettingsGroup> _settingsGroup;
		private CEnum<EAimAssistLevel> _aimAssistLevel;
		private CEnum<EAimAssistLevel> _aimAssistMeleeLevel;
		private CString _currentConfigString;
		private CHandle<gamedataAimAssistSettings_Record> _settingsRecord;

		[Ordinal(0)] 
		[RED("ctrl")] 
		public wCHandle<PlayerPuppet> Ctrl
		{
			get => GetProperty(ref _ctrl);
			set => SetProperty(ref _ctrl, value);
		}

		[Ordinal(1)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(2)] 
		[RED("settingsGroup")] 
		public CHandle<userSettingsGroup> SettingsGroup
		{
			get => GetProperty(ref _settingsGroup);
			set => SetProperty(ref _settingsGroup, value);
		}

		[Ordinal(3)] 
		[RED("aimAssistLevel")] 
		public CEnum<EAimAssistLevel> AimAssistLevel
		{
			get => GetProperty(ref _aimAssistLevel);
			set => SetProperty(ref _aimAssistLevel, value);
		}

		[Ordinal(4)] 
		[RED("aimAssistMeleeLevel")] 
		public CEnum<EAimAssistLevel> AimAssistMeleeLevel
		{
			get => GetProperty(ref _aimAssistMeleeLevel);
			set => SetProperty(ref _aimAssistMeleeLevel, value);
		}

		[Ordinal(5)] 
		[RED("currentConfigString")] 
		public CString CurrentConfigString
		{
			get => GetProperty(ref _currentConfigString);
			set => SetProperty(ref _currentConfigString, value);
		}

		[Ordinal(6)] 
		[RED("settingsRecord")] 
		public CHandle<gamedataAimAssistSettings_Record> SettingsRecord
		{
			get => GetProperty(ref _settingsRecord);
			set => SetProperty(ref _settingsRecord, value);
		}

		public AimAssistSettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
