using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipBottomModule : NewItemTooltipModuleController
	{
		[Ordinal(5)] 
		[RED("weightWrapper")] 
		public inkWidgetReference WeightWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("ammoWrapper")] 
		public inkWidgetReference AmmoWrapper
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("ammoText")] 
		public inkTextWidgetReference AmmoText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("ammoIcon")] 
		public inkImageWidgetReference AmmoIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public NewItemTooltipBottomModule()
		{
			WeightWrapper = new inkWidgetReference();
			PriceWrapper = new inkWidgetReference();
			AmmoWrapper = new inkWidgetReference();
			WeightText = new inkTextWidgetReference();
			PriceText = new inkTextWidgetReference();
			AmmoText = new inkTextWidgetReference();
			AmmoIcon = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
