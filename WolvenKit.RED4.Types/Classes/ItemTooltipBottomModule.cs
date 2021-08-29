using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipBottomModule : ItemTooltipModuleController
	{
		private inkWidgetReference _weightWrapper;
		private inkWidgetReference _priceWrapper;
		private inkTextWidgetReference _weightText;
		private inkTextWidgetReference _priceText;

		[Ordinal(2)] 
		[RED("weightWrapper")] 
		public inkWidgetReference WeightWrapper
		{
			get => GetProperty(ref _weightWrapper);
			set => SetProperty(ref _weightWrapper, value);
		}

		[Ordinal(3)] 
		[RED("priceWrapper")] 
		public inkWidgetReference PriceWrapper
		{
			get => GetProperty(ref _priceWrapper);
			set => SetProperty(ref _priceWrapper, value);
		}

		[Ordinal(4)] 
		[RED("weightText")] 
		public inkTextWidgetReference WeightText
		{
			get => GetProperty(ref _weightText);
			set => SetProperty(ref _weightText, value);
		}

		[Ordinal(5)] 
		[RED("priceText")] 
		public inkTextWidgetReference PriceText
		{
			get => GetProperty(ref _priceText);
			set => SetProperty(ref _priceText, value);
		}
	}
}
