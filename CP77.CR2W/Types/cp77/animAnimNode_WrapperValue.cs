using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
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
