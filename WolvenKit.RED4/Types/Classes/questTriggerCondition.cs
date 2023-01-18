using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questTriggerCondition : questCondition
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<questTriggerConditionType> Type
		{
			get => GetPropertyValue<CEnum<questTriggerConditionType>>();
			set => SetPropertyValue<CEnum<questTriggerConditionType>>(value);
		}

		[Ordinal(1)] 
		[RED("triggerAreaRef")] 
		public NodeRef TriggerAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(2)] 
		[RED("activatorRef")] 
		public gameEntityReference ActivatorRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(3)] 
		[RED("isPlayerActivator")] 
		public CBool IsPlayerActivator
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questTriggerCondition()
		{
			Type = Enums.questTriggerConditionType.IsInside;
			ActivatorRef = new() { Names = new() };
			IsPlayerActivator = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
