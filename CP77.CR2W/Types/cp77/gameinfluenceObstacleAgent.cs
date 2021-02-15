using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceObstacleAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] [RED("useMeshes")] public CBool UseMeshes { get; set; }
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }

		public gameinfluenceObstacleAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
