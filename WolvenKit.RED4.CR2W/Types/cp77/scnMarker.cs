using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnMarker : CVariable
	{
		private CEnum<scnMarkerType> _type;
		private CName _localMarkerId;
		private NodeRef _nodeRef;
		private gameEntityReference _entityRef;
		private CName _slotName;
		private CBool _isMounted;

		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<scnMarkerType> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CEnum<scnMarkerType>) CR2WTypeManager.Create("scnMarkerType", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("localMarkerId")] 
		public CName LocalMarkerId
		{
			get
			{
				if (_localMarkerId == null)
				{
					_localMarkerId = (CName) CR2WTypeManager.Create("CName", "localMarkerId", cr2w, this);
				}
				return _localMarkerId;
			}
			set
			{
				if (_localMarkerId == value)
				{
					return;
				}
				_localMarkerId = value;
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
		[RED("entityRef")] 
		public gameEntityReference EntityRef
		{
			get
			{
				if (_entityRef == null)
				{
					_entityRef = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityRef", cr2w, this);
				}
				return _entityRef;
			}
			set
			{
				if (_entityRef == value)
				{
					return;
				}
				_entityRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("isMounted")] 
		public CBool IsMounted
		{
			get
			{
				if (_isMounted == null)
				{
					_isMounted = (CBool) CR2WTypeManager.Create("Bool", "isMounted", cr2w, this);
				}
				return _isMounted;
			}
			set
			{
				if (_isMounted == value)
				{
					return;
				}
				_isMounted = value;
				PropertySet(this);
			}
		}

		public scnMarker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
