using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questRadioAnnouncementNodeType : questIAudioNodeType
	{
		private CArray<questRadioStationAnnouncementEventStruct> _radioStationEvents;

		[Ordinal(0)] 
		[RED("radioStationEvents")] 
		public CArray<questRadioStationAnnouncementEventStruct> RadioStationEvents
		{
			get => GetProperty(ref _radioStationEvents);
			set => SetProperty(ref _radioStationEvents, value);
		}
	}
}
