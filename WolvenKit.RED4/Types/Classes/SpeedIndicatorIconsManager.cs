using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("speedIndicator")] 
		public inkImageWidgetReference SpeedIndicator
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("mirroredSpeedIndicator")] 
		public inkImageWidgetReference MirroredSpeedIndicator
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		public SpeedIndicatorIconsManager()
		{
			SpeedIndicator = new inkImageWidgetReference();
			MirroredSpeedIndicator = new inkImageWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
