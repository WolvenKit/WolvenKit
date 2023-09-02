using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SParticleEmitterLODLevel : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("emitterDurationSettings")] 
		public EmitterDurationSettings EmitterDurationSettings
		{
			get => GetPropertyValue<EmitterDurationSettings>();
			set => SetPropertyValue<EmitterDurationSettings>(value);
		}

		[Ordinal(1)] 
		[RED("emitterDelaySettings")] 
		public EmitterDelaySettings EmitterDelaySettings
		{
			get => GetPropertyValue<EmitterDelaySettings>();
			set => SetPropertyValue<EmitterDelaySettings>(value);
		}

		[Ordinal(2)] 
		[RED("burstList")] 
		public CArray<ParticleBurst> BurstList
		{
			get => GetPropertyValue<CArray<ParticleBurst>>();
			set => SetPropertyValue<CArray<ParticleBurst>>(value);
		}

		[Ordinal(3)] 
		[RED("birthRate")] 
		public CHandle<IEvaluatorFloat> BirthRate
		{
			get => GetPropertyValue<CHandle<IEvaluatorFloat>>();
			set => SetPropertyValue<CHandle<IEvaluatorFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("sortingMode")] 
		public CEnum<rendEParticleSortingMode> SortingMode
		{
			get => GetPropertyValue<CEnum<rendEParticleSortingMode>>();
			set => SetPropertyValue<CEnum<rendEParticleSortingMode>>(value);
		}

		[Ordinal(5)] 
		[RED("lodSwitchDistance")] 
		public CFloat LodSwitchDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SParticleEmitterLODLevel()
		{
			EmitterDurationSettings = new EmitterDurationSettings { EmitterDuration = 1.000000F };
			EmitterDelaySettings = new EmitterDelaySettings();
			BurstList = new();
			LodSwitchDistance = 100.000000F;
			IsEnabled = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
