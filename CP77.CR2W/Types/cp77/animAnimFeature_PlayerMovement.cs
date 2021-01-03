using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_PlayerMovement : animAnimFeature_Movement
	{
		[Ordinal(0)]  [RED("facingDirection")] public Vector4 FacingDirection { get; set; }
		[Ordinal(1)]  [RED("inAir")] public CBool InAir { get; set; }
		[Ordinal(2)]  [RED("movementDirectionHorizontalAngle")] public CFloat MovementDirectionHorizontalAngle { get; set; }
		[Ordinal(3)]  [RED("standingTerrainAngle")] public CFloat StandingTerrainAngle { get; set; }
		[Ordinal(4)]  [RED("verticalSpeed")] public CFloat VerticalSpeed { get; set; }

		public animAnimFeature_PlayerMovement(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
