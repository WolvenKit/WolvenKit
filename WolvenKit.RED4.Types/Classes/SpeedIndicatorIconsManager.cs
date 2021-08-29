using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SpeedIndicatorIconsManager : inkWidgetLogicController
	{
		private inkImageWidgetReference _speedIndicator;
		private inkImageWidgetReference _mirroredSpeedIndicator;

		[Ordinal(1)] 
		[RED("speedIndicator")] 
		public inkImageWidgetReference SpeedIndicator
		{
			get => GetProperty(ref _speedIndicator);
			set => SetProperty(ref _speedIndicator, value);
		}

		[Ordinal(2)] 
		[RED("mirroredSpeedIndicator")] 
		public inkImageWidgetReference MirroredSpeedIndicator
		{
			get => GetProperty(ref _mirroredSpeedIndicator);
			set => SetProperty(ref _mirroredSpeedIndicator, value);
		}
	}
}
