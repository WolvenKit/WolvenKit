using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
	{
		[Ordinal(0)]  [RED("level")] public CEnum<ESecurityAccessLevel> Level { get; set; }

		public SecurityAccessLevelEntryClient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
