using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkRadioGroupController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("ValueChanged")] public inkRadioGroupChangedCallback ValueChanged { get; set; }
		[Ordinal(1)]  [RED("alwaysToggled")] public CBool AlwaysToggled { get; set; }
		[Ordinal(2)]  [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }
		[Ordinal(3)]  [RED("toggleRefs")] public CArray<inkWidgetReference> ToggleRefs { get; set; }

		public inkRadioGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
