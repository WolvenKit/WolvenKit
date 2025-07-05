using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendEmitterDurationSettings : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("emitterDuration")] 
		public CFloat EmitterDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("emitterDurationLow")] 
		public CFloat EmitterDurationLow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("useEmitterDurationRange")] 
		public CBool UseEmitterDurationRange
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public rendEmitterDurationSettings()
		{
			EmitterDuration = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
