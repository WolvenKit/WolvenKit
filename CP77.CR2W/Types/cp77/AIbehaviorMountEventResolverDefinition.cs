using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorMountEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)]  [RED("behaviorCallbackName")] public CName BehaviorCallbackName { get; set; }
		[Ordinal(1)]  [RED("isInstant")] public CHandle<AIArgumentMapping> IsInstant { get; set; }
		[Ordinal(2)]  [RED("mountData")] public CHandle<AIArgumentMapping> MountData { get; set; }
		[Ordinal(3)]  [RED("workspotData")] public CHandle<AIArgumentMapping> WorkspotData { get; set; }

		public AIbehaviorMountEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
