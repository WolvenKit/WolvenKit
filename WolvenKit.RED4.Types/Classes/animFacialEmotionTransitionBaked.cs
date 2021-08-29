using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialEmotionTransitionBaked : RedBaseClass
	{
		private CName _toIdleMale;
		private CName _facialKey_Male;
		private CName _toIdleFemale;
		private CName _facialKey_Female;
		private CEnum<animFacialEmotionTransitionType> _transitionType;
		private CFloat _transitionDuration;
		private CFloat _timeScale;
		private CFloat _toIdleWeight;
		private CFloat _toIdleNeckWeight;
		private CFloat _facialKeyWeight;
		private CName _customTransitionAnim;

		[Ordinal(0)] 
		[RED("toIdleMale")] 
		public CName ToIdleMale
		{
			get => GetProperty(ref _toIdleMale);
			set => SetProperty(ref _toIdleMale, value);
		}

		[Ordinal(1)] 
		[RED("facialKey_Male")] 
		public CName FacialKey_Male
		{
			get => GetProperty(ref _facialKey_Male);
			set => SetProperty(ref _facialKey_Male, value);
		}

		[Ordinal(2)] 
		[RED("toIdleFemale")] 
		public CName ToIdleFemale
		{
			get => GetProperty(ref _toIdleFemale);
			set => SetProperty(ref _toIdleFemale, value);
		}

		[Ordinal(3)] 
		[RED("facialKey_Female")] 
		public CName FacialKey_Female
		{
			get => GetProperty(ref _facialKey_Female);
			set => SetProperty(ref _facialKey_Female, value);
		}

		[Ordinal(4)] 
		[RED("transitionType")] 
		public CEnum<animFacialEmotionTransitionType> TransitionType
		{
			get => GetProperty(ref _transitionType);
			set => SetProperty(ref _transitionType, value);
		}

		[Ordinal(5)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetProperty(ref _transitionDuration);
			set => SetProperty(ref _transitionDuration, value);
		}

		[Ordinal(6)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(7)] 
		[RED("toIdleWeight")] 
		public CFloat ToIdleWeight
		{
			get => GetProperty(ref _toIdleWeight);
			set => SetProperty(ref _toIdleWeight, value);
		}

		[Ordinal(8)] 
		[RED("toIdleNeckWeight")] 
		public CFloat ToIdleNeckWeight
		{
			get => GetProperty(ref _toIdleNeckWeight);
			set => SetProperty(ref _toIdleNeckWeight, value);
		}

		[Ordinal(9)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetProperty(ref _facialKeyWeight);
			set => SetProperty(ref _facialKeyWeight, value);
		}

		[Ordinal(10)] 
		[RED("customTransitionAnim")] 
		public CName CustomTransitionAnim
		{
			get => GetProperty(ref _customTransitionAnim);
			set => SetProperty(ref _customTransitionAnim, value);
		}
	}
}
