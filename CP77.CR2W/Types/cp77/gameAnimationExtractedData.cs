using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
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
