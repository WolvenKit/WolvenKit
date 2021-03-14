using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorEntityReuseEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)] [RED("destination")] public CHandle<AIArgumentMapping> Destination { get; set; }
		[Ordinal(1)] [RED("fastForwardAfterTeleport")] public CHandle<AIArgumentMapping> FastForwardAfterTeleport { get; set; }

		public AIbehaviorEntityReuseEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
