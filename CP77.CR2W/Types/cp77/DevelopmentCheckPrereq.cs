using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DevelopmentCheckPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] [RED("requiredLevel")] public CFloat RequiredLevel { get; set; }

		public DevelopmentCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
