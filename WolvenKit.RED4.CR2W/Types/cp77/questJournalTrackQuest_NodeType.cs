using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalTrackQuest_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }

		public questJournalTrackQuest_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
