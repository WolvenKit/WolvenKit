using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinteractionsCrosswalkEvent : redEvent
	{
		[Ordinal(0)]  [RED("trafficLightColor")] public CEnum<worldTrafficLightColor> TrafficLightColor { get; set; }
		[Ordinal(1)]  [RED("oldTrafficLightColor")] public CEnum<worldTrafficLightColor> OldTrafficLightColor { get; set; }
		[Ordinal(2)]  [RED("totalDistance")] public CFloat TotalDistance { get; set; }
		[Ordinal(3)]  [RED("distanceLeft")] public CFloat DistanceLeft { get; set; }

		public gameinteractionsCrosswalkEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
