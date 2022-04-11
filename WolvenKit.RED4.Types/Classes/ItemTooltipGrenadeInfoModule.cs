using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("totalDamageText")] 
		public inkTextWidgetReference TotalDamageText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("durationText")] 
		public inkTextWidgetReference DurationText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("rangeText")] 
		public inkTextWidgetReference RangeText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("deliveryIcon")] 
		public inkImageWidgetReference DeliveryIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("deliveryText")] 
		public inkTextWidgetReference DeliveryText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipGrenadeInfoModule()
		{
			HeaderText = new();
			TotalDamageText = new();
			DurationText = new();
			RangeText = new();
			DeliveryIcon = new();
			DeliveryText = new();
		}
	}
}
