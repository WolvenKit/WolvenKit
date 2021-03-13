using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ElectricBoxControllerPS : MasterControllerPS
	{
		[Ordinal(104)] [RED("techieSkillChecks")] public CHandle<EngineeringContainer> TechieSkillChecks { get; set; }
		[Ordinal(105)] [RED("questFactSetup")] public ComputerQuickHackData QuestFactSetup { get; set; }
		[Ordinal(106)] [RED("isOverriden")] public CBool IsOverriden { get; set; }

		public ElectricBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
