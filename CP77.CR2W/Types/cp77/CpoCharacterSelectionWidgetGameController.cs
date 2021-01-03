using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class CpoCharacterSelectionWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("amount")] public CInt32 Amount { get; set; }
		[Ordinal(1)]  [RED("defaultCharacterTexturePart")] public CString DefaultCharacterTexturePart { get; set; }
		[Ordinal(2)]  [RED("horizontalPanelsList")] public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList { get; set; }
		[Ordinal(3)]  [RED("soloCharacterTexturePart")] public CString SoloCharacterTexturePart { get; set; }

		public CpoCharacterSelectionWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
