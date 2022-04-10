using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InteractionAreaOperationTriggerData : DeviceOperationTriggerData
	{
		[Ordinal(1)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("areaTag")] 
		public CName AreaTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("operationType")] 
		public CEnum<gameinteractionsEInteractionEventType> OperationType
		{
			get => GetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>();
			set => SetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>(value);
		}

		public InteractionAreaOperationTriggerData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
