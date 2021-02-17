using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationScriptFindPointResult : CVariable
	{
		[Ordinal(0)] [RED("status")] public CEnum<worldNavigationRequestStatus> Status { get; set; }
		[Ordinal(1)] [RED("point")] public Vector4 Point { get; set; }

		public worldNavigationScriptFindPointResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
