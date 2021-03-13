using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)] [RED("height")] public CFloat Height { get; set; }
		[Ordinal(1)] [RED("width")] public CFloat Width { get; set; }
		[Ordinal(2)] [RED("curvature")] public CFloat Curvature { get; set; }
		[Ordinal(3)] [RED("maxPriorityBoundsFactor")] public CFloat MaxPriorityBoundsFactor { get; set; }

		public gameinteractionsDistanceFromScreenCenterPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
