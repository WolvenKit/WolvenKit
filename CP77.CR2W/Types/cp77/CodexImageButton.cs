using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexImageButton : CodexListItemController
	{
		[Ordinal(4)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(5)]  [RED("border")] public inkImageWidgetReference Border { get; set; }
		[Ordinal(6)]  [RED("translateOnSelect")] public inkWidgetReference TranslateOnSelect { get; set; }
		[Ordinal(7)]  [RED("selectTranslationX")] public CFloat SelectTranslationX { get; set; }

		public CodexImageButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
