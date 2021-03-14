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
			get
			{
				if (_assignments == null)
				{
					_assignments = (CArray<AIbehaviorAssignTaskItem>) CR2WTypeManager.Create("array:AIbehaviorAssignTaskItem", "assignments", cr2w, this);
				}
				return _assignments;
			}
			set
			{
				if (_assignments == value)
				{
					return;
				}
				_assignments = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("endAssignments")] 
		public CArray<AIbehaviorAssignTaskItem> EndAssignments
		{
			get
			{
				if (_endAssignments == null)
				{
					_endAssignments = (CArray<AIbehaviorAssignTaskItem>) CR2WTypeManager.Create("array:AIbehaviorAssignTaskItem", "endAssignments", cr2w, this);
				}
				return _endAssignments;
			}
			set
			{
				if (_endAssignments == value)
				{
					return;
				}
				_endAssignments = value;
				PropertySet(this);
			}
		}

		public AIbehaviorAssignTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
