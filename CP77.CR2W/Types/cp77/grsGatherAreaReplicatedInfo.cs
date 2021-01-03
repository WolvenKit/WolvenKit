using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class grsGatherAreaReplicatedInfo : CVariable
	{
		[Ordinal(0)]  [RED("enabled")] public CBool Enabled { get; set; }
		[Ordinal(1)]  [RED("enteredPlayerIDs", 7)] public CStatic<netPeerID> EnteredPlayerIDs { get; set; }
		[Ordinal(2)]  [RED("hasActiveQuestListener")] public CBool HasActiveQuestListener { get; set; }

		public grsGatherAreaReplicatedInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
