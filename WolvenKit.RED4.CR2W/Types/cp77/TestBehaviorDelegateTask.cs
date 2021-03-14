using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TestBehaviorDelegateTask : AIbehaviortaskScript
	{
		private AIbehaviorDelegateAttrRef _attrRef;
		private AIbehaviorDelegateTaskRef _taskRef;

		[Ordinal(0)] 
		[RED("attrRef")] 
		public AIbehaviorDelegateAttrRef AttrRef
		{
			get
			{
				if (_attrRef == null)
				{
					_attrRef = (AIbehaviorDelegateAttrRef) CR2WTypeManager.Create("AIbehaviorDelegateAttrRef", "attrRef", cr2w, this);
				}
				return _attrRef;
			}
			set
			{
				if (_attrRef == value)
				{
					return;
				}
				_attrRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("taskRef")] 
		public AIbehaviorDelegateTaskRef TaskRef
		{
			get
			{
				if (_taskRef == null)
				{
					_taskRef = (AIbehaviorDelegateTaskRef) CR2WTypeManager.Create("AIbehaviorDelegateTaskRef", "taskRef", cr2w, this);
				}
				return _taskRef;
			}
			set
			{
				if (_taskRef == value)
				{
					return;
				}
				_taskRef = value;
				PropertySet(this);
			}
		}

		public TestBehaviorDelegateTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
