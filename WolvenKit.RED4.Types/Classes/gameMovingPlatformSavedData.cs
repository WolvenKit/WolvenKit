using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformSavedData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("movement")] 
		public CHandle<gameIMovingPlatformMovement> Movement
		{
			get => GetPropertyValue<CHandle<gameIMovingPlatformMovement>>();
			set => SetPropertyValue<CHandle<gameIMovingPlatformMovement>>(value);
		}

		[Ordinal(1)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("destinationData")] 
		public CInt32 DestinationData
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("maxTime")] 
		public CFloat MaxTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("mountedPlayerEntityID")] 
		public CUInt32 MountedPlayerEntityID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public gameMovingPlatformSavedData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
