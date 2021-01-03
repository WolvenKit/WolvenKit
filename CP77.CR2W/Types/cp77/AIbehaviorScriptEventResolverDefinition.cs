using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptEventResolverDefinition : AIbehaviorEventResolverDefinition
	{
		[Ordinal(0)]  [RED("script")] public CHandle<AIbehavioreventResolverScript> Script { get; set; }

		public AIbehaviorScriptEventResolverDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
