using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CParticleEventGenerator : IParticleEvent
	{
		[Ordinal(4)] 
		[RED("evtType")] 
		public CEnum<EParticleEventType> EvtType
		{
			get => GetPropertyValue<CEnum<EParticleEventType>>();
			set => SetPropertyValue<CEnum<EParticleEventType>>(value);
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CParticleEventGenerator()
		{
			EditorName = "Event Generator";
			EditorGroup = "Event";
			IsEnabled = true;
			Frequency = 0.500000F;
			Probability = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
