using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameMountDescriptor : CVariable
	{
		private entEntityID _parentId;
		private CName _slotName;
		private Transform _initialTransform;
		private CEnum<gamePuppetVehicleState> _state;
		private CEnum<gameMountDescriptorMountType> _mountType;

		[Ordinal(0)] 
		[RED("parentId")] 
		public entEntityID ParentId
		{
			get
			{
				if (_parentId == null)
				{
					_parentId = (entEntityID) CR2WTypeManager.Create("entEntityID", "parentId", cr2w, this);
				}
				return _parentId;
			}
			set
			{
				if (_parentId == value)
				{
					return;
				}
				_parentId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("initialTransform")] 
		public Transform InitialTransform
		{
			get
			{
				if (_initialTransform == null)
				{
					_initialTransform = (Transform) CR2WTypeManager.Create("Transform", "initialTransform", cr2w, this);
				}
				return _initialTransform;
			}
			set
			{
				if (_initialTransform == value)
				{
					return;
				}
				_initialTransform = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("state")] 
		public CEnum<gamePuppetVehicleState> State
		{
			get
			{
				if (_state == null)
				{
					_state = (CEnum<gamePuppetVehicleState>) CR2WTypeManager.Create("gamePuppetVehicleState", "state", cr2w, this);
				}
				return _state;
			}
			set
			{
				if (_state == value)
				{
					return;
				}
				_state = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mountType")] 
		public CEnum<gameMountDescriptorMountType> MountType
		{
			get
			{
				if (_mountType == null)
				{
					_mountType = (CEnum<gameMountDescriptorMountType>) CR2WTypeManager.Create("gameMountDescriptorMountType", "mountType", cr2w, this);
				}
				return _mountType;
			}
			set
			{
				if (_mountType == value)
				{
					return;
				}
				_mountType = value;
				PropertySet(this);
			}
		}

		public gameMountDescriptor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
