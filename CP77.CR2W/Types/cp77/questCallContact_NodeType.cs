using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
		[Ordinal(1)] [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }
		[Ordinal(2)] [RED("phase")] public CEnum<questPhoneCallPhase> Phase { get; set; }
		[Ordinal(3)] [RED("mode")] public CEnum<questPhoneCallMode> Mode { get; set; }
		[Ordinal(4)] [RED("prefabNodeRef")] public NodeRef PrefabNodeRef { get; set; }
		[Ordinal(5)] [RED("applyPhoneRestriction")] public CBool ApplyPhoneRestriction { get; set; }

		public questCallContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
