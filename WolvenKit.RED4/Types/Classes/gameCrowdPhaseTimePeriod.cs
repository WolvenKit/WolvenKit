using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdPhaseTimePeriod : communityTimePeriod
	{
		[Ordinal(1)] 
		[RED("mergeMode")] 
		public CEnum<gameCrowdCreationDataMergeMode> MergeMode
		{
			get => GetPropertyValue<CEnum<gameCrowdCreationDataMergeMode>>();
			set => SetPropertyValue<CEnum<gameCrowdCreationDataMergeMode>>(value);
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density_52
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("Density")] 
		public CName Density_56
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("workspotsUsage")] 
		public CFloat WorkspotsUsage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("charactersData")] 
		public CArray<gameCrowdTemplateCharacterData> CharactersData
		{
			get => GetPropertyValue<CArray<gameCrowdTemplateCharacterData>>();
			set => SetPropertyValue<CArray<gameCrowdTemplateCharacterData>>(value);
		}

		[Ordinal(6)] 
		[RED("reducedCharactersData")] 
		public CArray<gameCrowdTemplateCharacterData> ReducedCharactersData
		{
			get => GetPropertyValue<CArray<gameCrowdTemplateCharacterData>>();
			set => SetPropertyValue<CArray<gameCrowdTemplateCharacterData>>(value);
		}

		[Ordinal(7)] 
		[RED("crowdType")] 
		public CEnum<gameCrowdEntryType> CrowdType
		{
			get => GetPropertyValue<CEnum<gameCrowdEntryType>>();
			set => SetPropertyValue<CEnum<gameCrowdEntryType>>(value);
		}

		[Ordinal(8)] 
		[RED("useDensityPreset")] 
		public CBool UseDensityPreset
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameCrowdPhaseTimePeriod()
		{
			Density_52 = 0.500000F;
			Density_56 = "Zero";
			WorkspotsUsage = 0.500000F;
			CharactersData = new();
			ReducedCharactersData = new();
			UseDensityPreset = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
