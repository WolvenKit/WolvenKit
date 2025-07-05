using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ElevatorFloorSetup : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("isHidden")] 
		public CBool IsHidden
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("isInactive")] 
		public CBool IsInactive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("floorMarker")] 
		public NodeRef FloorMarker
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(3)] 
		[RED("floorName")] 
		public CString FloorName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("floorDisplayName")] 
		public CName FloorDisplayName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("authorizationTextOverride")] 
		public CString AuthorizationTextOverride
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("doorShouldOpenFrontLeftRight")] 
		public CArray<CBool> DoorShouldOpenFrontLeftRight
		{
			get => GetPropertyValue<CArray<CBool>>();
			set => SetPropertyValue<CArray<CBool>>(value);
		}

		public ElevatorFloorSetup()
		{
			DoorShouldOpenFrontLeftRight = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
