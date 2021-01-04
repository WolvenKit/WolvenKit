using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTargetSearchQuery : CVariable
	{
		[Ordinal(0)]  [RED("ignoreInstigator")] public CBool IgnoreInstigator { get; set; }
		[Ordinal(1)]  [RED("includeSecondaryTargets")] public CBool IncludeSecondaryTargets { get; set; }
		[Ordinal(2)]  [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(3)]  [RED("queryTarget")] public entEntityID QueryTarget { get; set; }
		[Ordinal(4)]  [RED("searchFilter")] public gameTargetSearchFilter SearchFilter { get; set; }
		[Ordinal(5)]  [RED("testedSet")] public CEnum<gameTargetingSet> TestedSet { get; set; }

		public gameTargetSearchQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
