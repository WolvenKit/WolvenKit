using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(0)]  [RED("disableLazyInitialization")] public CBool DisableLazyInitialization { get; set; }
		[Ordinal(1)]  [RED("script")] public CHandle<AIbehaviortaskScript> Script { get; set; }

		public AIbehaviorScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
