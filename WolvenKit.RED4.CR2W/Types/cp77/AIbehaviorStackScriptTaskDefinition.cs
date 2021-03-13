using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] [RED("script")] public CHandle<AIbehaviortaskStackScript> Script { get; set; }

		public AIbehaviorStackScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
