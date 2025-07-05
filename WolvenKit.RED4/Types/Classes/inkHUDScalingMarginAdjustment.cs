using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkHUDScalingMarginAdjustment : inkInitializedWidgetUserData
	{
		[Ordinal(0)] 
		[RED("adjustmentMargin")] 
		public inkMargin AdjustmentMargin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		public inkHUDScalingMarginAdjustment()
		{
			AdjustmentMargin = new inkMargin();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
