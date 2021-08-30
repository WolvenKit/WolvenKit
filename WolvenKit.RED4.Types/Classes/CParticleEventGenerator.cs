using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CParticleEventGenerator : IParticleEvent
	{
		private CEnum<EParticleEventType> _evtType;
		private CFloat _frequency;
		private CFloat _probability;

		[Ordinal(4)] 
		[RED("evtType")] 
		public CEnum<EParticleEventType> EvtType
		{
			get => GetProperty(ref _evtType);
			set => SetProperty(ref _evtType, value);
		}

		[Ordinal(5)] 
		[RED("frequency")] 
		public CFloat Frequency
		{
			get => GetProperty(ref _frequency);
			set => SetProperty(ref _frequency, value);
		}

		[Ordinal(6)] 
		[RED("probability")] 
		public CFloat Probability
		{
			get => GetProperty(ref _probability);
			set => SetProperty(ref _probability, value);
		}

		public CParticleEventGenerator()
		{
			_frequency = 0.500000F;
			_probability = 1.000000F;
		}
	}
}
