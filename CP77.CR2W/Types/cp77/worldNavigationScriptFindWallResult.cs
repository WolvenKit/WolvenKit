using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptFindWallResult : IScriptable
	{
		[Ordinal(0)] [RED("status")] public CEnum<worldNavigationRequestStatus> Status { get; set; }
		[Ordinal(1)] [RED("isHit")] public CBool IsHit { get; set; }
		[Ordinal(2)] [RED("hitPosition")] public Vector4 HitPosition { get; set; }

		public worldNavigationScriptFindWallResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
