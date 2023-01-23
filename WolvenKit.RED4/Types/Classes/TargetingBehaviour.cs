using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetingBehaviour : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("initialWakeState")] 
		public CEnum<ESensorDeviceWakeState> InitialWakeState
		{
			get => GetPropertyValue<CEnum<ESensorDeviceWakeState>>();
			set => SetPropertyValue<CEnum<ESensorDeviceWakeState>>(value);
		}

		[Ordinal(1)] 
		[RED("canRotate")] 
		public CBool CanRotate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("lostTargetLookAtTime")] 
		public CFloat LostTargetLookAtTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("lostTargetSearchTime")] 
		public CFloat LostTargetSearchTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TargetingBehaviour()
		{
			CanRotate = true;
			LostTargetLookAtTime = 2.000000F;
			LostTargetSearchTime = 10.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
