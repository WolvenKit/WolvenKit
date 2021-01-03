using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		[Ordinal(0)]  [RED("deliveryIcon")] public inkImageWidgetReference DeliveryIcon { get; set; }
		[Ordinal(1)]  [RED("deliveryText")] public inkTextWidgetReference DeliveryText { get; set; }
		[Ordinal(2)]  [RED("durationText")] public inkTextWidgetReference DurationText { get; set; }
		[Ordinal(3)]  [RED("headerText")] public inkTextWidgetReference HeaderText { get; set; }
		[Ordinal(4)]  [RED("rangeText")] public inkTextWidgetReference RangeText { get; set; }
		[Ordinal(5)]  [RED("totalDamageText")] public inkTextWidgetReference TotalDamageText { get; set; }

		public ItemTooltipGrenadeInfoModule(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
