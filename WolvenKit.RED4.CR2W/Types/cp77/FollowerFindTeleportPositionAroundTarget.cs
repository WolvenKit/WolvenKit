using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowerFindTeleportPositionAroundTarget : AIbehaviortaskScript
	{
		[Ordinal(0)] [RED("target")] public CHandle<AIArgumentMapping> Target { get; set; }
		[Ordinal(1)] [RED("outPositionArgument")] public CHandle<AIArgumentMapping> OutPositionArgument { get; set; }
		[Ordinal(2)] [RED("lastResultTimestamp")] public CFloat LastResultTimestamp { get; set; }

		public FollowerFindTeleportPositionAroundTarget(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
