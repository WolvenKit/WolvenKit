using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameMovingPlatformArrivedAt : redEvent
	{
		[Ordinal(0)] 
		[RED("destinationName")] 
		public CName DestinationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("data")] 
		public CInt32 Data
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		public gameMovingPlatformArrivedAt()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
