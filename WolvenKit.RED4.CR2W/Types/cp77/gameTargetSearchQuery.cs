using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameTargetSearchQuery : CVariable
	{
		[Ordinal(0)] [RED("testedSet")] public CEnum<gameTargetingSet> TestedSet { get; set; }
		[Ordinal(1)] [RED("searchFilter")] public gameTargetSearchFilter SearchFilter { get; set; }
		[Ordinal(2)] [RED("includeSecondaryTargets")] public CBool IncludeSecondaryTargets { get; set; }
		[Ordinal(3)] [RED("ignoreInstigator")] public CBool IgnoreInstigator { get; set; }
		[Ordinal(4)] [RED("maxDistance")] public CFloat MaxDistance { get; set; }
		[Ordinal(5)] [RED("queryTarget")] public entEntityID QueryTarget { get; set; }

		public gameTargetSearchQuery(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
