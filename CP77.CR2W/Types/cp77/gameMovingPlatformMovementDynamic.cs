using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMovementDynamic : gameIMovingPlatformMovementPointToPoint
	{
		[Ordinal(1)] [RED("curveName")] public CName CurveName { get; set; }

		public gameMovingPlatformMovementDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
