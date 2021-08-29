using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SParticleEmitterLODLevel : RedBaseClass
	{
		private EmitterDurationSettings _emitterDurationSettings;
		private EmitterDelaySettings _emitterDelaySettings;
		private CArray<ParticleBurst> _burstList;
		private CHandle<IEvaluatorFloat> _birthRate;
		private CEnum<rendEParticleSortingMode> _sortingMode;
		private CFloat _lodSwitchDistance;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("emitterDurationSettings")] 
		public EmitterDurationSettings EmitterDurationSettings
		{
			get => GetProperty(ref _emitterDurationSettings);
			set => SetProperty(ref _emitterDurationSettings, value);
		}

		[Ordinal(1)] 
		[RED("emitterDelaySettings")] 
		public EmitterDelaySettings EmitterDelaySettings
		{
			get => GetProperty(ref _emitterDelaySettings);
			set => SetProperty(ref _emitterDelaySettings, value);
		}

		[Ordinal(2)] 
		[RED("burstList")] 
		public CArray<ParticleBurst> BurstList
		{
			get => GetProperty(ref _burstList);
			set => SetProperty(ref _burstList, value);
		}

		[Ordinal(3)] 
		[RED("birthRate")] 
		public CHandle<IEvaluatorFloat> BirthRate
		{
			get => GetProperty(ref _birthRate);
			set => SetProperty(ref _birthRate, value);
		}

		[Ordinal(4)] 
		[RED("sortingMode")] 
		public CEnum<rendEParticleSortingMode> SortingMode
		{
			get => GetProperty(ref _sortingMode);
			set => SetProperty(ref _sortingMode, value);
		}

		[Ordinal(5)] 
		[RED("lodSwitchDistance")] 
		public CFloat LodSwitchDistance
		{
			get => GetProperty(ref _lodSwitchDistance);
			set => SetProperty(ref _lodSwitchDistance, value);
		}

		[Ordinal(6)] 
		[RED("isEnabled")] 
		public CBool IsEnabled
		{
			get => GetProperty(ref _isEnabled);
			set => SetProperty(ref _isEnabled, value);
		}
	}
}
