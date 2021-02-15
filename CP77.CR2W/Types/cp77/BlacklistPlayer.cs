using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BlacklistPlayer : redEvent
	{
		[Ordinal(0)] [RED("blacklist")] public CBool Blacklist { get; set; }
		[Ordinal(1)] [RED("reason")] public CEnum<BlacklistReason> Reason { get; set; }
		[Ordinal(2)] [RED("forceRemoveAuthorization")] public CBool ForceRemoveAuthorization { get; set; }

		public BlacklistPlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
