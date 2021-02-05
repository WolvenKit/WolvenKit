using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EngineeringContainer : BaseSkillCheckContainer
	{
		[Ordinal(0)]  [RED("hackingCheckSlot")] public CHandle<HackingSkillCheck> HackingCheckSlot { get; set; }
		[Ordinal(1)]  [RED("engineeringCheckSlot")] public CHandle<EngineeringSkillCheck> EngineeringCheckSlot { get; set; }
		[Ordinal(2)]  [RED("demolitionCheckSlot")] public CHandle<DemolitionSkillCheck> DemolitionCheckSlot { get; set; }
		[Ordinal(3)]  [RED("engineeringCheck")] public CHandle<EngineeringSkillCheck> EngineeringCheck { get; set; }

		public EngineeringContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
