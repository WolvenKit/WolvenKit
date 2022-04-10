using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questBehind_ConditionType : questISensesConditionType
	{
		[Ordinal(0)] 
		[RED("targetRef")] 
		public gameEntityReference TargetRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("eventType")] 
		public CEnum<questBehindInteractionEventType> EventType
		{
			get => GetPropertyValue<CEnum<questBehindInteractionEventType>>();
			set => SetPropertyValue<CEnum<questBehindInteractionEventType>>(value);
		}

		public questBehind_ConditionType()
		{
			TargetRef = new() { Names = new() };
			EventType = Enums.questBehindInteractionEventType.StartedBeingBehind;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
