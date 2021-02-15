using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class WindowBlindersControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)] [RED("windowBlindersSkillChecks")] public CHandle<EngDemoContainer> WindowBlindersSkillChecks { get; set; }
		[Ordinal(104)] [RED("windowBlindersData")] public WindowBlindersData WindowBlindersData { get; set; }
		[Ordinal(105)] [RED("cachedState")] public CEnum<EWindowBlindersStates> CachedState { get; set; }
		[Ordinal(106)] [RED("alarmRaised")] public CBool AlarmRaised { get; set; }

		public WindowBlindersControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
