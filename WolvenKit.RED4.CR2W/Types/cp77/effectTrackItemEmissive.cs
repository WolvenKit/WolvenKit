using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemEmissive : effectTrackItem
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

		public effectTrackItemEmissive(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
