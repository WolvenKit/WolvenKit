using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_StackTransformsShrinker_ : animAnimNode_OnePoseInput
	{
		[Ordinal(12)] [RED("tag")] public CName Tag { get; set; }

		public animAnimNode_StackTransformsShrinker_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
