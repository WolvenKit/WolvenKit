using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SlidingLadderControllerPS : BaseAnimatedDeviceControllerPS
	{
		[Ordinal(109)] 
		[RED("isShootable")] 
		public CBool IsShootable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(110)] 
		[RED("animationTime")] 
		public CFloat AnimationTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SlidingLadderControllerPS()
		{
			DeviceName = "LocKey#2128";
			TweakDBRecord = 93333720801;
			TweakDBDescriptionRecord = 144242295596;
			ShouldScannerShowStatus = false;
			IsShootable = true;
			AnimationTime = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
