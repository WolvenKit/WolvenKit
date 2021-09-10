using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipBottomModule : ItemTooltipModuleController
	{
		[Ordinal(2)] 
		[RED("weightWrapper")] 
		public inkWidgetReference WeightWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		public ItemTooltipBottomModule()
		{
			WeightWrapper = new();
			PriceWrapper = new();
			WeightText = new();
			PriceText = new();
		}
	}
}
