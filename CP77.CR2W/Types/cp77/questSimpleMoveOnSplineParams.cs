using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSimpleMoveOnSplineParams : CVariable
	{
		[Ordinal(0)]  [RED("facingTargetRef")] public CHandle<questUniversalRef> FacingTargetRef { get; set; }
		[Ordinal(1)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(2)]  [RED("rotateEntityTowardsFacingTarget")] public CBool RotateEntityTowardsFacingTarget { get; set; }
		[Ordinal(3)]  [RED("snapToTerrain")] public CBool SnapToTerrain { get; set; }
		[Ordinal(4)]  [RED("useOffMeshLinkReservation")] public CBool UseOffMeshLinkReservation { get; set; }

		public questSimpleMoveOnSplineParams(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
