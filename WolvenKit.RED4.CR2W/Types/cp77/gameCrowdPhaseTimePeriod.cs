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
			get
			{
				if (_mergeMode == null)
				{
					_mergeMode = (CEnum<gameCrowdCreationDataMergeMode>) CR2WTypeManager.Create("gameCrowdCreationDataMergeMode", "mergeMode", cr2w, this);
				}
				return _mergeMode;
			}
			set
			{
				if (_mergeMode == value)
				{
					return;
				}
				_mergeMode = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density_52
		{
			get
			{
				if (_density_52 == null)
				{
                    _density_52 = (CFloat) CR2WTypeManager.Create("Float", "density", cr2w, this);
				}
				return _density_52;
			}
			set
			{
				if (_density_52 == value)
				{
					return;
				}
                _density_52 = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("Density")] 
		public CName Density_56
		{
			get
			{
				if (_density_56 == null)
				{
                    _density_56 = (CName) CR2WTypeManager.Create("CName", "Density", cr2w, this);
				}
				return _density_56;
			}
			set
			{
				if (_density_56 == value)
				{
					return;
				}
                _density_56 = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("workspotsUsage")] 
		public CFloat WorkspotsUsage
		{
			get
			{
				if (_workspotsUsage == null)
				{
					_workspotsUsage = (CFloat) CR2WTypeManager.Create("Float", "workspotsUsage", cr2w, this);
				}
				return _workspotsUsage;
			}
			set
			{
				if (_workspotsUsage == value)
				{
					return;
				}
				_workspotsUsage = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("charactersData")] 
		public CArray<gameCrowdTemplateCharacterData> CharactersData
		{
			get
			{
				if (_charactersData == null)
				{
					_charactersData = (CArray<gameCrowdTemplateCharacterData>) CR2WTypeManager.Create("array:gameCrowdTemplateCharacterData", "charactersData", cr2w, this);
				}
				return _charactersData;
			}
			set
			{
				if (_charactersData == value)
				{
					return;
				}
				_charactersData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("reducedCharactersData")] 
		public CArray<gameCrowdTemplateCharacterData> ReducedCharactersData
		{
			get
			{
				if (_reducedCharactersData == null)
				{
					_reducedCharactersData = (CArray<gameCrowdTemplateCharacterData>) CR2WTypeManager.Create("array:gameCrowdTemplateCharacterData", "reducedCharactersData", cr2w, this);
				}
				return _reducedCharactersData;
			}
			set
			{
				if (_reducedCharactersData == value)
				{
					return;
				}
				_reducedCharactersData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("crowdType")] 
		public CEnum<gameCrowdEntryType> CrowdType
		{
			get
			{
				if (_crowdType == null)
				{
					_crowdType = (CEnum<gameCrowdEntryType>) CR2WTypeManager.Create("gameCrowdEntryType", "crowdType", cr2w, this);
				}
				return _crowdType;
			}
			set
			{
				if (_crowdType == value)
				{
					return;
				}
				_crowdType = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("useDensityPreset")] 
		public CBool UseDensityPreset
		{
			get
			{
				if (_useDensityPreset == null)
				{
					_useDensityPreset = (CBool) CR2WTypeManager.Create("Bool", "useDensityPreset", cr2w, this);
				}
				return _useDensityPreset;
			}
			set
			{
				if (_useDensityPreset == value)
				{
					return;
				}
				_useDensityPreset = value;
				PropertySet(this);
			}
		}

		public gameCrowdPhaseTimePeriod(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
