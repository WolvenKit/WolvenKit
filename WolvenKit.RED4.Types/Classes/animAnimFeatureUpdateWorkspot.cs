using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeatureUpdateWorkspot : animAnimFeature
	{
		private CName _animName;
		private CInt32 _recordID;
		private CInt32 _updateCounter;
		private CInt32 _boolsAsFlags;
		private CFloat _animBlendTime;
		private CFloat _forcedBlendIn;
		private CFloat _forceAnimTime;
		private CFloat _timeScale;
		private CDouble _animationStartTime;
		private CBool _isPaused;
		private CBool _isLooped;
		private CBool _isExitAnim;
		private CBool _enableMotion;
		private CBool _isActive;
		private CBool _isAnimValid;
		private CInt32 _slotNameHash;
		private CFloat _facialKeyWeight;
		private CName _facialIdleAnimation;
		private CName _facialIdleKeyAnimation;
		private CFloat _globalBlendDuration;
		private CBool _globalBlendIn;

		[Ordinal(0)] 
		[RED("animName")] 
		public CName AnimName
		{
			get => GetProperty(ref _animName);
			set => SetProperty(ref _animName, value);
		}

		[Ordinal(1)] 
		[RED("recordID")] 
		public CInt32 RecordID
		{
			get => GetProperty(ref _recordID);
			set => SetProperty(ref _recordID, value);
		}

		[Ordinal(2)] 
		[RED("updateCounter")] 
		public CInt32 UpdateCounter
		{
			get => GetProperty(ref _updateCounter);
			set => SetProperty(ref _updateCounter, value);
		}

		[Ordinal(3)] 
		[RED("boolsAsFlags")] 
		public CInt32 BoolsAsFlags
		{
			get => GetProperty(ref _boolsAsFlags);
			set => SetProperty(ref _boolsAsFlags, value);
		}

		[Ordinal(4)] 
		[RED("animBlendTime")] 
		public CFloat AnimBlendTime
		{
			get => GetProperty(ref _animBlendTime);
			set => SetProperty(ref _animBlendTime, value);
		}

		[Ordinal(5)] 
		[RED("forcedBlendIn")] 
		public CFloat ForcedBlendIn
		{
			get => GetProperty(ref _forcedBlendIn);
			set => SetProperty(ref _forcedBlendIn, value);
		}

		[Ordinal(6)] 
		[RED("forceAnimTime")] 
		public CFloat ForceAnimTime
		{
			get => GetProperty(ref _forceAnimTime);
			set => SetProperty(ref _forceAnimTime, value);
		}

		[Ordinal(7)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetProperty(ref _timeScale);
			set => SetProperty(ref _timeScale, value);
		}

		[Ordinal(8)] 
		[RED("animationStartTime")] 
		public CDouble AnimationStartTime
		{
			get => GetProperty(ref _animationStartTime);
			set => SetProperty(ref _animationStartTime, value);
		}

		[Ordinal(9)] 
		[RED("isPaused")] 
		public CBool IsPaused
		{
			get => GetProperty(ref _isPaused);
			set => SetProperty(ref _isPaused, value);
		}

		[Ordinal(10)] 
		[RED("isLooped")] 
		public CBool IsLooped
		{
			get => GetProperty(ref _isLooped);
			set => SetProperty(ref _isLooped, value);
		}

		[Ordinal(11)] 
		[RED("isExitAnim")] 
		public CBool IsExitAnim
		{
			get => GetProperty(ref _isExitAnim);
			set => SetProperty(ref _isExitAnim, value);
		}

		[Ordinal(12)] 
		[RED("enableMotion")] 
		public CBool EnableMotion
		{
			get => GetProperty(ref _enableMotion);
			set => SetProperty(ref _enableMotion, value);
		}

		[Ordinal(13)] 
		[RED("isActive")] 
		public CBool IsActive
		{
			get => GetProperty(ref _isActive);
			set => SetProperty(ref _isActive, value);
		}

		[Ordinal(14)] 
		[RED("isAnimValid")] 
		public CBool IsAnimValid
		{
			get => GetProperty(ref _isAnimValid);
			set => SetProperty(ref _isAnimValid, value);
		}

		[Ordinal(15)] 
		[RED("slotNameHash")] 
		public CInt32 SlotNameHash
		{
			get => GetProperty(ref _slotNameHash);
			set => SetProperty(ref _slotNameHash, value);
		}

		[Ordinal(16)] 
		[RED("facialKeyWeight")] 
		public CFloat FacialKeyWeight
		{
			get => GetProperty(ref _facialKeyWeight);
			set => SetProperty(ref _facialKeyWeight, value);
		}

		[Ordinal(17)] 
		[RED("facialIdleAnimation")] 
		public CName FacialIdleAnimation
		{
			get => GetProperty(ref _facialIdleAnimation);
			set => SetProperty(ref _facialIdleAnimation, value);
		}

		[Ordinal(18)] 
		[RED("facialIdleKeyAnimation")] 
		public CName FacialIdleKeyAnimation
		{
			get => GetProperty(ref _facialIdleKeyAnimation);
			set => SetProperty(ref _facialIdleKeyAnimation, value);
		}

		[Ordinal(19)] 
		[RED("globalBlendDuration")] 
		public CFloat GlobalBlendDuration
		{
			get => GetProperty(ref _globalBlendDuration);
			set => SetProperty(ref _globalBlendDuration, value);
		}

		[Ordinal(20)] 
		[RED("globalBlendIn")] 
		public CBool GlobalBlendIn
		{
			get => GetProperty(ref _globalBlendIn);
			set => SetProperty(ref _globalBlendIn, value);
		}

		public animAnimFeatureUpdateWorkspot()
		{
			_timeScale = 1.000000F;
			_animationStartTime = -1.000000D;
			_facialKeyWeight = 0.750000F;
		}
	}
}
