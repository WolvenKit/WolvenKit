using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entTagMask : CVariable
	{
		[Ordinal(0)]  [RED("hardTags")] public redTagList HardTags { get; set; }
		[Ordinal(1)]  [RED("softTags")] public redTagList SoftTags { get; set; }
		[Ordinal(2)]  [RED("excludedTags")] public redTagList ExcludedTags { get; set; }

		public entTagMask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
