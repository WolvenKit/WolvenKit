using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameGetActionsContext : CVariable
	{
		private CHandle<gamedeviceClearance> _clearance;
		private entEntityID _requestorID;
		private CEnum<gamedeviceRequestType> _requestType;
		private CArray<gameActionPrereqs> _actionPrereqs;
		private CName _interactionLayerTag;
		private wCHandle<gameObject> _processInitiatorObject;
		private CBool _ignoresAuthorization;
		private CBool _ignoresRPG;

		[Ordinal(0)] 
		[RED("clearance")] 
		public CHandle<gamedeviceClearance> Clearance
		{
			get
			{
				if (_clearance == null)
				{
					_clearance = (CHandle<gamedeviceClearance>) CR2WTypeManager.Create("handle:gamedeviceClearance", "clearance", cr2w, this);
				}
				return _clearance;
			}
			set
			{
				if (_clearance == value)
				{
					return;
				}
				_clearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
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

		[Ordinal(3)] 
		[RED("actionPrereqs")] 
		public CArray<gameActionPrereqs> ActionPrereqs
		{
			get
			{
				if (_actionPrereqs == null)
				{
					_actionPrereqs = (CArray<gameActionPrereqs>) CR2WTypeManager.Create("array:gameActionPrereqs", "actionPrereqs", cr2w, this);
				}
				return _actionPrereqs;
			}
			set
			{
				if (_actionPrereqs == value)
				{
					return;
				}
				_actionPrereqs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
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

		[Ordinal(6)] 
		[RED("ignoresAuthorization")] 
		public CBool IgnoresAuthorization
		{
			get
			{
				if (_ignoresAuthorization == null)
				{
					_ignoresAuthorization = (CBool) CR2WTypeManager.Create("Bool", "ignoresAuthorization", cr2w, this);
				}
				return _ignoresAuthorization;
			}
			set
			{
				if (_ignoresAuthorization == value)
				{
					return;
				}
				_ignoresAuthorization = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("ignoresRPG")] 
		public CBool IgnoresRPG
		{
			get
			{
				if (_ignoresRPG == null)
				{
					_ignoresRPG = (CBool) CR2WTypeManager.Create("Bool", "ignoresRPG", cr2w, this);
				}
				return _ignoresRPG;
			}
			set
			{
				if (_ignoresRPG == value)
				{
					return;
				}
				_ignoresRPG = value;
				PropertySet(this);
			}
		}

		public gameGetActionsContext(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
