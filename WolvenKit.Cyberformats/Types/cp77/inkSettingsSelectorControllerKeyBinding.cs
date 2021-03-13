using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkSettingsSelectorControllerKeyBinding : inkSettingsSelectorController
	{
		[Ordinal(15)] [RED("text")] public inkRichTextBoxWidgetReference Text { get; set; }
		[Ordinal(16)] [RED("buttonRef")] public inkWidgetReference ButtonRef { get; set; }
		[Ordinal(17)] [RED("editView")] public inkWidgetReference EditView { get; set; }
		[Ordinal(18)] [RED("editOpacity")] public CFloat EditOpacity { get; set; }

		public inkSettingsSelectorControllerKeyBinding(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
