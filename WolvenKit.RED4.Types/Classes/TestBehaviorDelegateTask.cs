using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TestBehaviorDelegateTask : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("attrRef")] 
		public AIbehaviorDelegateAttrRef AttrRef
		{
			get => GetPropertyValue<AIbehaviorDelegateAttrRef>();
			set => SetPropertyValue<AIbehaviorDelegateAttrRef>(value);
		}

		[Ordinal(1)] 
		[RED("taskRef")] 
		public AIbehaviorDelegateTaskRef TaskRef
		{
			get => GetPropertyValue<AIbehaviorDelegateTaskRef>();
			set => SetPropertyValue<AIbehaviorDelegateTaskRef>(value);
		}

		public TestBehaviorDelegateTask()
		{
			AttrRef = new();
			TaskRef = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
