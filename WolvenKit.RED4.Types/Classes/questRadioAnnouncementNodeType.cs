using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRadioAnnouncementNodeType : questIAudioNodeType
	{
		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<questRadioStationAnnouncementEventStruct> RadioStationEvents
		{
			get => GetPropertyValue<CArray<questRadioStationAnnouncementEventStruct>>();
			set => SetPropertyValue<CArray<questRadioStationAnnouncementEventStruct>>(value);
		}

		public questRadioAnnouncementNodeType()
		{
			RadioStationEvents = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
