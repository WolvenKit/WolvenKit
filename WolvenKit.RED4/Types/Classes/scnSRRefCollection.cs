using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class scnSRRefCollection : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("ridAnimations")] 
		public CArray<scnRidAnimationSRRef> RidAnimations
		{
			get => GetPropertyValue<CArray<scnRidAnimationSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimationSRRef>>(value);
		}

		[Ordinal(1)] 
		[RED("ridAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidAnimSets
		{
			get => GetPropertyValue<CArray<scnRidAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimSetSRRef>>(value);
		}

		[Ordinal(2)] 
		[RED("ridFacialAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidFacialAnimSets
		{
			get => GetPropertyValue<CArray<scnRidAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimSetSRRef>>(value);
		}

		[Ordinal(3)] 
		[RED("ridCyberwareAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidCyberwareAnimSets
		{
			get => GetPropertyValue<CArray<scnRidAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimSetSRRef>>(value);
		}

		[Ordinal(4)] 
		[RED("ridDeformationAnimSets")] 
		public CArray<scnRidAnimSetSRRef> RidDeformationAnimSets
		{
			get => GetPropertyValue<CArray<scnRidAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimSetSRRef>>(value);
		}

		[Ordinal(5)] 
		[RED("lipsyncAnimSets")] 
		public CArray<scnLipsyncAnimSetSRRef> LipsyncAnimSets
		{
			get => GetPropertyValue<CArray<scnLipsyncAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnLipsyncAnimSetSRRef>>(value);
		}

		[Ordinal(6)] 
		[RED("ridCameraAnimations")] 
		public CArray<scnRidCameraAnimationSRRef> RidCameraAnimations
		{
			get => GetPropertyValue<CArray<scnRidCameraAnimationSRRef>>();
			set => SetPropertyValue<CArray<scnRidCameraAnimationSRRef>>(value);
		}

		[Ordinal(7)] 
		[RED("cinematicAnimSets")] 
		public CArray<scnCinematicAnimSetSRRef> CinematicAnimSets
		{
			get => GetPropertyValue<CArray<scnCinematicAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnCinematicAnimSetSRRef>>(value);
		}

		[Ordinal(8)] 
		[RED("gameplayAnimSets")] 
		public CArray<scnGameplayAnimSetSRRef> GameplayAnimSets
		{
			get => GetPropertyValue<CArray<scnGameplayAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnGameplayAnimSetSRRef>>(value);
		}

		[Ordinal(9)] 
		[RED("dynamicAnimSets")] 
		public CArray<scnDynamicAnimSetSRRef> DynamicAnimSets
		{
			get => GetPropertyValue<CArray<scnDynamicAnimSetSRRef>>();
			set => SetPropertyValue<CArray<scnDynamicAnimSetSRRef>>(value);
		}

		[Ordinal(10)] 
		[RED("cinematicAnimNames")] 
		public CArray<scnAnimSetAnimNames> CinematicAnimNames
		{
			get => GetPropertyValue<CArray<scnAnimSetAnimNames>>();
			set => SetPropertyValue<CArray<scnAnimSetAnimNames>>(value);
		}

		[Ordinal(11)] 
		[RED("gameplayAnimNames")] 
		public CArray<scnAnimSetAnimNames> GameplayAnimNames
		{
			get => GetPropertyValue<CArray<scnAnimSetAnimNames>>();
			set => SetPropertyValue<CArray<scnAnimSetAnimNames>>(value);
		}

		[Ordinal(12)] 
		[RED("dynamicAnimNames")] 
		public CArray<scnAnimSetDynAnimNames> DynamicAnimNames
		{
			get => GetPropertyValue<CArray<scnAnimSetDynAnimNames>>();
			set => SetPropertyValue<CArray<scnAnimSetDynAnimNames>>(value);
		}

		[Ordinal(13)] 
		[RED("ridAnimationContainers")] 
		public CArray<scnRidAnimationContainerSRRef> RidAnimationContainers
		{
			get => GetPropertyValue<CArray<scnRidAnimationContainerSRRef>>();
			set => SetPropertyValue<CArray<scnRidAnimationContainerSRRef>>(value);
		}

		public scnSRRefCollection()
		{
			RidAnimations = new();
			RidAnimSets = new();
			RidFacialAnimSets = new();
			RidCyberwareAnimSets = new();
			RidDeformationAnimSets = new();
			LipsyncAnimSets = new();
			RidCameraAnimations = new();
			CinematicAnimSets = new();
			GameplayAnimSets = new();
			DynamicAnimSets = new();
			CinematicAnimNames = new();
			GameplayAnimNames = new();
			DynamicAnimNames = new();
			RidAnimationContainers = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
