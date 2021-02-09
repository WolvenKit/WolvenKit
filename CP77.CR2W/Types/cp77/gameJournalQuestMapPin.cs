using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(0)]  [RED("reference")] public gameEntityReference Reference { get; set; }
        [Ordinal(1)] [RED("slotName")] public CName SlotName { get; set; }
        [Ordinal(2)] [RED("mappinData")] public gamemappinsMappinData MappinData { get; set; }
        [Ordinal(3)] [RED("offset")] public Vector3 Offset { get; set; }
        [Ordinal(4)] [RED("uiAnimation")] public TweakDBID UiAnimation { get; set; }

		public gameJournalQuestMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
