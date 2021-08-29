using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DelayEntry : animAnimFeature
	{
		private CBool _thresholdPassed;

		[Ordinal(0)] 
		[RED("thresholdPassed")] 
		public CBool ThresholdPassed
		{
			get => GetProperty(ref _thresholdPassed);
			set => SetProperty(ref _thresholdPassed, value);
		}
	}
}
