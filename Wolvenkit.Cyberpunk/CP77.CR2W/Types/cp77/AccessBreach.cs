using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccessBreach : PuppetAction
	{
		[Ordinal(0)]  [RED("attempt")] public CInt32 Attempt { get; set; }
		[Ordinal(1)]  [RED("isRemote")] public CBool IsRemote { get; set; }
		[Ordinal(2)]  [RED("isSuicide")] public CBool IsSuicide { get; set; }
		[Ordinal(3)]  [RED("networkName")] public CString NetworkName { get; set; }
		[Ordinal(4)]  [RED("npcCount")] public CInt32 NpcCount { get; set; }

		public AccessBreach(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
