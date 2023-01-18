using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questInteraction_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questObjectInteractionEventType> EventType
		{
			get => GetPropertyValue<CEnum<questObjectInteractionEventType>>();
			set => SetPropertyValue<CEnum<questObjectInteractionEventType>>(value);
		}

		public questInteraction_ConditionType()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
