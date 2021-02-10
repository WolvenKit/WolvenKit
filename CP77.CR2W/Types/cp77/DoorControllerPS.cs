using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(103)]  [RED("doorProperties")] public DoorSetup DoorProperties { get; set; }
		[Ordinal(104)]  [RED("doorSkillChecks")] public CHandle<EngDemoContainer> DoorSkillChecks { get; set; }
		[Ordinal(105)]  [RED("isOpened")] public CBool IsOpened { get; set; }
		[Ordinal(106)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(107)]  [RED("isSealed")] public CBool IsSealed { get; set; }
		[Ordinal(108)]  [RED("alarmRaised")] public CBool AlarmRaised { get; set; }
		[Ordinal(109)]  [RED("isBusy")] public CBool IsBusy { get; set; }
		[Ordinal(110)]  [RED("isLiftDoor")] public CBool IsLiftDoor { get; set; }
		[Ordinal(111)]  [RED("isPlayerAuthorised")] public CBool IsPlayerAuthorised { get; set; }
		[Ordinal(112)]  [RED("openingTokens")] public CArray<entEntityID> OpeningTokens { get; set; }

		public DoorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
