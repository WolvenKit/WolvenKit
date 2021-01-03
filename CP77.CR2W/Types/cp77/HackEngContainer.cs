using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class HackEngContainer : BaseSkillCheckContainer
	{
		[Ordinal(0)]  [RED("engineeringCheck")] public CHandle<EngineeringSkillCheck> EngineeringCheck { get; set; }
		[Ordinal(1)]  [RED("hackingCheck")] public CHandle<HackingSkillCheck> HackingCheck { get; set; }

		public HackEngContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
