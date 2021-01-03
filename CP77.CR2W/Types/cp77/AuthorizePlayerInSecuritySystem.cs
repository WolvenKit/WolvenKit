using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AuthorizePlayerInSecuritySystem : redEvent
	{
		[Ordinal(0)]  [RED("ESL")] public CEnum<ESecurityAccessLevel> ESL { get; set; }
		[Ordinal(1)]  [RED("authorize")] public CBool Authorize { get; set; }
		[Ordinal(2)]  [RED("forceRemoveFromBlacklist")] public CBool ForceRemoveFromBlacklist { get; set; }

		public AuthorizePlayerInSecuritySystem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
