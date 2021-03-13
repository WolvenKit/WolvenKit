using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMappinVariantChangedEvent : redEvent
	{
		[Ordinal(0)] [RED("entry")] public wCHandle<gameJournalEntry> Entry { get; set; }
		[Ordinal(1)] [RED("phase")] public CEnum<gamedataMappinPhase> Phase { get; set; }
		[Ordinal(2)] [RED("variant")] public CEnum<gamedataMappinVariant> Variant { get; set; }

		public questMappinVariantChangedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
