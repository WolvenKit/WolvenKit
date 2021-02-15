using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HackEngContainer : BaseSkillCheckContainer
	{
		[Ordinal(3)] [RED("hackingCheck")] public CHandle<HackingSkillCheck> HackingCheck { get; set; }
		[Ordinal(4)] [RED("engineeringCheck")] public CHandle<EngineeringSkillCheck> EngineeringCheck { get; set; }

		public HackEngContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
