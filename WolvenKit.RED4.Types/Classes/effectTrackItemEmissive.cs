using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemEmissive : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _brigtness;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("brigtness")] 
		public effectEffectParameterEvaluatorFloat Brigtness
		{
			get => GetProperty(ref _brigtness);
			set => SetProperty(ref _brigtness, value);
		}
	}
}
