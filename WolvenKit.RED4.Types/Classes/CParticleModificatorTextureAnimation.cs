using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleModificatorTextureAnimation : IParticleModificator
	{
		private CHandle<IEvaluatorFloat> _initialFrame;
		private CHandle<IEvaluatorFloat> _animationSpeed;
		private CEnum<ETextureAnimationMode> _animationMode;

		[Ordinal(4)] 
		[RED("initialFrame")] 
		public CHandle<IEvaluatorFloat> InitialFrame
		{
			get => GetProperty(ref _initialFrame);
			set => SetProperty(ref _initialFrame, value);
		}

		[Ordinal(5)] 
		[RED("animationSpeed")] 
		public CHandle<IEvaluatorFloat> AnimationSpeed
		{
			get => GetProperty(ref _animationSpeed);
			set => SetProperty(ref _animationSpeed, value);
		}

		[Ordinal(6)] 
		[RED("animationMode")] 
		public CEnum<ETextureAnimationMode> AnimationMode
		{
			get => GetProperty(ref _animationMode);
			set => SetProperty(ref _animationMode, value);
		}
	}
}
