using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ItemTooltipGrenadeInfoModule : ItemTooltipModuleController
	{
		private inkTextWidgetReference _headerText;
		private inkTextWidgetReference _totalDamageText;
		private inkTextWidgetReference _durationText;
		private inkTextWidgetReference _rangeText;
		private inkImageWidgetReference _deliveryIcon;
		private inkTextWidgetReference _deliveryText;

		[Ordinal(2)] 
		[RED("headerText")] 
		public inkTextWidgetReference HeaderText
		{
			get => GetProperty(ref _headerText);
			set => SetProperty(ref _headerText, value);
		}

		[Ordinal(3)] 
		[RED("totalDamageText")] 
		public inkTextWidgetReference TotalDamageText
		{
			get => GetProperty(ref _totalDamageText);
			set => SetProperty(ref _totalDamageText, value);
		}

		[Ordinal(4)] 
		[RED("durationText")] 
		public inkTextWidgetReference DurationText
		{
			get => GetProperty(ref _durationText);
			set => SetProperty(ref _durationText, value);
		}

		[Ordinal(5)] 
		[RED("rangeText")] 
		public inkTextWidgetReference RangeText
		{
			get => GetProperty(ref _rangeText);
			set => SetProperty(ref _rangeText, value);
		}

		[Ordinal(6)] 
		[RED("deliveryIcon")] 
		public inkImageWidgetReference DeliveryIcon
		{
			get => GetProperty(ref _deliveryIcon);
			set => SetProperty(ref _deliveryIcon, value);
		}

		[Ordinal(7)] 
		[RED("deliveryText")] 
		public inkTextWidgetReference DeliveryText
		{
			get => GetProperty(ref _deliveryText);
			set => SetProperty(ref _deliveryText, value);
		}
	}
}
