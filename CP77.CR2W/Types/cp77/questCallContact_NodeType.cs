using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCallContact_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)]  [RED("addressee")] public CHandle<gameJournalPath> Addressee { get; set; }
		[Ordinal(1)]  [RED("applyPhoneRestriction")] public CBool ApplyPhoneRestriction { get; set; }
		[Ordinal(2)]  [RED("caller")] public CHandle<gameJournalPath> Caller { get; set; }
		[Ordinal(3)]  [RED("mode")] public CEnum<questPhoneCallMode> Mode { get; set; }
		[Ordinal(4)]  [RED("phase")] public CEnum<questPhoneCallPhase> Phase { get; set; }
		[Ordinal(5)]  [RED("prefabNodeRef")] public NodeRef PrefabNodeRef { get; set; }

		public questCallContact_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
