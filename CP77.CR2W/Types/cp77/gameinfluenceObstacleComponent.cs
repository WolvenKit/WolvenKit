using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceObstacleComponent : entIPlacedComponent
	{
		[Ordinal(0)]  [RED("boundingBoxType")] public CEnum<gameinfluenceEBoundingBoxType> BoundingBoxType { get; set; }
		[Ordinal(1)]  [RED("customBoundingBox")] public Box CustomBoundingBox { get; set; }
		[Ordinal(2)]  [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)]  [RED("obstacleAgent")] public gameinfluenceObstacleAgent ObstacleAgent { get; set; }

		public gameinfluenceObstacleComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
