using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		[Ordinal(0)]  [RED("levelBar")] public inkWidgetReference LevelBar { get; set; }
		[Ordinal(1)]  [RED("levelLabel")] public inkTextWidgetReference LevelLabel { get; set; }
		[Ordinal(2)]  [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public PerksSkillLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
