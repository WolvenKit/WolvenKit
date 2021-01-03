using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_FloatComparator : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("falseInputLink")] public animFloatLink FalseInputLink { get; set; }
		[Ordinal(1)]  [RED("falseValue")] public CFloat FalseValue { get; set; }
		[Ordinal(2)]  [RED("firstInputLink")] public animFloatLink FirstInputLink { get; set; }
		[Ordinal(3)]  [RED("firstValue")] public CFloat FirstValue { get; set; }
		[Ordinal(4)]  [RED("operation")] public CEnum<animEAnimGraphCompareFunc> Operation { get; set; }
		[Ordinal(5)]  [RED("secondInputLink")] public animFloatLink SecondInputLink { get; set; }
		[Ordinal(6)]  [RED("secondValue")] public CFloat SecondValue { get; set; }
		[Ordinal(7)]  [RED("trueInputLink")] public animFloatLink TrueInputLink { get; set; }
		[Ordinal(8)]  [RED("trueValue")] public CFloat TrueValue { get; set; }

		public animAnimNode_FloatComparator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
