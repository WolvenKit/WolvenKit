using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CodexImageButton : CodexListItemController
	{
		[Ordinal(0)]  [RED("labelPathRef")] public inkTextWidgetReference LabelPathRef { get; set; }
		[Ordinal(1)]  [RED("doMarkNew")] public CBool DoMarkNew { get; set; }
		[Ordinal(2)]  [RED("stateMapperRef")] public inkWidgetReference StateMapperRef { get; set; }
		[Ordinal(3)]  [RED("stateMapper")] public wCHandle<ListItemStateMapper> StateMapper { get; set; }
		[Ordinal(4)]  [RED("image")] public inkImageWidgetReference Image { get; set; }
		[Ordinal(5)]  [RED("border")] public inkImageWidgetReference Border { get; set; }
		[Ordinal(6)]  [RED("translateOnSelect")] public inkWidgetReference TranslateOnSelect { get; set; }
		[Ordinal(7)]  [RED("selectTranslationX")] public CFloat SelectTranslationX { get; set; }

		public CodexImageButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
