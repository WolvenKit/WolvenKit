using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameJournalCodexGroup : gameJournalContainerEntry
	{
		[Ordinal(0)]  [RED("groupName")] public LocalizationString GroupName { get; set; }

		public gameJournalCodexGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
