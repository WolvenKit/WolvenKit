using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerItem : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(1)]  [RED("foreground")] public inkWidgetReference Foreground { get; set; }
		[Ordinal(2)]  [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)]  [RED("selectionMark")] public inkWidgetReference SelectionMark { get; set; }

		public characterCreationBodyMorphOptionColorPickerItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
