using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMovingPlatformMovementDynamic : gameIMovingPlatformMovementPointToPoint
	{
		[Ordinal(1)] [RED("curveName")] public CName CurveName { get; set; }

		public gameMovingPlatformMovementDynamic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
