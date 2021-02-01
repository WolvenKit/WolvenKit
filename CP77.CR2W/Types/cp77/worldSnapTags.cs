using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldSnapTags : CVariable
	{
		[Ordinal(0)]  [RED("excludeTags")] public CArray<CName> ExcludeTags { get; set; }
		[Ordinal(1)]  [RED("includeTags")] public CArray<CName> IncludeTags { get; set; }

		public worldSnapTags(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
