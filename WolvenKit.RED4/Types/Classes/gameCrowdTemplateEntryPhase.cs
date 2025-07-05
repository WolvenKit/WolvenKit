using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCrowdTemplateEntryPhase : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("timePeriods")] 
		public CArray<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get => GetPropertyValue<CArray<gameCrowdPhaseTimePeriod>>();
			set => SetPropertyValue<CArray<gameCrowdPhaseTimePeriod>>(value);
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("charactersData")] 
		public CArray<gameCrowdTemplateCharacterData> CharactersData
		{
			get => GetPropertyValue<CArray<gameCrowdTemplateCharacterData>>();
			set => SetPropertyValue<CArray<gameCrowdTemplateCharacterData>>(value);
		}

		[Ordinal(4)] 
		[RED("legacy")] 
		public CBool Legacy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("legacyDensityInTimePeriods")] 
		public CBool LegacyDensityInTimePeriods
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("legacyCharactersData")] 
		public CBool LegacyCharactersData
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameCrowdTemplateEntryPhase()
		{
			TimePeriods = new() { new gameCrowdPhaseTimePeriod { Density_52 = 0.500000F, Density_56 = "Zero", WorkspotsUsage = 0.500000F, CharactersData = new(), ReducedCharactersData = new(), UseDensityPreset = true } };
			CharactersData = new();
			Legacy = true;
			LegacyDensityInTimePeriods = true;
			LegacyCharactersData = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
