using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questJournalChangeMappinPhase_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)] [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(1)] [RED("phase")] public CEnum<gamedataMappinPhase> Phase { get; set; }
		[Ordinal(2)] [RED("notifyUI")] public CBool NotifyUI { get; set; }

		public questJournalChangeMappinPhase_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
