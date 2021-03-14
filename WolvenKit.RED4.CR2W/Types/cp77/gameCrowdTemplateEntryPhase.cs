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
			get
			{
				if (_phaseName == null)
				{
					_phaseName = (CName) CR2WTypeManager.Create("CName", "phaseName", cr2w, this);
				}
				return _phaseName;
			}
			set
			{
				if (_phaseName == value)
				{
					return;
				}
				_phaseName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("timePeriods")] 
		public CArray<gameCrowdPhaseTimePeriod> TimePeriods
		{
			get
			{
				if (_timePeriods == null)
				{
					_timePeriods = (CArray<gameCrowdPhaseTimePeriod>) CR2WTypeManager.Create("array:gameCrowdPhaseTimePeriod", "timePeriods", cr2w, this);
				}
				return _timePeriods;
			}
			set
			{
				if (_timePeriods == value)
				{
					return;
				}
				_timePeriods = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("density")] 
		public CFloat Density
		{
			get
			{
				if (_density == null)
				{
					_density = (CFloat) CR2WTypeManager.Create("Float", "density", cr2w, this);
				}
				return _density;
			}
			set
			{
				if (_density == value)
				{
					return;
				}
				_density = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
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

		[Ordinal(4)] 
		[RED("legacy")] 
		public CBool Legacy
		{
			get
			{
				if (_legacy == null)
				{
					_legacy = (CBool) CR2WTypeManager.Create("Bool", "legacy", cr2w, this);
				}
				return _legacy;
			}
			set
			{
				if (_legacy == value)
				{
					return;
				}
				_legacy = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("legacyDensityInTimePeriods")] 
		public CBool LegacyDensityInTimePeriods
		{
			get
			{
				if (_legacyDensityInTimePeriods == null)
				{
					_legacyDensityInTimePeriods = (CBool) CR2WTypeManager.Create("Bool", "legacyDensityInTimePeriods", cr2w, this);
				}
				return _legacyDensityInTimePeriods;
			}
			set
			{
				if (_legacyDensityInTimePeriods == value)
				{
					return;
				}
				_legacyDensityInTimePeriods = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("legacyCharactersData")] 
		public CBool LegacyCharactersData
		{
			get
			{
				if (_legacyCharactersData == null)
				{
					_legacyCharactersData = (CBool) CR2WTypeManager.Create("Bool", "legacyCharactersData", cr2w, this);
				}
				return _legacyCharactersData;
			}
			set
			{
				if (_legacyCharactersData == value)
				{
					return;
				}
				_legacyCharactersData = value;
				PropertySet(this);
			}
		}

		public gameCrowdTemplateEntryPhase(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
