using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AimAssistSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)]  [RED("aimAssistLevel")] public CEnum<EAimAssistLevel> AimAssistLevel { get; set; }
		[Ordinal(1)]  [RED("aimAssistMeleeLevel")] public CEnum<EAimAssistLevel> AimAssistMeleeLevel { get; set; }
		[Ordinal(2)]  [RED("ctrl")] public wCHandle<PlayerPuppet> Ctrl { get; set; }
		[Ordinal(3)]  [RED("currentConfigString")] public CString CurrentConfigString { get; set; }
		[Ordinal(4)]  [RED("settings")] public CHandle<userSettingsUserSettings> Settings { get; set; }
		[Ordinal(5)]  [RED("settingsGroup")] public CHandle<userSettingsGroup> SettingsGroup { get; set; }
		[Ordinal(6)]  [RED("settingsRecord")] public CHandle<gamedataAimAssistSettings_Record> SettingsRecord { get; set; }

		public AimAssistSettingsListener(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
