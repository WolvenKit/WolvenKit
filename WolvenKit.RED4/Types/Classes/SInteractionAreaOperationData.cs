using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SInteractionAreaOperationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isActivatorPlayer")] 
		public CBool IsActivatorPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isActivatorNPC")] 
		public CBool IsActivatorNPC
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("areaTag")] 
		public CName AreaTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("operationType")] 
		public CEnum<gameinteractionsEInteractionEventType> OperationType
		{
			get => GetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>();
			set => SetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>(value);
		}

		[Ordinal(4)] 
		[RED("operation")] 
		public SBaseDeviceOperationData Operation
		{
			get => GetPropertyValue<SBaseDeviceOperationData>();
			set => SetPropertyValue<SBaseDeviceOperationData>(value);
		}

		public SInteractionAreaOperationData()
		{
			Operation = new SBaseDeviceOperationData { IsEnabled = true, TransformAnimations = new(), VFXs = new(), SFXs = new(), Facts = new(), Components = new(), Stims = new(), StatusEffects = new(), Damages = new(), Items = new(), Teleport = new STeleportOperationData(), PlayerWorkspot = new SWorkspotData(), ToggleOperations = new(), DelayID = new gameDelayID() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
