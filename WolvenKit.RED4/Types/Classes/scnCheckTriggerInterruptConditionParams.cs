using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnCheckTriggerInterruptConditionParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("inside")] 
		public CBool Inside
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("triggerArea")] 
		public NodeRef TriggerArea
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public scnCheckTriggerInterruptConditionParams()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
