using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorAssignTaskDefinition : AIbehaviorTaskDefinition
	{
		private CArray<AIbehaviorAssignTaskItem> _assignments;
		private CArray<AIbehaviorAssignTaskItem> _endAssignments;

		[Ordinal(1)] 
		[RED("assignments")] 
		public CArray<AIbehaviorAssignTaskItem> Assignments
		{
			get => GetProperty(ref _assignments);
			set => SetProperty(ref _assignments, value);
		}

		[Ordinal(2)] 
		[RED("endAssignments")] 
		public CArray<AIbehaviorAssignTaskItem> EndAssignments
		{
			get => GetProperty(ref _endAssignments);
			set => SetProperty(ref _endAssignments, value);
		}
	}
}
