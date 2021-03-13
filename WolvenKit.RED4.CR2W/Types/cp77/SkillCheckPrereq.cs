using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SkillCheckPrereq : DevelopmentCheckPrereq
	{
		[Ordinal(1)] [RED("skillToCheck")] public CEnum<gamedataProficiencyType> SkillToCheck { get; set; }

		public SkillCheckPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
