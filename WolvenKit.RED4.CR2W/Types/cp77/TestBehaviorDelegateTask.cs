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
			get => GetProperty(ref _attrRef);
			set => SetProperty(ref _attrRef, value);
		}

		[Ordinal(1)] 
		[RED("taskRef")] 
		public AIbehaviorDelegateTaskRef TaskRef
		{
			get => GetProperty(ref _taskRef);
			set => SetProperty(ref _taskRef, value);
		}

		public TestBehaviorDelegateTask(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
