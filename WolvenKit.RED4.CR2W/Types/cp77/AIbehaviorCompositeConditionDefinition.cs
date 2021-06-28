using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorCompositeConditionDefinition : AIbehaviorConditionDefinition
	{
		private CArray<CHandle<AIbehaviorConditionDefinition>> _conditions;

		[Ordinal(1)] 
		[RED("conditions")] 
		public CArray<CHandle<AIbehaviorConditionDefinition>> Conditions
		{
			get => GetProperty(ref _conditions);
			set => SetProperty(ref _conditions, value);
		}

		public AIbehaviorCompositeConditionDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
