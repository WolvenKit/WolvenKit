using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PlatformControllerPS : ScriptableDeviceComponentPS
	{
		[Ordinal(107)] 
		[RED("floors")] 
		public CArray<NodeRef> Floors
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(108)] 
		[RED("startingFloor")] 
		public CInt32 StartingFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(109)] 
		[RED("speed")] 
		public CFloat Speed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(110)] 
		[RED("curve")] 
		public CName Curve
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(111)] 
		[RED("errorMSG")] 
		public CString ErrorMSG
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(112)] 
		[RED("nextFloor")] 
		public CInt32 NextFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(113)] 
		[RED("prevFloor")] 
		public CInt32 PrevFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(114)] 
		[RED("destinationFloor")] 
		public CInt32 DestinationFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(115)] 
		[RED("currentFloor")] 
		public CInt32 CurrentFloor
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(116)] 
		[RED("isPlayerOnPlatform")] 
		public CBool IsPlayerOnPlatform
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(117)] 
		[RED("isMoving")] 
		public CBool IsMoving
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(118)] 
		[RED("paused")] 
		public CBool Paused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(119)] 
		[RED("pausingTime")] 
		public CFloat PausingTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public PlatformControllerPS()
		{
			Floors = new();
			Speed = 0.500000F;
			Curve = "cosine";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
