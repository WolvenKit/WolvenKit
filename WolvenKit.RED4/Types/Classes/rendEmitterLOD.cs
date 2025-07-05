using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class rendEmitterLOD : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("lodSwitchDistance")] 
		public CFloat LodSwitchDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("burstList")] 
		public CArray<rendParticleBurst> BurstList
		{
			get => GetPropertyValue<CArray<rendParticleBurst>>();
			set => SetPropertyValue<CArray<rendParticleBurst>>(value);
		}

		[Ordinal(2)] 
		[RED("birthRate")] 
		public CArray<CFloat> BirthRate
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("emitterDurationSettings")] 
		public rendEmitterDurationSettings EmitterDurationSettings
		{
			get => GetPropertyValue<rendEmitterDurationSettings>();
			set => SetPropertyValue<rendEmitterDurationSettings>(value);
		}

		[Ordinal(4)] 
		[RED("emitterDelaySettings")] 
		public rendEmitterDelaySettings EmitterDelaySettings
		{
			get => GetPropertyValue<rendEmitterDelaySettings>();
			set => SetPropertyValue<rendEmitterDelaySettings>(value);
		}

		[Ordinal(5)] 
		[RED("sortingMode")] 
		public CEnum<rendEParticleSortingMode> SortingMode
		{
			get => GetPropertyValue<CEnum<rendEParticleSortingMode>>();
			set => SetPropertyValue<CEnum<rendEParticleSortingMode>>(value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public rendEmitterLOD()
		{
			LodSwitchDistance = 100.000000F;
			BurstList = new();
			BirthRate = new();
			EmitterDurationSettings = new rendEmitterDurationSettings { EmitterDuration = 1.000000F };
			EmitterDelaySettings = new rendEmitterDelaySettings();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
