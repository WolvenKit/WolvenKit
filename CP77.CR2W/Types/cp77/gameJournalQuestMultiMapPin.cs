using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMultiMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(3)] [RED("references")] public CArray<NodeRef> References { get; set; }
		[Ordinal(4)] [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(5)] [RED("mappinData")] public gamemappinsMappinData MappinData { get; set; }
		[Ordinal(6)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(7)] [RED("uiAnimation")] public TweakDBID UiAnimation { get; set; }

		public gameJournalQuestMultiMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
