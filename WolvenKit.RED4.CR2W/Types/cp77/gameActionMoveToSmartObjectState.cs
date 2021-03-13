using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameActionMoveToSmartObjectState : gameActionMoveToState
	{
		[Ordinal(9)] [RED("targetHash")] public CUInt64 TargetHash { get; set; }
		[Ordinal(10)] [RED("usePathfinding")] public CBool UsePathfinding { get; set; }
		[Ordinal(11)] [RED("useStart")] public CBool UseStart { get; set; }
		[Ordinal(12)] [RED("useStop")] public CBool UseStop { get; set; }
		[Ordinal(13)] [RED("entryType")] public CEnum<gameSmartObjectInstanceEntryType> EntryType { get; set; }
		[Ordinal(14)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(15)] [RED("strafingTarget")] public wCHandle<gameObject> StrafingTarget { get; set; }
		[Ordinal(16)] [RED("entryDirection")] public Vector3 EntryDirection { get; set; }
		[Ordinal(17)] [RED("entryPointPos")] public Vector3 EntryPointPos { get; set; }
		[Ordinal(18)] [RED("entryPointDir")] public Vector4 EntryPointDir { get; set; }
		[Ordinal(19)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(20)] [RED("isInSmartObject")] public CBool IsInSmartObject { get; set; }

		public gameActionMoveToSmartObjectState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
