using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksSkillsLevelsContainerController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("topRowItemsContainer")] public inkCompoundWidgetReference TopRowItemsContainer { get; set; }
		[Ordinal(2)] [RED("bottomRowItemsContainer")] public inkCompoundWidgetReference BottomRowItemsContainer { get; set; }
		[Ordinal(3)] [RED("levelBar")] public inkWidgetReference LevelBar { get; set; }
		[Ordinal(4)] [RED("levelBarSpacer")] public inkWidgetReference LevelBarSpacer { get; set; }
		[Ordinal(5)] [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(6)] [RED("proficiencyDisplayData")] public CHandle<ProficiencyDisplayData> ProficiencyDisplayData { get; set; }

		public PerksSkillsLevelsContainerController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
