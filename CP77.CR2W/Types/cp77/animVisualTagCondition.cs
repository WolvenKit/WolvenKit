using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animVisualTagCondition : animIStaticCondition
	{
		[Ordinal(0)] [RED("visualTag")] public CName VisualTag { get; set; }

		public animVisualTagCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
