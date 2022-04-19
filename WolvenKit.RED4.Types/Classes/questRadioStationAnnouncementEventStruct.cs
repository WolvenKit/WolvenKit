using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questRadioStationAnnouncementEventStruct : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("announcementScene")] 
		public CResourceAsyncReference<scnSceneResource> AnnouncementScene
		{
			get => GetPropertyValue<CResourceAsyncReference<scnSceneResource>>();
			set => SetPropertyValue<CResourceAsyncReference<scnSceneResource>>(value);
		}

		[Ordinal(1)] 
		[RED("sceneInput")] 
		public CName SceneInput
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("queueAnnouncement")] 
		public CBool QueueAnnouncement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("blockSignal")] 
		public CBool BlockSignal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get => GetPropertyValue<CEnum<audioRadioSpeakerType>>();
			set => SetPropertyValue<CEnum<audioRadioSpeakerType>>(value);
		}

		public questRadioStationAnnouncementEventStruct()
		{
			SceneInput = "vo_init";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
