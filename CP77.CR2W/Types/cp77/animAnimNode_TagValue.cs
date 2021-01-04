using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_TagValue : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("defaultValue")] public CFloat DefaultValue { get; set; }
		[Ordinal(1)]  [RED("oneMinus")] public CBool OneMinus { get; set; }
		[Ordinal(2)]  [RED("tag")] public CName Tag { get; set; }

		public animAnimNode_TagValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
