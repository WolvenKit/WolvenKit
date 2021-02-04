using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextKiroshiAnimationController : inkTextAnimationController
	{
		[Ordinal(0)]  [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }
		[Ordinal(1)]  [RED("nativeText")] public CString NativeText { get; set; }
		[Ordinal(2)]  [RED("preTranslatedTextWidget")] public inkTextWidgetReference PreTranslatedTextWidget { get; set; }
		[Ordinal(3)]  [RED("postTranslatedTextWidget")] public inkTextWidgetReference PostTranslatedTextWidget { get; set; }
		[Ordinal(4)]  [RED("nativeTextWidget")] public inkRichTextBoxWidgetReference NativeTextWidget { get; set; }
		[Ordinal(5)]  [RED("translatedTextWidget")] public inkTextWidgetReference TranslatedTextWidget { get; set; }

		public inkTextKiroshiAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
