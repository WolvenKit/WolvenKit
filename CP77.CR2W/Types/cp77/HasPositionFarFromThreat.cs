using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HasPositionFarFromThreat : AIbehaviorconditionScript
	{
		[Ordinal(0)]  [RED("desiredDistance")] public CFloat DesiredDistance { get; set; }
		[Ordinal(1)]  [RED("distanceFromTraffic")] public CFloat DistanceFromTraffic { get; set; }
		[Ordinal(2)]  [RED("minDistance")] public CFloat MinDistance { get; set; }
		[Ordinal(3)]  [RED("minPathLength")] public CFloat MinPathLength { get; set; }

		public HasPositionFarFromThreat(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
