using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorUnaryConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorConditionDefinition> _child;

		[Ordinal(1)] 
		[RED("child")] 
		public CHandle<AIbehaviorConditionDefinition> Child
		{
			get => GetProperty(ref _child);
			set => SetProperty(ref _child, value);
		}
	}
}
