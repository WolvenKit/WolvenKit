using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questDistanceVsDistanceComparison_ConditionType : questIDistanceConditionType
	{
		[Ordinal(0)] [RED("distanceDefinition1")] public CHandle<questObjectDistance> DistanceDefinition1 { get; set; }
		[Ordinal(1)] [RED("distanceDefinition2")] public CHandle<questObjectDistance> DistanceDefinition2 { get; set; }
		[Ordinal(2)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public questDistanceVsDistanceComparison_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
