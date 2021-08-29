using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TestBehaviorDelegateTask : AIbehaviortaskScript
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
	}
}
