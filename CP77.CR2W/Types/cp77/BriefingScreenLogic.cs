using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class BriefingScreenLogic : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("lastSizeSet")] public Vector2 LastSizeSet { get; set; }
		[Ordinal(1)]  [RED("isBriefingVisible")] public CBool IsBriefingVisible { get; set; }
		[Ordinal(2)]  [RED("briefingToOpen")] public wCHandle<gameJournalEntry> BriefingToOpen { get; set; }
		[Ordinal(3)]  [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(4)]  [RED("mapWidget")] public inkWidgetReference MapWidget { get; set; }
		[Ordinal(5)]  [RED("paperdollWidget")] public inkWidgetReference PaperdollWidget { get; set; }
		[Ordinal(6)]  [RED("animatedWidget")] public inkWidgetReference AnimatedWidget { get; set; }
		[Ordinal(7)]  [RED("fadeDuration")] public CFloat FadeDuration { get; set; }
		[Ordinal(8)]  [RED("InterpolationType")] public CEnum<inkanimInterpolationType> InterpolationType { get; set; }
		[Ordinal(9)]  [RED("InterpolationMode")] public CEnum<inkanimInterpolationMode> InterpolationMode { get; set; }
		[Ordinal(10)]  [RED("minimizedSize")] public Vector2 MinimizedSize { get; set; }
		[Ordinal(11)]  [RED("maximizedSize")] public Vector2 MaximizedSize { get; set; }

		public BriefingScreenLogic(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
