using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		[Ordinal(9)] [RED("facingDirection")] public Vector4 FacingDirection { get; set; }
		[Ordinal(10)] [RED("verticalSpeed")] public CFloat VerticalSpeed { get; set; }
		[Ordinal(11)] [RED("movementDirectionHorizontalAngle")] public CFloat MovementDirectionHorizontalAngle { get; set; }
		[Ordinal(12)] [RED("inAir")] public CBool InAir { get; set; }
		[Ordinal(13)] [RED("standingTerrainAngle")] public CFloat StandingTerrainAngle { get; set; }

		public animAnimFeature_PlayerMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
