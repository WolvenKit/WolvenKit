using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleActionsContext : CVariable
	{
		private entEntityID _requestorID;
		private CEnum<gamedeviceRequestType> _requestType;
		private CName _interactionLayerTag;
		private wCHandle<gameObject> _processInitiatorObject;
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
		public wCHandle<gameObject> ProcessInitiatorObject
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

		public VehicleActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
