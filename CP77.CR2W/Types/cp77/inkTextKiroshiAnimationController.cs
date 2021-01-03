using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkTextKiroshiAnimationController : inkTextAnimationController
	{
		[Ordinal(0)]  [RED("nativeText")] public CString NativeText { get; set; }
		[Ordinal(1)]  [RED("nativeTextWidget")] public inkRichTextBoxWidgetReference NativeTextWidget { get; set; }
		[Ordinal(2)]  [RED("postTranslatedTextWidget")] public inkTextWidgetReference PostTranslatedTextWidget { get; set; }
		[Ordinal(3)]  [RED("preTranslatedTextWidget")] public inkTextWidgetReference PreTranslatedTextWidget { get; set; }
		[Ordinal(4)]  [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }
		[Ordinal(5)]  [RED("translatedTextWidget")] public inkTextWidgetReference TranslatedTextWidget { get; set; }

		public inkTextKiroshiAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
