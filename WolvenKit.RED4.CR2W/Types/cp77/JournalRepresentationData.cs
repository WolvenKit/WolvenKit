using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class JournalRepresentationData : ListItemData
	{
		[Ordinal(1)] [RED("Data")] public wCHandle<gameJournalEntry> Data { get; set; }
		[Ordinal(2)] [RED("OnscreenData")] public wCHandle<gameJournalOnscreensStructuredGroup> OnscreenData { get; set; }
		[Ordinal(3)] [RED("Reference")] public wCHandle<inkWidget> Reference { get; set; }
		[Ordinal(4)] [RED("IsNew")] public CBool IsNew { get; set; }

		public JournalRepresentationData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
