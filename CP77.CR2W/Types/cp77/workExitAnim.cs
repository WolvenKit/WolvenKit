using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workExitAnim : workIEntry
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("idleAnim")] public CName IdleAnim { get; set; }
		[Ordinal(2)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(3)]  [RED("isSynchronized")] public CBool IsSynchronized { get; set; }
		[Ordinal(4)]  [RED("stayOnNavmesh")] public CBool StayOnNavmesh { get; set; }
		[Ordinal(5)]  [RED("snapZToNavmesh")] public CBool SnapZToNavmesh { get; set; }
		[Ordinal(6)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(7)]  [RED("syncOffset")] public Transform SyncOffset { get; set; }
		[Ordinal(8)]  [RED("disableRandomExit")] public CBool DisableRandomExit { get; set; }

		public workExitAnim(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
