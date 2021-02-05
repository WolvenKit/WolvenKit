using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SkillCheckPrereq : DevelopmentCheckPrereq
	{
		[Ordinal(0)]  [RED("requiredLevel")] public CFloat RequiredLevel { get; set; }
		[Ordinal(1)]  [RED("skillToCheck")] public CEnum<gamedataProficiencyType> SkillToCheck { get; set; }

		public SkillCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
