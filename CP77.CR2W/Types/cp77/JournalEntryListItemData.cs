using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class JournalEntryListItemData : IScriptable
	{
		[Ordinal(0)]  [RED("entry")] public wCHandle<gameJournalEntry> Entry { get; set; }
		[Ordinal(1)]  [RED("extraData")] public CHandle<IScriptable> ExtraData { get; set; }

		public JournalEntryListItemData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
