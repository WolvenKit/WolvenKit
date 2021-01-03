using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalOnscreen : gameJournalEntry
	{
		[Ordinal(0)]  [RED("description")] public LocalizationString Description { get; set; }
		[Ordinal(1)]  [RED("iconID")] public TweakDBID IconID { get; set; }
		[Ordinal(2)]  [RED("tag")] public CName Tag { get; set; }
		[Ordinal(3)]  [RED("title")] public LocalizationString Title { get; set; }

		public gameJournalOnscreen(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
