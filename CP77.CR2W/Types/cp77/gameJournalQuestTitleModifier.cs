using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalQuestTitleModifier : gameJournalEntry
	{
		[Ordinal(0)]  [RED("title")] public LocalizationString Title { get; set; }

		public gameJournalQuestTitleModifier(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
