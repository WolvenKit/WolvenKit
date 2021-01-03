using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		[Ordinal(0)]  [RED("lastResultTimestamp")] public CFloat LastResultTimestamp { get; set; }
		[Ordinal(1)]  [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		[Ordinal(2)]  [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }

		public FollowerFindTeleportPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
