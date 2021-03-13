using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipIconModule : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("icon")] public inkImageWidgetReference Icon { get; set; }
		[Ordinal(3)] [RED("iconicLines")] public inkImageWidgetReference IconicLines { get; set; }
		[Ordinal(4)] [RED("iconsNameResolver")] public CHandle<gameuiIconsNameResolver> IconsNameResolver { get; set; }

		public ItemTooltipIconModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
