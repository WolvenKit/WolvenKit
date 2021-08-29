using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimFeature_BulletBend : animAnimFeature
	{
		private CFloat _animProgression;
		private CFloat _randomAdditive;
		private CBool _isResetting;

		[Ordinal(0)] 
		[RED("animProgression")] 
		public CFloat AnimProgression
		{
			get => GetProperty(ref _animProgression);
			set => SetProperty(ref _animProgression, value);
		}

		[Ordinal(1)] 
		[RED("randomAdditive")] 
		public CFloat RandomAdditive
		{
			get => GetProperty(ref _randomAdditive);
			set => SetProperty(ref _randomAdditive, value);
		}

		[Ordinal(2)] 
		[RED("isResetting")] 
		public CBool IsResetting
		{
			get => GetProperty(ref _isResetting);
			set => SetProperty(ref _isResetting, value);
		}
	}
}
