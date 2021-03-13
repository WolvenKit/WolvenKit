using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workEntryAnim : workIEntry
	{
		[Ordinal(2)] [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(3)] [RED("idleAnim")] public CName IdleAnim { get; set; }
		[Ordinal(4)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(5)] [RED("orientationType")] public CEnum<moveMovementOrientationType> OrientationType { get; set; }
		[Ordinal(6)] [RED("isSynchronized")] public CBool IsSynchronized { get; set; }
		[Ordinal(7)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(8)] [RED("syncOffset")] public Transform SyncOffset { get; set; }
		[Ordinal(9)] [RED("blendOutTime")] public CFloat BlendOutTime { get; set; }

		public workEntryAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
