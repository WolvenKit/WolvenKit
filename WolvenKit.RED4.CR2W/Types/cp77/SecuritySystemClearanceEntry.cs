using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SecuritySystemClearanceEntry : CVariable
	{
		[Ordinal(0)] [RED("user")] public entEntityID User { get; set; }
		[Ordinal(1)] [RED("level")] public CEnum<ESecurityAccessLevel> Level { get; set; }

		public SecuritySystemClearanceEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
