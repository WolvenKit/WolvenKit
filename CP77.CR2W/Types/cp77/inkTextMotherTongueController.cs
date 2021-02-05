using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkTextMotherTongueController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("preTranslatedTextWidget")] public inkTextWidgetReference PreTranslatedTextWidget { get; set; }
		[Ordinal(1)]  [RED("postTranslatedTextWidget")] public inkTextWidgetReference PostTranslatedTextWidget { get; set; }
		[Ordinal(2)]  [RED("nativeTextWidget")] public inkRichTextBoxWidgetReference NativeTextWidget { get; set; }
		[Ordinal(3)]  [RED("translatedTextWidget")] public inkTextWidgetReference TranslatedTextWidget { get; set; }

		public inkTextMotherTongueController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
