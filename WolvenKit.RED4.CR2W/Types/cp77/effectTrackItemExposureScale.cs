using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class effectTrackItemExposureScale : effectTrackItem
	{
		private effectEffectParameterEvaluatorFloat _scale;
		private CBool _useInitialCameraPosDirForFadeout;
		private CFloat _fullEffectRadius;
		private CFloat _fadeOutRadius;
		private CFloat _fullyVisibleAngle;
		private CFloat _fadeOutAngle;

		[Ordinal(3)] 
		[RED("scale")] 
		public effectEffectParameterEvaluatorFloat Scale
		{
			get => GetProperty(ref _scale);
			set => SetProperty(ref _scale, value);
		}

		[Ordinal(4)] 
		[RED("useInitialCameraPosDirForFadeout")] 
		public CBool UseInitialCameraPosDirForFadeout
		{
			get => GetProperty(ref _useInitialCameraPosDirForFadeout);
			set => SetProperty(ref _useInitialCameraPosDirForFadeout, value);
		}

		[Ordinal(5)] 
		[RED("fullEffectRadius")] 
		public CFloat FullEffectRadius
		{
			get => GetProperty(ref _fullEffectRadius);
			set => SetProperty(ref _fullEffectRadius, value);
		}

		[Ordinal(6)] 
		[RED("fadeOutRadius")] 
		public CFloat FadeOutRadius
		{
			get => GetProperty(ref _fadeOutRadius);
			set => SetProperty(ref _fadeOutRadius, value);
		}

		[Ordinal(7)] 
		[RED("fullyVisibleAngle")] 
		public CFloat FullyVisibleAngle
		{
			get => GetProperty(ref _fullyVisibleAngle);
			set => SetProperty(ref _fullyVisibleAngle, value);
		}

		[Ordinal(8)] 
		[RED("fadeOutAngle")] 
		public CFloat FadeOutAngle
		{
			get => GetProperty(ref _fadeOutAngle);
			set => SetProperty(ref _fadeOutAngle, value);
		}

		public effectTrackItemExposureScale(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
