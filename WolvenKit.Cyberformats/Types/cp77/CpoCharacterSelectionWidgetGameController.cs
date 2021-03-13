using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterSelectionWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("defaultCharacterTexturePart")] public CString DefaultCharacterTexturePart { get; set; }
		[Ordinal(3)] [RED("soloCharacterTexturePart")] public CString SoloCharacterTexturePart { get; set; }
		[Ordinal(4)] [RED("horizontalPanelsList")] public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList { get; set; }
		[Ordinal(5)] [RED("amount")] public CInt32 Amount { get; set; }

		public CpoCharacterSelectionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
