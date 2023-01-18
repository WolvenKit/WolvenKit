using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STransformAnimationPlayEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("timesPlayed")] 
		public CUInt32 TimesPlayed
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public STransformAnimationPlayEventData()
		{
			TimeScale = 1.000000F;
			TimesPlayed = 1;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
