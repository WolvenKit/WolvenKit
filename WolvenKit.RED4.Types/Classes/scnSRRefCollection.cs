using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSRRefCollection : RedBaseClass
	{
		private CArray<scnRidAnimationSRRef> _ridAnimations;
		private CArray<scnRidAnimSetSRRef> _ridAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridFacialAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridCyberwareAnimSets;
		private CArray<scnRidAnimSetSRRef> _ridDeformationAnimSets;
		private CArray<scnLipsyncAnimSetSRRef> _lipsyncAnimSets;
		private CArray<scnRidCameraAnimationSRRef> _ridCameraAnimations;
		private CArray<scnCinematicAnimSetSRRef> _cinematicAnimSets;
		private CArray<scnGameplayAnimSetSRRef> _gameplayAnimSets;
		private CArray<scnDynamicAnimSetSRRef> _dynamicAnimSets;
		private CArray<scnAnimSetAnimNames> _cinematicAnimNames;
		private CArray<scnAnimSetAnimNames> _gameplayAnimNames;
		private CArray<scnAnimSetDynAnimNames> _dynamicAnimNames;
		private CArray<scnRidAnimationContainerSRRef> _ridAnimationContainers;

		[Ordinal(0)] 
		[RED("ridAnimations")] 
		public CArray<scnRidAnimationSRRef> RidAnimations
		{
			get => GetProperty(ref _ridAnimations);
			set => SetProperty(ref _ridAnimations, value);
		}

		[Ordinal(1)] 
		[RED("ridAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidAnimSets
		{
			get => GetProperty(ref _ridAnimSets);
			set => SetProperty(ref _ridAnimSets, value);
		}

		[Ordinal(2)] 
		[RED("ridFacialAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidFacialAnimSets
		{
			get => GetProperty(ref _ridFacialAnimSets);
			set => SetProperty(ref _ridFacialAnimSets, value);
		}

		[Ordinal(3)] 
		[RED("ridCyberwareAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidCyberwareAnimSets
		{
			get => GetProperty(ref _ridCyberwareAnimSets);
			set => SetProperty(ref _ridCyberwareAnimSets, value);
		}

		[Ordinal(4)] 
		[RED("ridDeformationAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidDeformationAnimSets
		{
			get => GetProperty(ref _ridDeformationAnimSets);
			set => SetProperty(ref _ridDeformationAnimSets, value);
		}

		[Ordinal(5)] 
		[RED("lipsyncAnimSets")] 
		public CArray<scnLipsyncAnimSetSRRef> LipsyncAnimSets
		{
			get => GetProperty(ref _lipsyncAnimSets);
			set => SetProperty(ref _lipsyncAnimSets, value);
		}

		[Ordinal(6)] 
		[RED("ridCameraAnimations")] 
		public CArray<scnRidCameraAnimationSRRef> RidCameraAnimations
		{
			get => GetProperty(ref _ridCameraAnimations);
			set => SetProperty(ref _ridCameraAnimations, value);
		}

		[Ordinal(7)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRef> CinematicAnimSets
		{
			get => GetProperty(ref _cinematicAnimSets);
			set => SetProperty(ref _cinematicAnimSets, value);
		}

		[Ordinal(8)] 
		[RED("gameplayAnimSets")] 
		public CArray<scnGameplayAnimSetSRRef> GameplayAnimSets
		{
			get => GetProperty(ref _gameplayAnimSets);
			set => SetProperty(ref _gameplayAnimSets, value);
		}

		[Ordinal(9)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRef> DynamicAnimSets
		{
			get => GetProperty(ref _dynamicAnimSets);
			set => SetProperty(ref _dynamicAnimSets, value);
		}

		[Ordinal(10)] 
		[RED("cinematicAnimNames")] 
		public CArray<scnAnimSetAnimNames> CinematicAnimNames
		{
			get => GetProperty(ref _cinematicAnimNames);
			set => SetProperty(ref _cinematicAnimNames, value);
		}

		[Ordinal(11)] 
		[RED("gameplayAnimNames")] 
		public CArray<scnAnimSetAnimNames> GameplayAnimNames
		{
			get => GetProperty(ref _gameplayAnimNames);
			set => SetProperty(ref _gameplayAnimNames, value);
		}

		[Ordinal(12)] 
		[RED("dynamicAnimNames")] 
		public CArray<scnAnimSetDynAnimNames> DynamicAnimNames
		{
			get => GetProperty(ref _dynamicAnimNames);
			set => SetProperty(ref _dynamicAnimNames, value);
		}

		[Ordinal(13)] 
		[RED("ridAnimationContainers")] 
		public CArray<scnRidAnimationContainerSRRef> RidAnimationContainers
		{
			get => GetProperty(ref _ridAnimationContainers);
			set => SetProperty(ref _ridAnimationContainers, value);
		}
	}
}
