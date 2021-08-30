using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		private CBool _isShootable;
		private CFloat _animationTime;

		[Ordinal(109)] 
		[RED("isShootable")] 
		public CBool IsShootable
		{
			get => GetProperty(ref _isShootable);
			set => SetProperty(ref _isShootable, value);
		}

		[Ordinal(110)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetProperty(ref _animationTime);
			set => SetProperty(ref _animationTime, value);
		}

		public SlidingLadderControllerPS()
		{
			_isShootable = true;
			_animationTime = 1.000000F;
		}
	}
}
