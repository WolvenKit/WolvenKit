using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIActionSpot : AISmartSpot
	{
		private raRef<workWorkspotResource> _resource;
		private CEnum<AISocketsForRig> _actorBodytypeE3;
		private NodeRef _masterNodeRef;
		private CBool _enabledWhenMasterOccupied;
		private CBool _snapToGround;
		private CBool _useClippingSpace;
		private CFloat _clippingSpaceOrientation;
		private CFloat _clippingSpaceRange;

		[Ordinal(0)] 
		[RED("resource")] 
		public raRef<workWorkspotResource> Resource
		{
			get
			{
				if (_resource == null)
				{
					_resource = (raRef<workWorkspotResource>) CR2WTypeManager.Create("raRef:workWorkspotResource", "resource", cr2w, this);
				}
				return _resource;
			}
			set
			{
				if (_resource == value)
				{
					return;
				}
				_resource = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ActorBodytypeE3")] 
		public CEnum<AISocketsForRig> ActorBodytypeE3
		{
			get
			{
				if (_actorBodytypeE3 == null)
				{
					_actorBodytypeE3 = (CEnum<AISocketsForRig>) CR2WTypeManager.Create("AISocketsForRig", "ActorBodytypeE3", cr2w, this);
				}
				return _actorBodytypeE3;
			}
			set
			{
				if (_actorBodytypeE3 == value)
				{
					return;
				}
				_actorBodytypeE3 = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("masterNodeRef")] 
		public NodeRef MasterNodeRef
		{
			get
			{
				if (_masterNodeRef == null)
				{
					_masterNodeRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "masterNodeRef", cr2w, this);
				}
				return _masterNodeRef;
			}
			set
			{
				if (_masterNodeRef == value)
				{
					return;
				}
				_masterNodeRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("enabledWhenMasterOccupied")] 
		public CBool EnabledWhenMasterOccupied
		{
			get
			{
				if (_enabledWhenMasterOccupied == null)
				{
					_enabledWhenMasterOccupied = (CBool) CR2WTypeManager.Create("Bool", "enabledWhenMasterOccupied", cr2w, this);
				}
				return _enabledWhenMasterOccupied;
			}
			set
			{
				if (_enabledWhenMasterOccupied == value)
				{
					return;
				}
				_enabledWhenMasterOccupied = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("snapToGround")] 
		public CBool SnapToGround
		{
			get
			{
				if (_snapToGround == null)
				{
					_snapToGround = (CBool) CR2WTypeManager.Create("Bool", "snapToGround", cr2w, this);
				}
				return _snapToGround;
			}
			set
			{
				if (_snapToGround == value)
				{
					return;
				}
				_snapToGround = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("useClippingSpace")] 
		public CBool UseClippingSpace
		{
			get
			{
				if (_useClippingSpace == null)
				{
					_useClippingSpace = (CBool) CR2WTypeManager.Create("Bool", "useClippingSpace", cr2w, this);
				}
				return _useClippingSpace;
			}
			set
			{
				if (_useClippingSpace == value)
				{
					return;
				}
				_useClippingSpace = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("clippingSpaceOrientation")] 
		public CFloat ClippingSpaceOrientation
		{
			get
			{
				if (_clippingSpaceOrientation == null)
				{
					_clippingSpaceOrientation = (CFloat) CR2WTypeManager.Create("Float", "clippingSpaceOrientation", cr2w, this);
				}
				return _clippingSpaceOrientation;
			}
			set
			{
				if (_clippingSpaceOrientation == value)
				{
					return;
				}
				_clippingSpaceOrientation = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("clippingSpaceRange")] 
		public CFloat ClippingSpaceRange
		{
			get
			{
				if (_clippingSpaceRange == null)
				{
					_clippingSpaceRange = (CFloat) CR2WTypeManager.Create("Float", "clippingSpaceRange", cr2w, this);
				}
				return _clippingSpaceRange;
			}
			set
			{
				if (_clippingSpaceRange == value)
				{
					return;
				}
				_clippingSpaceRange = value;
				PropertySet(this);
			}
		}

		public AIActionSpot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
