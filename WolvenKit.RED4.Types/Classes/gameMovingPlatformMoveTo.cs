using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformMoveTo : redEvent
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
		[RED("data")] 
		public CInt32 Data
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameMovingPlatformMoveTo()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
