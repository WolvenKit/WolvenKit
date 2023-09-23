using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(112)] 
		[RED("isShootable")] 
		public CBool IsShootable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(113)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SlidingLadderControllerPS()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
