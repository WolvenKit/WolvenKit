using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class BlacklistPlayer : redEvent
	{
		[Ordinal(0)]  [RED("blacklist")] public CBool Blacklist { get; set; }
		[Ordinal(1)]  [RED("forceRemoveAuthorization")] public CBool ForceRemoveAuthorization { get; set; }
		[Ordinal(2)]  [RED("reason")] public CEnum<BlacklistReason> Reason { get; set; }

		public BlacklistPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
