using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questRadioStationAnnouncementEventStruct : CVariable
	{
		private raRef<scnSceneResource> _announcementScene;
		private CName _sceneInput;
		private CBool _queueAnnouncement;
		private CName _radioStationName;
		private CBool _blockSignal;
		private CEnum<audioRadioSpeakerType> _speaker;

		[Ordinal(0)] 
		[RED("announcementScene")] 
		public raRef<scnSceneResource> AnnouncementScene
		{
			get => GetProperty(ref _announcementScene);
			set => SetProperty(ref _announcementScene, value);
		}

		[Ordinal(1)] 
		[RED("sceneInput")] 
		public CName SceneInput
		{
			get => GetProperty(ref _sceneInput);
			set => SetProperty(ref _sceneInput, value);
		}

		[Ordinal(2)] 
		[RED("queueAnnouncement")] 
		public CBool QueueAnnouncement
		{
			get => GetProperty(ref _queueAnnouncement);
			set => SetProperty(ref _queueAnnouncement, value);
		}

		[Ordinal(3)] 
		[RED("radioStationName")] 
		public CName RadioStationName
		{
			get => GetProperty(ref _radioStationName);
			set => SetProperty(ref _radioStationName, value);
		}

		[Ordinal(4)] 
		[RED("blockSignal")] 
		public CBool BlockSignal
		{
			get => GetProperty(ref _blockSignal);
			set => SetProperty(ref _blockSignal, value);
		}

		[Ordinal(5)] 
		[RED("speaker")] 
		public CEnum<audioRadioSpeakerType> Speaker
		{
			get => GetProperty(ref _speaker);
			set => SetProperty(ref _speaker, value);
		}

		public questRadioStationAnnouncementEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
