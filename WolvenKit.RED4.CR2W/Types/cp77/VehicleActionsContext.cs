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
			get
			{
				if (_requestorID == null)
				{
					_requestorID = (entEntityID) CR2WTypeManager.Create("entEntityID", "requestorID", cr2w, this);
				}
				return _requestorID;
			}
			set
			{
				if (_requestorID == value)
				{
					return;
				}
				_requestorID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("requestType")] 
		public CEnum<gamedeviceRequestType> RequestType
		{
			get
			{
				if (_requestType == null)
				{
					_requestType = (CEnum<gamedeviceRequestType>) CR2WTypeManager.Create("gamedeviceRequestType", "requestType", cr2w, this);
				}
				return _requestType;
			}
			set
			{
				if (_requestType == value)
				{
					return;
				}
				_requestType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("interactionLayerTag")] 
		public CName InteractionLayerTag
		{
			get
			{
				if (_interactionLayerTag == null)
				{
					_interactionLayerTag = (CName) CR2WTypeManager.Create("CName", "interactionLayerTag", cr2w, this);
				}
				return _interactionLayerTag;
			}
			set
			{
				if (_interactionLayerTag == value)
				{
					return;
				}
				_interactionLayerTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("processInitiatorObject")] 
		public wCHandle<gameObject> ProcessInitiatorObject
		{
			get
			{
				if (_processInitiatorObject == null)
				{
					_processInitiatorObject = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "processInitiatorObject", cr2w, this);
				}
				return _processInitiatorObject;
			}
			set
			{
				if (_processInitiatorObject == value)
				{
					return;
				}
				_processInitiatorObject = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("eventType")] 
		public CEnum<gameinteractionsEInteractionEventType> EventType
		{
			get
			{
				if (_eventType == null)
				{
					_eventType = (CEnum<gameinteractionsEInteractionEventType>) CR2WTypeManager.Create("gameinteractionsEInteractionEventType", "eventType", cr2w, this);
				}
				return _eventType;
			}
			set
			{
				if (_eventType == value)
				{
					return;
				}
				_eventType = value;
				PropertySet(this);
			}
		}

		public VehicleActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
