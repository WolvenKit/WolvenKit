using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformSavedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("currentLocalPosition")] 
		public Vector4 CurrentLocalPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(1)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get => GetPropertyValue<CHandle<gameIMovingPlatformMovement>>();
			set => SetPropertyValue<CHandle<gameIMovingPlatformMovement>>(value);
		}

		[Ordinal(2)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("destinationData")] 
		public CInt32 DestinationData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("mountedPlayerEntityID")] 
		public CUInt32 MountedPlayerEntityID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameMovingPlatformSavedData()
		{
			CurrentLocalPosition = new Vector4();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
