using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIbehaviorAssignTaskDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("assignments")] 
		public CArray<AIbehaviorAssignTaskItem> Assignments
		{
			get => GetPropertyValue<CArray<AIbehaviorAssignTaskItem>>();
			set => SetPropertyValue<CArray<AIbehaviorAssignTaskItem>>(value);
		}

		[Ordinal(2)] 
		[RED("endAssignments")] 
		public CArray<AIbehaviorAssignTaskItem> EndAssignments
		{
			get => GetPropertyValue<CArray<AIbehaviorAssignTaskItem>>();
			set => SetPropertyValue<CArray<AIbehaviorAssignTaskItem>>(value);
		}

		public AIbehaviorAssignTaskDefinition()
		{
			Assignments = new();
			EndAssignments = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
