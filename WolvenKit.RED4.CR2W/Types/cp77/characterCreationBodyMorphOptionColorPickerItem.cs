using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerItem : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("foreground")] public inkWidgetReference Foreground { get; set; }
		[Ordinal(4)] [RED("selectionMark")] public inkWidgetReference SelectionMark { get; set; }

		public characterCreationBodyMorphOptionColorPickerItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
