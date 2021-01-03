using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questJournalChangeMappinPhase_NodeType : questIJournal_NodeType
	{
		[Ordinal(0)]  [RED("notifyUI")] public CBool NotifyUI { get; set; }
		[Ordinal(1)]  [RED("path")] public CHandle<gameJournalPath> Path { get; set; }
		[Ordinal(2)]  [RED("phase")] public CEnum<gamedataMappinPhase> Phase { get; set; }

		public questJournalChangeMappinPhase_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
