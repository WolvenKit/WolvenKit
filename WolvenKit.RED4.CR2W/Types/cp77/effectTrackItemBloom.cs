using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemBloom : effectTrackItem
	{
		private CBool _override;
		private effectEffectParameterEvaluatorFloat _sceneColorScale;
		private effectEffectParameterEvaluatorFloat _bloomColorScale;

		[Ordinal(3)] 
		[RED("override")] 
		public CBool Override
		{
			get => GetProperty(ref _override);
			set => SetProperty(ref _override, value);
		}

		[Ordinal(4)] 
		[RED("sceneColorScale")] 
		public effectEffectParameterEvaluatorFloat SceneColorScale
		{
			get => GetProperty(ref _sceneColorScale);
			set => SetProperty(ref _sceneColorScale, value);
		}

		[Ordinal(5)] 
		[RED("bloomColorScale")] 
		public effectEffectParameterEvaluatorFloat BloomColorScale
		{
			get => GetProperty(ref _bloomColorScale);
			set => SetProperty(ref _bloomColorScale, value);
		}

		public effectTrackItemBloom(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
