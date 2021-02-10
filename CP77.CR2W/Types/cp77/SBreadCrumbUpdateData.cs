using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SBreadCrumbUpdateData : CVariable
	{
		[Ordinal(0)]  [RED("elementName")] public CString ElementName { get; set; }
		[Ordinal(1)]  [RED("elementID")] public CInt32 ElementID { get; set; }
		[Ordinal(2)]  [RED("context")] public CName Context { get; set; }

		public SBreadCrumbUpdateData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
