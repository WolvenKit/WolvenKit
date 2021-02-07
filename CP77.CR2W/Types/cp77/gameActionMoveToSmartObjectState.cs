using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToSmartObjectState : gameActionMoveToState
	{
		[Ordinal(0)]  [RED("targetHash")] public CUInt64 TargetHash { get; set; }
		[Ordinal(1)]  [RED("usePathfinding")] public CBool UsePathfinding { get; set; }
		[Ordinal(2)]  [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(3)]  [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(4)]  [RED("entryType")] public CEnum<gameSmartObjectInstanceEntryType> EntryType { get; set; }
		[Ordinal(5)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(6)]  [RED("strafingTarget")] public wCHandle<gameObject> StrafingTarget { get; set; }
		[Ordinal(7)]  [RED("entryDirection")] public Vector3 EntryDirection { get; set; }
		[Ordinal(8)]  [RED("entryPointPos")] public Vector3 EntryPointPos { get; set; }
		[Ordinal(9)]  [RED("entryPointDir")] public Vector4 EntryPointDir { get; set; }
		[Ordinal(10)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(11)]  [RED("isInSmartObject")] public CBool IsInSmartObject { get; set; }

		public gameActionMoveToSmartObjectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
