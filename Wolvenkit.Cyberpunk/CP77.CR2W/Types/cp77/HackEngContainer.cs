using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class HackEngContainer : BaseSkillCheckContainer
	{
		[Ordinal(0)]  [RED("engineeringCheck")] public CHandle<EngineeringSkillCheck> EngineeringCheck { get; set; }
		[Ordinal(1)]  [RED("hackingCheck")] public CHandle<HackingSkillCheck> HackingCheck { get; set; }

		public HackEngContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
