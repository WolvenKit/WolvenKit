using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TabRadioGroup : inkRadioGroupController
	{
		[Ordinal(5)] [RED("root")] public inkCompoundWidgetReference Root { get; set; }
		[Ordinal(6)] [RED("toggles")] public CArray<wCHandle<TabButtonController>> Toggles { get; set; }
		[Ordinal(7)] [RED("TooltipsManager")] public wCHandle<gameuiTooltipsManager> TooltipsManager { get; set; }

		public TabRadioGroup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
