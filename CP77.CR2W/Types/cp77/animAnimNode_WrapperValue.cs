using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WrapperValue : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("logicOp")] public CEnum<animEAnimGraphLogicOp> LogicOp { get; set; }
		[Ordinal(1)]  [RED("oneMinus")] public CBool OneMinus { get; set; }
		[Ordinal(2)]  [RED("wrapperNames")] public CArray<CName> WrapperNames { get; set; }

		public animAnimNode_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
