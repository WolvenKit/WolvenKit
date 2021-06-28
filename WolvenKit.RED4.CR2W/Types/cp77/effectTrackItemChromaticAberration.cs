using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemChromaticAberration : effectTrackItem
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

		public effectTrackItemChromaticAberration(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
