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
			get => GetProperty(ref _isHidden);
			set => SetProperty(ref _isHidden, value);
		}

		[Ordinal(1)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetProperty(ref _isInactive);
			set => SetProperty(ref _isInactive, value);
		}

		[Ordinal(2)] 
		[RED("floorMarker")] 
		public NodeRef FloorMarker
		{
			get => GetProperty(ref _floorMarker);
			set => SetProperty(ref _floorMarker, value);
		}

		[Ordinal(3)] 
		[RED("floorName")] 
		public CString FloorName
		{
			get => GetProperty(ref _floorName);
			set => SetProperty(ref _floorName, value);
		}

		[Ordinal(4)] 
		[RED("floorDisplayName")] 
		public CName FloorDisplayName
		{
			get => GetProperty(ref _floorDisplayName);
			set => SetProperty(ref _floorDisplayName, value);
		}

		[Ordinal(5)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get => GetProperty(ref _authorizationTextOverride);
			set => SetProperty(ref _authorizationTextOverride, value);
		}

		[Ordinal(6)] 
		[RED("doorShouldOpenFrontLeftRight")] 
		public CArray<CBool> DoorShouldOpenFrontLeftRight
		{
			get => GetProperty(ref _doorShouldOpenFrontLeftRight);
			set => SetProperty(ref _doorShouldOpenFrontLeftRight, value);
		}

		public ElevatorFloorSetup(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
