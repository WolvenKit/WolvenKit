using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DoorControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(0)]  [RED("alarmRaised")] public CBool AlarmRaised { get; set; }
		[Ordinal(1)]  [RED("doorProperties")] public DoorSetup DoorProperties { get; set; }
		[Ordinal(2)]  [RED("doorSkillChecks")] public CHandle<EngDemoContainer> DoorSkillChecks { get; set; }
		[Ordinal(3)]  [RED("isBusy")] public CBool IsBusy { get; set; }
		[Ordinal(4)]  [RED("isLiftDoor")] public CBool IsLiftDoor { get; set; }
		[Ordinal(5)]  [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(6)]  [RED("isOpened")] public CBool IsOpened { get; set; }
		[Ordinal(7)]  [RED("isPlayerAuthorised")] public CBool IsPlayerAuthorised { get; set; }
		[Ordinal(8)]  [RED("isSealed")] public CBool IsSealed { get; set; }
		[Ordinal(9)]  [RED("openingTokens")] public CArray<entEntityID> OpeningTokens { get; set; }

		public DoorControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
