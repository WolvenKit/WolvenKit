using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAnimationExtractedData : CVariable
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("animsetsExtractedTransforms")] public CArray<gameAnimationTransforms> AnimsetsExtractedTransforms { get; set; }
		[Ordinal(2)]  [RED("smartObjectPointType")] public CEnum<gameSmartObjectPointType> SmartObjectPointType { get; set; }

		public gameAnimationExtractedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
