using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdTemplateEntryPhase : CVariable
	{
		private CName _phaseName;
		private CArray<gameCrowdPhaseTimePeriod> _timePeriods;
		private CFloat _density;
		private CArray<gameCrowdTemplateCharacterData> _charactersData;
		private CBool _legacy;
		private CBool _legacyDensityInTimePeriods;
		private CBool _legacyCharactersData;

		[Ordinal(0)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get => GetProperty(ref _phaseName);
			set => SetProperty(ref _phaseName, value);
		}

		[Ordinal(1)] 
		[RED("timePeriods")] 
		public CArray<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get => GetProperty(ref _timePeriods);
			set => SetProperty(ref _timePeriods, value);
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density
		{
			get => GetProperty(ref _density);
			set => SetProperty(ref _density, value);
		}

		[Ordinal(3)] 
		[RED("charactersData")] 
		public CArray<gameCrowdTemplateCharacterData> CharactersData
		{
			get => GetProperty(ref _charactersData);
			set => SetProperty(ref _charactersData, value);
		}

		[Ordinal(4)] 
		[RED("legacy")] 
		public CBool Legacy
		{
			get => GetProperty(ref _legacy);
			set => SetProperty(ref _legacy, value);
		}

		[Ordinal(5)] 
		[RED("legacyDensityInTimePeriods")] 
		public CBool LegacyDensityInTimePeriods
		{
			get => GetProperty(ref _legacyDensityInTimePeriods);
			set => SetProperty(ref _legacyDensityInTimePeriods, value);
		}

		[Ordinal(6)] 
		[RED("legacyCharactersData")] 
		public CBool LegacyCharactersData
		{
			get => GetProperty(ref _legacyCharactersData);
			set => SetProperty(ref _legacyCharactersData, value);
		}

		public gameCrowdTemplateEntryPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
