using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PerksSkillLabelContentContainer : HubMenuLabelContentContainer
	{
		[Ordinal(0)]  [RED("label")] public inkTextWidgetReference Label { get; set; }
		[Ordinal(1)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(2)]  [RED("desiredSizeWrapper")] public inkWidgetReference DesiredSizeWrapper { get; set; }
		[Ordinal(3)]  [RED("border")] public inkBorderWidgetReference Border { get; set; }
		[Ordinal(4)]  [RED("carouselPosition")] public CInt32 CarouselPosition { get; set; }
		[Ordinal(5)]  [RED("labelName")] public CString LabelName { get; set; }
		[Ordinal(6)]  [RED("data")] public MenuData Data { get; set; }
		[Ordinal(7)]  [RED("levelLabel")] public inkTextWidgetReference LevelLabel { get; set; }
		[Ordinal(8)]  [RED("levelBar")] public inkWidgetReference LevelBar { get; set; }
		[Ordinal(9)]  [RED("skillData")] public CHandle<ProficiencyDisplayData> SkillData { get; set; }

		public PerksSkillLabelContentContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
