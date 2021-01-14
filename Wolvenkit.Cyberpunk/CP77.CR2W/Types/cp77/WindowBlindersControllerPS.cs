using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("alarmRaised")] public CBool AlarmRaised { get; set; }
		[Ordinal(1)]  [RED("cachedState")] public CEnum<EWindowBlindersStates> CachedState { get; set; }
		[Ordinal(2)]  [RED("windowBlindersData")] public WindowBlindersData WindowBlindersData { get; set; }
		[Ordinal(3)]  [RED("windowBlindersSkillChecks")] public CHandle<EngDemoContainer> WindowBlindersSkillChecks { get; set; }

		public WindowBlindersControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
