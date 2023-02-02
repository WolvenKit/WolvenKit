using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_DelayEntry : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("thresholdPassed")] 
		public CBool ThresholdPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AnimFeature_DelayEntry()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
