using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_BoolConstant : animAnimNode_BoolValue
	{
		[Ordinal(0)]  [RED("value")] public CBool Value { get; set; }

		public animAnimNode_BoolConstant(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
