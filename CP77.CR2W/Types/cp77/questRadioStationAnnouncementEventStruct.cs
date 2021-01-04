using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRadioStationAnnouncementEventStruct : CVariable
	{
		[Ordinal(0)]  [RED("announcementScene")] public raRef<scnSceneResource> AnnouncementScene { get; set; }
		[Ordinal(1)]  [RED("blockSignal")] public CBool BlockSignal { get; set; }
		[Ordinal(2)]  [RED("queueAnnouncement")] public CBool QueueAnnouncement { get; set; }
		[Ordinal(3)]  [RED("radioStationName")] public CName RadioStationName { get; set; }
		[Ordinal(4)]  [RED("sceneInput")] public CName SceneInput { get; set; }
		[Ordinal(5)]  [RED("speaker")] public CEnum<audioRadioSpeakerType> Speaker { get; set; }

		public questRadioStationAnnouncementEventStruct(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
