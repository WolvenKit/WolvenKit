using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProficiencyDisplayData : IDisplayData
	{
		private TweakDBID _attributeId;
		private CEnum<gamedataProficiencyType> _proficiency;
		private CInt32 _index;
		private CArray<CHandle<AreaDisplayData>> _areas;
		private CArray<CHandle<LevelRewardDisplayData>> _passiveBonusesData;
		private CHandle<TraitDisplayData> _traitData;
		private CString _localizedName;
		private CString _localizedDescription;
		private CInt32 _level;
		private CInt32 _maxLevel;
		private CInt32 _expPoints;
		private CInt32 _maxExpPoints;
		private CInt32 _unlockedLevel;

		[Ordinal(0)] 
		[RED("attributeId")] 
		public TweakDBID AttributeId
		{
			get
			{
				if (_attributeId == null)
				{
					_attributeId = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "attributeId", cr2w, this);
				}
				return _attributeId;
			}
			set
			{
				if (_attributeId == value)
				{
					return;
				}
				_attributeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("proficiency")] 
		public CEnum<gamedataProficiencyType> Proficiency
		{
			get
			{
				if (_proficiency == null)
				{
					_proficiency = (CEnum<gamedataProficiencyType>) CR2WTypeManager.Create("gamedataProficiencyType", "proficiency", cr2w, this);
				}
				return _proficiency;
			}
			set
			{
				if (_proficiency == value)
				{
					return;
				}
				_proficiency = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("index")] 
		public CInt32 Index
		{
			get
			{
				if (_index == null)
				{
					_index = (CInt32) CR2WTypeManager.Create("Int32", "index", cr2w, this);
				}
				return _index;
			}
			set
			{
				if (_index == value)
				{
					return;
				}
				_index = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("areas")] 
		public CArray<CHandle<AreaDisplayData>> Areas
		{
			get
			{
				if (_areas == null)
				{
					_areas = (CArray<CHandle<AreaDisplayData>>) CR2WTypeManager.Create("array:handle:AreaDisplayData", "areas", cr2w, this);
				}
				return _areas;
			}
			set
			{
				if (_areas == value)
				{
					return;
				}
				_areas = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("passiveBonusesData")] 
		public CArray<CHandle<LevelRewardDisplayData>> PassiveBonusesData
		{
			get
			{
				if (_passiveBonusesData == null)
				{
					_passiveBonusesData = (CArray<CHandle<LevelRewardDisplayData>>) CR2WTypeManager.Create("array:handle:LevelRewardDisplayData", "passiveBonusesData", cr2w, this);
				}
				return _passiveBonusesData;
			}
			set
			{
				if (_passiveBonusesData == value)
				{
					return;
				}
				_passiveBonusesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("traitData")] 
		public CHandle<TraitDisplayData> TraitData
		{
			get
			{
				if (_traitData == null)
				{
					_traitData = (CHandle<TraitDisplayData>) CR2WTypeManager.Create("handle:TraitDisplayData", "traitData", cr2w, this);
				}
				return _traitData;
			}
			set
			{
				if (_traitData == value)
				{
					return;
				}
				_traitData = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("localizedName")] 
		public CString LocalizedName
		{
			get
			{
				if (_localizedName == null)
				{
					_localizedName = (CString) CR2WTypeManager.Create("String", "localizedName", cr2w, this);
				}
				return _localizedName;
			}
			set
			{
				if (_localizedName == value)
				{
					return;
				}
				_localizedName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("localizedDescription")] 
		public CString LocalizedDescription
		{
			get
			{
				if (_localizedDescription == null)
				{
					_localizedDescription = (CString) CR2WTypeManager.Create("String", "localizedDescription", cr2w, this);
				}
				return _localizedDescription;
			}
			set
			{
				if (_localizedDescription == value)
				{
					return;
				}
				_localizedDescription = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("level")] 
		public CInt32 Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CInt32) CR2WTypeManager.Create("Int32", "level", cr2w, this);
				}
				return _level;
			}
			set
			{
				if (_level == value)
				{
					return;
				}
				_level = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxLevel")] 
		public CInt32 MaxLevel
		{
			get
			{
				if (_maxLevel == null)
				{
					_maxLevel = (CInt32) CR2WTypeManager.Create("Int32", "maxLevel", cr2w, this);
				}
				return _maxLevel;
			}
			set
			{
				if (_maxLevel == value)
				{
					return;
				}
				_maxLevel = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("expPoints")] 
		public CInt32 ExpPoints
		{
			get
			{
				if (_expPoints == null)
				{
					_expPoints = (CInt32) CR2WTypeManager.Create("Int32", "expPoints", cr2w, this);
				}
				return _expPoints;
			}
			set
			{
				if (_expPoints == value)
				{
					return;
				}
				_expPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("maxExpPoints")] 
		public CInt32 MaxExpPoints
		{
			get
			{
				if (_maxExpPoints == null)
				{
					_maxExpPoints = (CInt32) CR2WTypeManager.Create("Int32", "maxExpPoints", cr2w, this);
				}
				return _maxExpPoints;
			}
			set
			{
				if (_maxExpPoints == value)
				{
					return;
				}
				_maxExpPoints = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("unlockedLevel")] 
		public CInt32 UnlockedLevel
		{
			get
			{
				if (_unlockedLevel == null)
				{
					_unlockedLevel = (CInt32) CR2WTypeManager.Create("Int32", "unlockedLevel", cr2w, this);
				}
				return _unlockedLevel;
			}
			set
			{
				if (_unlockedLevel == value)
				{
					return;
				}
				_unlockedLevel = value;
				PropertySet(this);
			}
		}

		public ProficiencyDisplayData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
