using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorAssignTaskDefinition : AIbehaviorTaskDefinition
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

		public AIbehaviorAssignTaskDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
