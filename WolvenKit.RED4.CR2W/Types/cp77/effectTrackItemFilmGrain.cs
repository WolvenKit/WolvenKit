using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemFilmGrain : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _luminanceBias;
		private effectEffectParameterEvaluatorVector _strength;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("luminanceBias")] 
		public effectEffectParameterEvaluatorFloat LuminanceBias
		{
			get => GetProperty(ref _luminanceBias);
			set => SetProperty(ref _luminanceBias, value);
		}

		[Ordinal(5)] 
		[RED("strength")] 
		public effectEffectParameterEvaluatorVector Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		public effectTrackItemFilmGrain(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
