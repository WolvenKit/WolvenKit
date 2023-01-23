using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class vehicleRadioStationChanged : redEvent
	{
		[Ordinal(0)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("radioIndex")] 
		public CUInt32 RadioIndex
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(2)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(3)] 
		[RED("radioSongName")] 
		public CName RadioSongName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public vehicleRadioStationChanged()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
