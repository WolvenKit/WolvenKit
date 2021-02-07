using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldRelativeNodePath : CVariable
	{
		[Ordinal(0)]  [RED("parentsToSkip")] public CUInt32 ParentsToSkip { get; set; }
		[Ordinal(1)]  [RED("elements")] public CArray<worldRelativeNodePathElement> Elements { get; set; }

		public worldRelativeNodePath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
