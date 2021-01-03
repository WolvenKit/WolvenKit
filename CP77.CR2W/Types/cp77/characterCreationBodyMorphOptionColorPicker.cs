using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPicker : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("grid")] public inkUniformGridWidgetReference Grid { get; set; }
		[Ordinal(1)]  [RED("option")] public wCHandle<gameuiCharacterCustomizationOption> Option { get; set; }
		[Ordinal(2)]  [RED("selectedIndex")] public CInt32 SelectedIndex { get; set; }
		[Ordinal(3)]  [RED("title")] public inkTextWidgetReference Title { get; set; }

		public characterCreationBodyMorphOptionColorPicker(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
