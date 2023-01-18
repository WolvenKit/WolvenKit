using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleActionsContext : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("requestorID")] 
		public entEntityID RequestorID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetPropertyValue<CEnum<gamedeviceRequestType>>();
			set => SetPropertyValue<CEnum<gamedeviceRequestType>>(value);
		}

		[Ordinal(2)] 
		[RED("interactionLayerTag")] 
		public CName InteractionLayerTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("processInitiatorObject")] 
		public CWeakHandle<gameObject> ProcessInitiatorObject
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get => GetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>();
			set => SetPropertyValue<CEnum<gameinteractionsEInteractionEventType>>(value);
		}

		public VehicleActionsContext()
		{
			RequestorID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
