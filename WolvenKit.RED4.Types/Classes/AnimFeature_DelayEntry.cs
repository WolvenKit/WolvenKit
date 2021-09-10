using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_DelayEntry : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("thresholdPassed")] 
		public CBool ThresholdPassed
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
	}
}
