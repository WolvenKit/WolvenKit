using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionColorPickerButton : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("background")] public inkWidgetReference Background { get; set; }
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("isTriggered")] public CBool IsTriggered { get; set; }

		public characterCreationBodyMorphOptionColorPickerButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
