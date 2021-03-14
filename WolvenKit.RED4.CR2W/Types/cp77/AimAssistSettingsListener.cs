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
			get
			{
				if (_ctrl == null)
				{
					_ctrl = (wCHandle<PlayerPuppet>) CR2WTypeManager.Create("whandle:PlayerPuppet", "ctrl", cr2w, this);
				}
				return _ctrl;
			}
			set
			{
				if (_ctrl == value)
				{
					return;
				}
				_ctrl = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get
			{
				if (_settings == null)
				{
					_settings = (CHandle<userSettingsUserSettings>) CR2WTypeManager.Create("handle:userSettingsUserSettings", "settings", cr2w, this);
				}
				return _settings;
			}
			set
			{
				if (_settings == value)
				{
					return;
				}
				_settings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("settingsGroup")] 
		public CHandle<userSettingsGroup> SettingsGroup
		{
			get
			{
				if (_settingsGroup == null)
				{
					_settingsGroup = (CHandle<userSettingsGroup>) CR2WTypeManager.Create("handle:userSettingsGroup", "settingsGroup", cr2w, this);
				}
				return _settingsGroup;
			}
			set
			{
				if (_settingsGroup == value)
				{
					return;
				}
				_settingsGroup = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("aimAssistLevel")] 
		public CEnum<EAimAssistLevel> AimAssistLevel
		{
			get
			{
				if (_aimAssistLevel == null)
				{
					_aimAssistLevel = (CEnum<EAimAssistLevel>) CR2WTypeManager.Create("EAimAssistLevel", "aimAssistLevel", cr2w, this);
				}
				return _aimAssistLevel;
			}
			set
			{
				if (_aimAssistLevel == value)
				{
					return;
				}
				_aimAssistLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("aimAssistMeleeLevel")] 
		public CEnum<EAimAssistLevel> AimAssistMeleeLevel
		{
			get
			{
				if (_aimAssistMeleeLevel == null)
				{
					_aimAssistMeleeLevel = (CEnum<EAimAssistLevel>) CR2WTypeManager.Create("EAimAssistLevel", "aimAssistMeleeLevel", cr2w, this);
				}
				return _aimAssistMeleeLevel;
			}
			set
			{
				if (_aimAssistMeleeLevel == value)
				{
					return;
				}
				_aimAssistMeleeLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("currentConfigString")] 
		public CString CurrentConfigString
		{
			get
			{
				if (_currentConfigString == null)
				{
					_currentConfigString = (CString) CR2WTypeManager.Create("String", "currentConfigString", cr2w, this);
				}
				return _currentConfigString;
			}
			set
			{
				if (_currentConfigString == value)
				{
					return;
				}
				_currentConfigString = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("settingsRecord")] 
		public CHandle<gamedataAimAssistSettings_Record> SettingsRecord
		{
			get
			{
				if (_settingsRecord == null)
				{
					_settingsRecord = (CHandle<gamedataAimAssistSettings_Record>) CR2WTypeManager.Create("handle:gamedataAimAssistSettings_Record", "settingsRecord", cr2w, this);
				}
				return _settingsRecord;
			}
			set
			{
				if (_settingsRecord == value)
				{
					return;
				}
				_settingsRecord = value;
				PropertySet(this);
			}
		}

		public AimAssistSettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
