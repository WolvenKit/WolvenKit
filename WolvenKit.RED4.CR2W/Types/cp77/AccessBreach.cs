using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccessBreach : PuppetAction
	{
		[Ordinal(25)] [RED("attempt")] public CInt32 Attempt { get; set; }
		[Ordinal(26)] [RED("networkName")] public CString NetworkName { get; set; }
		[Ordinal(27)] [RED("npcCount")] public CInt32 NpcCount { get; set; }
		[Ordinal(28)] [RED("isRemote")] public CBool IsRemote { get; set; }
		[Ordinal(29)] [RED("isSuicide")] public CBool IsSuicide { get; set; }

		public AccessBreach(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
