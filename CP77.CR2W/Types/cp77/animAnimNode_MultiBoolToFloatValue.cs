using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		[Ordinal(0)]  [RED("allMustBeTrue")] public CBool AllMustBeTrue { get; set; }
		[Ordinal(1)]  [RED("inputsData")] public CArray<animAnimMultiBoolToFloatEntry> InputsData { get; set; }
		[Ordinal(2)]  [RED("onFalse")] public CFloat OnFalse { get; set; }
		[Ordinal(3)]  [RED("onTrue")] public CFloat OnTrue { get; set; }

		public animAnimNode_MultiBoolToFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
