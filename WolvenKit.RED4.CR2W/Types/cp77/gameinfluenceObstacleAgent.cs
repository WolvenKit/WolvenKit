using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceObstacleAgent : gameinfluenceIAgent
	{
		[Ordinal(0)] [RED("useMeshes")] public CBool UseMeshes { get; set; }
		[Ordinal(1)] [RED("radius")] public CFloat Radius { get; set; }

		public gameinfluenceObstacleAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
