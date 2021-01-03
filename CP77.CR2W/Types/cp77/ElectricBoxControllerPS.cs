using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("isOverriden")] public CBool IsOverriden { get; set; }
		[Ordinal(1)]  [RED("questFactSetup")] public ComputerQuickHackData QuestFactSetup { get; set; }
		[Ordinal(2)]  [RED("techieSkillChecks")] public CHandle<EngineeringContainer> TechieSkillChecks { get; set; }

		public ElectricBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
