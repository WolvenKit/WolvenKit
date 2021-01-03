using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestMultiMapPin : gameJournalQuestMapPinBase
	{
		[Ordinal(0)]  [RED("mappinData")] public gamemappinsMappinData MappinData { get; set; }
		[Ordinal(1)]  [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(2)]  [RED("references")] public CArray<NodeRef> References { get; set; }
		[Ordinal(3)]  [RED("slotName")] public CName SlotName { get; set; }
		[Ordinal(4)]  [RED("uiAnimation")] public TweakDBID UiAnimation { get; set; }

		public gameJournalQuestMultiMapPin(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
