using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		[Ordinal(2)] [RED("headerText")] public inkTextWidgetReference HeaderText { get; set; }
		[Ordinal(3)] [RED("totalDamageText")] public inkTextWidgetReference TotalDamageText { get; set; }
		[Ordinal(4)] [RED("durationText")] public inkTextWidgetReference DurationText { get; set; }
		[Ordinal(5)] [RED("rangeText")] public inkTextWidgetReference RangeText { get; set; }
		[Ordinal(6)] [RED("deliveryIcon")] public inkImageWidgetReference DeliveryIcon { get; set; }
		[Ordinal(7)] [RED("deliveryText")] public inkTextWidgetReference DeliveryText { get; set; }

		public ItemTooltipGrenadeInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
