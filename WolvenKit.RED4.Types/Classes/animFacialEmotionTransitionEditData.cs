using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animFacialEmotionTransitionEditData : RedBaseClass
	{
		private CName _toIdleMale;
		private CName _facialKeyMale;
		private CName _toIdleFemale;
		private CName _facialKeyFemale;
		private CEnum<animFacialEmotionTransitionType> _transitionType;
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
		[RED("facialKeyMale")] 
		public CName FacialKeyMale
		{
			get => GetProperty(ref _facialKeyMale);
			set => SetProperty(ref _facialKeyMale, value);
		}

		[Ordinal(2)] 
		[RED("toIdleFemale")] 
		public CName ToIdleFemale
		{
			get => GetProperty(ref _toIdleFemale);
			set => SetProperty(ref _toIdleFemale, value);
		}

		[Ordinal(3)] 
		[RED("facialKeyFemale")] 
		public CName FacialKeyFemale
		{
			get => GetProperty(ref _facialKeyFemale);
			set => SetProperty(ref _facialKeyFemale, value);
		}

		[Ordinal(4)] 
		[RED("transitionType")] 
		public CEnum<animFacialEmotionTransitionType> TransitionType
		{
			get => GetProperty(ref _transitionType);
			set => SetProperty(ref _transitionType, value);
		}

		[Ordinal(5)] 
		[RED("toIdleWeight")] 
		public CFloat ToIdleWeight
		{
			get => GetProperty(ref _toIdleWeight);
			set => SetProperty(ref _toIdleWeight, value);
		}

		[Ordinal(6)] 
		[RED("toIdleNeckWeight")] 
		public CFloat ToIdleNeckWeight
		{
			get => GetProperty(ref _toIdleNeckWeight);
			set => SetProperty(ref _toIdleNeckWeight, value);
		}

		[Ordinal(7)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetProperty(ref _facialKeyWeight);
			set => SetProperty(ref _facialKeyWeight, value);
		}

		[Ordinal(8)] 
		[RED("customTransitionAnim")] 
		public CName CustomTransitionAnim
		{
			get => GetProperty(ref _customTransitionAnim);
			set => SetProperty(ref _customTransitionAnim, value);
		}
	}
}
