using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class characterCreationBodyMorphOptionSelectorButton : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("overArrow")] public inkWidgetReference OverArrow { get; set; }

		public characterCreationBodyMorphOptionSelectorButton(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
