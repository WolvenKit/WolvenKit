using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextReplaceAnimationController : inkTextAnimationController
	{
		[Ordinal(0)]  [RED("widgetTextUsage")] public CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> WidgetTextUsage { get; set; }
		[Ordinal(1)]  [RED("targetText")] public CString TargetText { get; set; }
		[Ordinal(2)]  [RED("baseTextLocalized")] public LocalizationString BaseTextLocalized { get; set; }
		[Ordinal(3)]  [RED("targetTextLocalized")] public LocalizationString TargetTextLocalized { get; set; }
		[Ordinal(4)]  [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }

		public inkTextReplaceAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
