using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsDistanceFromScreenCenterPredicate : gameinteractionsIPredicateType
	{
		[Ordinal(0)]  [RED("curvature")] public CFloat Curvature { get; set; }
		[Ordinal(1)]  [RED("height")] public CFloat Height { get; set; }
		[Ordinal(2)]  [RED("maxPriorityBoundsFactor")] public CFloat MaxPriorityBoundsFactor { get; set; }
		[Ordinal(3)]  [RED("width")] public CFloat Width { get; set; }

		public gameinteractionsDistanceFromScreenCenterPredicate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
