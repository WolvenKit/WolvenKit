using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElevatorFloorSetup : CVariable
	{
		private CBool _isHidden;
		private CBool _isInactive;
		private NodeRef _floorMarker;
		private CString _floorName;
		private CName _floorDisplayName;
		private CString _authorizationTextOverride;
		private CArray<CBool> _doorShouldOpenFrontLeftRight;

		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get
			{
				if (_isHidden == null)
				{
					_isHidden = (CBool) CR2WTypeManager.Create("Bool", "isHidden", cr2w, this);
				}
				return _isHidden;
			}
			set
			{
				if (_isHidden == value)
				{
					return;
				}
				_isHidden = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get
			{
				if (_isInactive == null)
				{
					_isInactive = (CBool) CR2WTypeManager.Create("Bool", "isInactive", cr2w, this);
				}
				return _isInactive;
			}
			set
			{
				if (_isInactive == value)
				{
					return;
				}
				_isInactive = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("floorMarker")] 
		public NodeRef FloorMarker
		{
			get
			{
				if (_floorMarker == null)
				{
					_floorMarker = (NodeRef) CR2WTypeManager.Create("NodeRef", "floorMarker", cr2w, this);
				}
				return _floorMarker;
			}
			set
			{
				if (_floorMarker == value)
				{
					return;
				}
				_floorMarker = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("floorName")] 
		public CString FloorName
		{
			get
			{
				if (_floorName == null)
				{
					_floorName = (CString) CR2WTypeManager.Create("String", "floorName", cr2w, this);
				}
				return _floorName;
			}
			set
			{
				if (_floorName == value)
				{
					return;
				}
				_floorName = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("floorDisplayName")] 
		public CName FloorDisplayName
		{
			get
			{
				if (_floorDisplayName == null)
				{
					_floorDisplayName = (CName) CR2WTypeManager.Create("CName", "floorDisplayName", cr2w, this);
				}
				return _floorDisplayName;
			}
			set
			{
				if (_floorDisplayName == value)
				{
					return;
				}
				_floorDisplayName = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get
			{
				if (_authorizationTextOverride == null)
				{
					_authorizationTextOverride = (CString) CR2WTypeManager.Create("String", "authorizationTextOverride", cr2w, this);
				}
				return _authorizationTextOverride;
			}
			set
			{
				if (_authorizationTextOverride == value)
				{
					return;
				}
				_authorizationTextOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("doorShouldOpenFrontLeftRight")] 
		public CArray<CBool> DoorShouldOpenFrontLeftRight
		{
			get
			{
				if (_doorShouldOpenFrontLeftRight == null)
				{
					_doorShouldOpenFrontLeftRight = (CArray<CBool>) CR2WTypeManager.Create("array:Bool", "doorShouldOpenFrontLeftRight", cr2w, this);
				}
				return _doorShouldOpenFrontLeftRight;
			}
			set
			{
				if (_doorShouldOpenFrontLeftRight == value)
				{
					return;
				}
				_doorShouldOpenFrontLeftRight = value;
				PropertySet(this);
			}
		}

		public ElevatorFloorSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
