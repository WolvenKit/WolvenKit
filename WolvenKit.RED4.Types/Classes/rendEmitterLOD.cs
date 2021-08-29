using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class rendEmitterLOD : RedBaseClass
	{
		private CFloat _lodSwitchDistance;
		private CArray<rendParticleBurst> _burstList;
		private CArray<CFloat> _birthRate;
		private rendEmitterDurationSettings _emitterDurationSettings;
		private rendEmitterDelaySettings _emitterDelaySettings;
		private CEnum<rendEParticleSortingMode> _sortingMode;
		private CBool _isEnabled;

		[Ordinal(0)] 
		[RED("lodSwitchDistance")] 
		public CFloat LodSwitchDistance
		{
			get => GetProperty(ref _lodSwitchDistance);
			set => SetProperty(ref _lodSwitchDistance, value);
		}

		[Ordinal(1)] 
		[RED("burstList")] 
		public CArray<rendParticleBurst> BurstList
		{
			get => GetProperty(ref _burstList);
			set => SetProperty(ref _burstList, value);
		}

		[Ordinal(2)] 
		[RED("birthRate")] 
		public CArray<CFloat> BirthRate
		{
			get => GetProperty(ref _birthRate);
			set => SetProperty(ref _birthRate, value);
		}

		[Ordinal(3)] 
		[RED("emitterDurationSettings")] 
		public rendEmitterDurationSettings EmitterDurationSettings
		{
			get => GetProperty(ref _emitterDurationSettings);
			set => SetProperty(ref _emitterDurationSettings, value);
		}

		[Ordinal(4)] 
		[RED("emitterDelaySettings")] 
		public rendEmitterDelaySettings EmitterDelaySettings
		{
			get => GetProperty(ref _emitterDelaySettings);
			set => SetProperty(ref _emitterDelaySettings, value);
		}

		[Ordinal(5)] 
		[RED("sortingMode")] 
		public CEnum<rendEParticleSortingMode> SortingMode
		{
			get => GetProperty(ref _sortingMode);
			set => SetProperty(ref _sortingMode, value);
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
