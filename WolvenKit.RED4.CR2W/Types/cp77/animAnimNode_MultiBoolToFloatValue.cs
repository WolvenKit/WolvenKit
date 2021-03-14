using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_MultiBoolToFloatValue : animAnimNode_FloatValue
	{
		[Ordinal(11)] [RED("allMustBeTrue")] public CBool AllMustBeTrue { get; set; }
		[Ordinal(12)] [RED("onTrue")] public CFloat OnTrue { get; set; }
		[Ordinal(13)] [RED("onFalse")] public CFloat OnFalse { get; set; }
		[Ordinal(14)] [RED("inputsData")] public CArray<animAnimMultiBoolToFloatEntry> InputsData { get; set; }

		public animAnimNode_MultiBoolToFloatValue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
