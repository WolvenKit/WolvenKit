using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCrowdPhaseTimePeriod : communityTimePeriod
	{
		private CEnum<gameCrowdCreationDataMergeMode> _mergeMode;
		private CFloat _density_52;
		private CName _density_56;
		private CFloat _workspotsUsage;
		private CArray<gameCrowdTemplateCharacterData> _charactersData;
		private CArray<gameCrowdTemplateCharacterData> _reducedCharactersData;
		private CEnum<gameCrowdEntryType> _crowdType;
		private CBool _useDensityPreset;

		[Ordinal(1)] 
		[RED("mergeMode")] 
		public CEnum<gameCrowdCreationDataMergeMode> MergeMode
		{
			get => GetProperty(ref _mergeMode);
			set => SetProperty(ref _mergeMode, value);
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density_52
		{
			get => GetProperty(ref _density_52);
			set => SetProperty(ref _density_52, value);
		}

		[Ordinal(3)] 
		[RED("Density")] 
		public CName Density_56
		{
			get => GetProperty(ref _density_56);
			set => SetProperty(ref _density_56, value);
		}

		[Ordinal(4)] 
		[RED("workspotsUsage")] 
		public CFloat WorkspotsUsage
		{
			get => GetProperty(ref _workspotsUsage);
			set => SetProperty(ref _workspotsUsage, value);
		}

		[Ordinal(5)] 
		[RED("charactersData")] 
		public CArray<gameCrowdTemplateCharacterData> CharactersData
		{
			get => GetProperty(ref _charactersData);
			set => SetProperty(ref _charactersData, value);
		}

		[Ordinal(6)] 
		[RED("reducedCharactersData")] 
		public CArray<gameCrowdTemplateCharacterData> ReducedCharactersData
		{
			get => GetProperty(ref _reducedCharactersData);
			set => SetProperty(ref _reducedCharactersData, value);
		}

		[Ordinal(7)] 
		[RED("crowdType")] 
		public CEnum<gameCrowdEntryType> CrowdType
		{
			get => GetProperty(ref _crowdType);
			set => SetProperty(ref _crowdType, value);
		}

		[Ordinal(8)] 
		[RED("useDensityPreset")] 
		public CBool UseDensityPreset
		{
			get => GetProperty(ref _useDensityPreset);
			set => SetProperty(ref _useDensityPreset, value);
		}

		public gameCrowdPhaseTimePeriod(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
