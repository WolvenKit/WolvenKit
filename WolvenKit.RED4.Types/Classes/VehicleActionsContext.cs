using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleActionsContext : RedBaseClass
	{
		private entEntityID _requestorID;
		private CEnum<gamedeviceRequestType> _requestType;
		private CName _interactionLayerTag;
		private CWeakHandle<gameObject> _processInitiatorObject;
		private CEnum<gameinteractionsEInteractionEventType> _eventType;

		[Ordinal(0)] 
		[RED("requestorID")] 
		public entEntityID RequestorID
		{
			get => GetProperty(ref _requestorID);
			set => SetProperty(ref _requestorID, value);
		}

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get => GetProperty(ref _requestType);
			set => SetProperty(ref _requestType, value);
		}

		[Ordinal(2)] 
		[RED("interactionLayerTag")] 
		public CName InteractionLayerTag
		{
			get => GetProperty(ref _interactionLayerTag);
			set => SetProperty(ref _interactionLayerTag, value);
		}

		[Ordinal(3)] 
		[RED("processInitiatorObject")] 
		public CWeakHandle<gameObject> ProcessInitiatorObject
		{
			get => GetProperty(ref _processInitiatorObject);
			set => SetProperty(ref _processInitiatorObject, value);
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get => GetProperty(ref _eventType);
			set => SetProperty(ref _eventType, value);
		}
	}
}
