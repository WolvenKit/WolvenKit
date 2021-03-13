using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SWeakPoints : CVariable
	{
		[Ordinal(0)] [RED("weakPointName")] public CName WeakPointName { get; set; }
		[Ordinal(1)] [RED("loc_name_key")] public CString Loc_name_key { get; set; }
		[Ordinal(2)] [RED("loc_desc_key")] public CString Loc_desc_key { get; set; }

		public SWeakPoints(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
