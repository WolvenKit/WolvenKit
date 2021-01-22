using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CrossingLight : TrafficLight
	{
		[Ordinal(0)]  [RED("audioLightIsGreen")] public CBool AudioLightIsGreen { get; set; }

		public CrossingLight(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
