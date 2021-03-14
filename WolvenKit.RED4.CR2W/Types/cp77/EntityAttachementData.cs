using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class EntityAttachementData : CVariable
	{
		private CName _slotName;
		private CName _slotComponentName;
		private NodeRef _nodeRef;
		private CName _attachementComponentName;
		private entEntityID _ownerID;

		[Ordinal(0)] 
		[RED("slotName")] 
		public CName SlotName
		{
			get
			{
				if (_slotName == null)
				{
					_slotName = (CName) CR2WTypeManager.Create("CName", "slotName", cr2w, this);
				}
				return _slotName;
			}
			set
			{
				if (_slotName == value)
				{
					return;
				}
				_slotName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("slotComponentName")] 
		public CName SlotComponentName
		{
			get
			{
				if (_slotComponentName == null)
				{
					_slotComponentName = (CName) CR2WTypeManager.Create("CName", "slotComponentName", cr2w, this);
				}
				return _slotComponentName;
			}
			set
			{
				if (_slotComponentName == value)
				{
					return;
				}
				_slotComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get
			{
				if (_nodeRef == null)
				{
					_nodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "nodeRef", cr2w, this);
				}
				return _nodeRef;
			}
			set
			{
				if (_nodeRef == value)
				{
					return;
				}
				_nodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("attachementComponentName")] 
		public CName AttachementComponentName
		{
			get
			{
				if (_attachementComponentName == null)
				{
					_attachementComponentName = (CName) CR2WTypeManager.Create("CName", "attachementComponentName", cr2w, this);
				}
				return _attachementComponentName;
			}
			set
			{
				if (_attachementComponentName == value)
				{
					return;
				}
				_attachementComponentName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get
			{
				if (_ownerID == null)
				{
					_ownerID = (entEntityID) CR2WTypeManager.Create("entEntityID", "ownerID", cr2w, this);
				}
				return _ownerID;
			}
			set
			{
				if (_ownerID == value)
				{
					return;
				}
				_ownerID = value;
				PropertySet(this);
			}
		}

		public EntityAttachementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
