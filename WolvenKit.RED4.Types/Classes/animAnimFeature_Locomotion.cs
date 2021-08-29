using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class animAnimFeature_Locomotion : animAnimFeature
	{
		private CInt32 _action;
		private CInt32 _style;
		private CFloat _pathCurvature;
		private CFloat _inclineAngle;
		private CFloat _groundAngle;
		private CFloat _animDeltaZ;
		private CFloat _animationPlaybackTime;
		private CFloat _footScaleFactor;
		private CFloat _directionalStartAngle;
		private CFloat _speedProgress;
		private CBool _isOnStairs;
		private CBool _areAnimWrappersUnlocked;

		[Ordinal(0)] 
		[RED("action")] 
		public CInt32 Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}

		[Ordinal(1)] 
		[RED("style")] 
		public CInt32 Style
		{
			get => GetProperty(ref _style);
			set => SetProperty(ref _style, value);
		}

		[Ordinal(2)] 
		[RED("pathCurvature")] 
		public CFloat PathCurvature
		{
			get => GetProperty(ref _pathCurvature);
			set => SetProperty(ref _pathCurvature, value);
		}

		[Ordinal(3)] 
		[RED("inclineAngle")] 
		public CFloat InclineAngle
		{
			get => GetProperty(ref _inclineAngle);
			set => SetProperty(ref _inclineAngle, value);
		}

		[Ordinal(4)] 
		[RED("groundAngle")] 
		public CFloat GroundAngle
		{
			get => GetProperty(ref _groundAngle);
			set => SetProperty(ref _groundAngle, value);
		}

		[Ordinal(5)] 
		[RED("animDeltaZ")] 
		public CFloat AnimDeltaZ
		{
			get => GetProperty(ref _animDeltaZ);
			set => SetProperty(ref _animDeltaZ, value);
		}

		[Ordinal(6)] 
		[RED("animationPlaybackTime")] 
		public CFloat AnimationPlaybackTime
		{
			get => GetProperty(ref _animationPlaybackTime);
			set => SetProperty(ref _animationPlaybackTime, value);
		}

		[Ordinal(7)] 
		[RED("footScaleFactor")] 
		public CFloat FootScaleFactor
		{
			get => GetProperty(ref _footScaleFactor);
			set => SetProperty(ref _footScaleFactor, value);
		}

		[Ordinal(8)] 
		[RED("directionalStartAngle")] 
		public CFloat DirectionalStartAngle
		{
			get => GetProperty(ref _directionalStartAngle);
			set => SetProperty(ref _directionalStartAngle, value);
		}

		[Ordinal(9)] 
		[RED("speedProgress")] 
		public CFloat SpeedProgress
		{
			get => GetProperty(ref _speedProgress);
			set => SetProperty(ref _speedProgress, value);
		}

		[Ordinal(10)] 
		[RED("isOnStairs")] 
		public CBool IsOnStairs
		{
			get => GetProperty(ref _isOnStairs);
			set => SetProperty(ref _isOnStairs, value);
		}

		[Ordinal(11)] 
		[RED("areAnimWrappersUnlocked")] 
		public CBool AreAnimWrappersUnlocked
		{
			get => GetProperty(ref _areAnimWrappersUnlocked);
			set => SetProperty(ref _areAnimWrappersUnlocked, value);
		}
	}
}
