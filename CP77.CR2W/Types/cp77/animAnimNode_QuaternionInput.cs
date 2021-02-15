using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_QuaternionInput : animAnimNode_QuaternionValue
	{
		[Ordinal(1)] [RED("group")] public CName Group { get; set; }
		[Ordinal(2)] [RED("name")] public CName Name { get; set; }

		public animAnimNode_QuaternionInput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
