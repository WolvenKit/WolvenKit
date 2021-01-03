using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptFindWallResult : IScriptable
	{
		[Ordinal(0)]  [RED("hitPosition")] public Vector4 HitPosition { get; set; }
		[Ordinal(1)]  [RED("isHit")] public CBool IsHit { get; set; }
		[Ordinal(2)]  [RED("status")] public CEnum<worldNavigationRequestStatus> Status { get; set; }

		public worldNavigationScriptFindWallResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
