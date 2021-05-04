using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorUnaryConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorConditionDefinition> _child;

		[Ordinal(1)] 
		[RED("child")] 
		public CHandle<AIbehaviorConditionDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}

		public AIbehaviorUnaryConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
