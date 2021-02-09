using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AccessBreach : PuppetAction
	{
		[Ordinal(22)]  [RED("attempt")] public CInt32 Attempt { get; set; }
		[Ordinal(23)]  [RED("networkName")] public CString NetworkName { get; set; }
		[Ordinal(24)]  [RED("npcCount")] public CInt32 NpcCount { get; set; }
		[Ordinal(25)]  [RED("isRemote")] public CBool IsRemote { get; set; }
		[Ordinal(26)]  [RED("isSuicide")] public CBool IsSuicide { get; set; }

		public AccessBreach(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
