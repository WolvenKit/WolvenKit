using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_WrapperValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("wrapperNames")] public CArray<CName> WrapperNames { get; set; }
		[Ordinal(12)] [RED("logicOp")] public CEnum<animEAnimGraphLogicOp> LogicOp { get; set; }
		[Ordinal(13)] [RED("oneMinus")] public CBool OneMinus { get; set; }

		public animAnimNode_WrapperValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
