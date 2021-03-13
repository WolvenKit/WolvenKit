using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkTextKiroshiAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] [RED("timeToSkip")] public CFloat TimeToSkip { get; set; }
		[Ordinal(9)] [RED("nativeText")] public CString NativeText { get; set; }
		[Ordinal(10)] [RED("preTranslatedTextWidget")] public inkTextWidgetReference PreTranslatedTextWidget { get; set; }
		[Ordinal(11)] [RED("postTranslatedTextWidget")] public inkTextWidgetReference PostTranslatedTextWidget { get; set; }
		[Ordinal(12)] [RED("nativeTextWidget")] public inkRichTextBoxWidgetReference NativeTextWidget { get; set; }
		[Ordinal(13)] [RED("translatedTextWidget")] public inkTextWidgetReference TranslatedTextWidget { get; set; }

		public inkTextKiroshiAnimationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
