using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecurityAccessLevelEntryClient : SecurityAccessLevelEntry
	{
		[Ordinal(2)] [RED("level")] public CEnum<ESecurityAccessLevel> Level { get; set; }

		public SecurityAccessLevelEntryClient(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
