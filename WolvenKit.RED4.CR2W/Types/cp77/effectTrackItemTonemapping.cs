using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemTonemapping : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _maxStopsSDR;
		private effectEffectParameterEvaluatorFloat _midGrayScaleSDR;
		private effectEffectParameterEvaluatorFloat _maxStopsHDR;
		private effectEffectParameterEvaluatorFloat _midGrayScaleHDR;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("maxStopsSDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsSDR
		{
			get => GetProperty(ref _maxStopsSDR);
			set => SetProperty(ref _maxStopsSDR, value);
		}

		[Ordinal(5)] 
		[RED("midGrayScaleSDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleSDR
		{
			get => GetProperty(ref _midGrayScaleSDR);
			set => SetProperty(ref _midGrayScaleSDR, value);
		}

		[Ordinal(6)] 
		[RED("maxStopsHDR")] 
		public effectEffectParameterEvaluatorFloat MaxStopsHDR
		{
			get => GetProperty(ref _maxStopsHDR);
			set => SetProperty(ref _maxStopsHDR, value);
		}

		[Ordinal(7)] 
		[RED("midGrayScaleHDR")] 
		public effectEffectParameterEvaluatorFloat MidGrayScaleHDR
		{
			get => GetProperty(ref _midGrayScaleHDR);
			set => SetProperty(ref _midGrayScaleHDR, value);
		}

		public effectTrackItemTonemapping(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
