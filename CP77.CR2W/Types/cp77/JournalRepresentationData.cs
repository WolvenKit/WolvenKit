using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class JournalRepresentationData : ListItemData
	{
		[Ordinal(0)]  [RED("Data")] public wCHandle<gameJournalEntry> Data { get; set; }
		[Ordinal(1)]  [RED("IsNew")] public CBool IsNew { get; set; }
		[Ordinal(2)]  [RED("OnscreenData")] public wCHandle<gameJournalOnscreensStructuredGroup> OnscreenData { get; set; }
		[Ordinal(3)]  [RED("Reference")] public wCHandle<inkWidget> Reference { get; set; }

		public JournalRepresentationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
