using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StrikeDuration_Debug_VDB : StrikeDuration_Debug
	{
		[Ordinal(0)] 
		[RED("UPDATE_DELAY")] 
		public CFloat UPDATE_DELAY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("DISPLAY_DURATION")] 
		public CFloat DISPLAY_DURATION
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("timeToNextUpdate")] 
		public CFloat TimeToNextUpdate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public StrikeDuration_Debug_VDB()
		{
			UPDATE_DELAY = 1.000000F;
			DISPLAY_DURATION = 1.100000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
