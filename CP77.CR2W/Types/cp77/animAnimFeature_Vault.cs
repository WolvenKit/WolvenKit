using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_Vault : animAnimFeature_Climb
	{
		[Ordinal(0)]  [RED("landPosition")] public Vector4 LandPosition { get; set; }
		[Ordinal(1)]  [RED("travellingTime")] public CFloat TravellingTime { get; set; }
		[Ordinal(2)]  [RED("obstacleDepth")] public CFloat ObstacleDepth { get; set; }

		public animAnimFeature_Vault(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
