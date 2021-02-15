using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextReplaceAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }
		[Ordinal(9)] [RED("widgetTextUsage")] public CEnum<inkTextReplaceAnimationControllerWidgetTextUsage> WidgetTextUsage { get; set; }
		[Ordinal(10)] [RED("baseTextLocalized")] public LocalizationString BaseTextLocalized { get; set; }
		[Ordinal(11)] [RED("targetText")] public CString TargetText { get; set; }
		[Ordinal(12)] [RED("targetTextLocalized")] public LocalizationString TargetTextLocalized { get; set; }

		public inkTextReplaceAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
