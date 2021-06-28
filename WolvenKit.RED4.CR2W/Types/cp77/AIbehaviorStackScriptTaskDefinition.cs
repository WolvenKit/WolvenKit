using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIbehaviortaskStackScript> _script;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskStackScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		public AIbehaviorStackScriptTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
