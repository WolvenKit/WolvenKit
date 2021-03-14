using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class HitDistanceCoveredPrereq : GenericHitPrereq
	{
		[Ordinal(5)] [RED("distanceRequired")] public CFloat DistanceRequired { get; set; }
		[Ordinal(6)] [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }

		public HitDistanceCoveredPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
