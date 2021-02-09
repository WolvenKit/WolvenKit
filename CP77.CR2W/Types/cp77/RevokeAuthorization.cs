using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class RevokeAuthorization : redEvent
	{
		[Ordinal(0)]  [RED("user")] public entEntityID User { get; set; }
		[Ordinal(1)]  [RED("level")] public CEnum<ESecurityAccessLevel> Level { get; set; }

		public RevokeAuthorization(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
