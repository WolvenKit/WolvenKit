using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CodexImageButton : CodexListItemController
	{
		[Ordinal(0)]  [RED("border")] public inkImageWidgetReference Border { get; set; }
		[Ordinal(1)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(2)]  [RED("selectTranslationX")] public CFloat SelectTranslationX { get; set; }
		[Ordinal(3)]  [RED("translateOnSelect")] public inkWidgetReference TranslateOnSelect { get; set; }

		public CodexImageButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
