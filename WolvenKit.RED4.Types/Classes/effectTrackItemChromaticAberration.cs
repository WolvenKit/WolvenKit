using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class effectTrackItemChromaticAberration : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _chromaticAberrationOffset;
		private effectEffectParameterEvaluatorFloat _chromaticAberrationExp;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("chromaticAberrationOffset")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationOffset
		{
			get => GetProperty(ref _chromaticAberrationOffset);
			set => SetProperty(ref _chromaticAberrationOffset, value);
		}

		[Ordinal(5)] 
		[RED("chromaticAberrationExp")] 
		public effectEffectParameterEvaluatorFloat ChromaticAberrationExp
		{
			get => GetProperty(ref _chromaticAberrationExp);
			set => SetProperty(ref _chromaticAberrationExp, value);
		}
	}
}
