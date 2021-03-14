using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class saveGameMetadata : CVariable
	{
		private CString _gameDefinition;
		private CString _activeQuests;
		private CString _trackedQuestEntry;
		private CString _trackedQuest;
		private CString _mainQuest;
		private CString _debugString;
		private CString _locationName;
		private Vector3 _playerPosition;
		private CDouble _playTime;
		private CDouble _playthroughTime;
		private CUInt32 _nextSavableEntityID;
		private CUInt32 _nextNonSavableEntityID;
		private CEnum<gamedataLifePath> _lifePath;
		private CString _bodyGender;
		private CString _brainGender;
		private CFloat _level;
		private CFloat _streetCred;
		private CFloat _gunslinger;
		private CFloat _assault;
		private CFloat _demolition;
		private CFloat _athletics;
		private CFloat _brawling;
		private CFloat _coldBlood;
		private CFloat _stealth;
		private CFloat _engineering;
		private CFloat _crafting;
		private CFloat _hacking;
		private CFloat _combatHacking;
		private CFloat _strength;
		private CFloat _intelligence;
		private CFloat _reflexes;
		private CFloat _technicalAbility;
		private CFloat _cool;
		private CString _initialBuildID;
		private CString _finishedQuests;
		private CString _playthroughID;
		private CString _pointOfNoReturnId;
		private CString _visitID;
		private CString _buildSKU;
		private CString _buildPatch;
		private CEnum<gameDifficulty> _difficulty;

		[Ordinal(0)] 
		[RED("gameDefinition")] 
		public CString GameDefinition
		{
			get
			{
				if (_gameDefinition == null)
				{
					_gameDefinition = (CString) CR2WTypeManager.Create("String", "gameDefinition", cr2w, this);
				}
				return _gameDefinition;
			}
			set
			{
				if (_gameDefinition == value)
				{
					return;
				}
				_gameDefinition = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("activeQuests")] 
		public CString ActiveQuests
		{
			get
			{
				if (_activeQuests == null)
				{
					_activeQuests = (CString) CR2WTypeManager.Create("String", "activeQuests", cr2w, this);
				}
				return _activeQuests;
			}
			set
			{
				if (_activeQuests == value)
				{
					return;
				}
				_activeQuests = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("trackedQuestEntry")] 
		public CString TrackedQuestEntry
		{
			get
			{
				if (_trackedQuestEntry == null)
				{
					_trackedQuestEntry = (CString) CR2WTypeManager.Create("String", "trackedQuestEntry", cr2w, this);
				}
				return _trackedQuestEntry;
			}
			set
			{
				if (_trackedQuestEntry == value)
				{
					return;
				}
				_trackedQuestEntry = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get
			{
				if (_trackedQuest == null)
				{
					_trackedQuest = (CString) CR2WTypeManager.Create("String", "trackedQuest", cr2w, this);
				}
				return _trackedQuest;
			}
			set
			{
				if (_trackedQuest == value)
				{
					return;
				}
				_trackedQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mainQuest")] 
		public CString MainQuest
		{
			get
			{
				if (_mainQuest == null)
				{
					_mainQuest = (CString) CR2WTypeManager.Create("String", "mainQuest", cr2w, this);
				}
				return _mainQuest;
			}
			set
			{
				if (_mainQuest == value)
				{
					return;
				}
				_mainQuest = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get
			{
				if (_debugString == null)
				{
					_debugString = (CString) CR2WTypeManager.Create("String", "debugString", cr2w, this);
				}
				return _debugString;
			}
			set
			{
				if (_debugString == value)
				{
					return;
				}
				_debugString = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get
			{
				if (_locationName == null)
				{
					_locationName = (CString) CR2WTypeManager.Create("String", "locationName", cr2w, this);
				}
				return _locationName;
			}
			set
			{
				if (_locationName == value)
				{
					return;
				}
				_locationName = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("playerPosition")] 
		public Vector3 PlayerPosition
		{
			get
			{
				if (_playerPosition == null)
				{
					_playerPosition = (Vector3) CR2WTypeManager.Create("Vector3", "playerPosition", cr2w, this);
				}
				return _playerPosition;
			}
			set
			{
				if (_playerPosition == value)
				{
					return;
				}
				_playerPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get
			{
				if (_playTime == null)
				{
					_playTime = (CDouble) CR2WTypeManager.Create("Double", "playTime", cr2w, this);
				}
				return _playTime;
			}
			set
			{
				if (_playTime == value)
				{
					return;
				}
				_playTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get
			{
				if (_playthroughTime == null)
				{
					_playthroughTime = (CDouble) CR2WTypeManager.Create("Double", "playthroughTime", cr2w, this);
				}
				return _playthroughTime;
			}
			set
			{
				if (_playthroughTime == value)
				{
					return;
				}
				_playthroughTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("nextSavableEntityID")] 
		public CUInt32 NextSavableEntityID
		{
			get
			{
				if (_nextSavableEntityID == null)
				{
					_nextSavableEntityID = (CUInt32) CR2WTypeManager.Create("Uint32", "nextSavableEntityID", cr2w, this);
				}
				return _nextSavableEntityID;
			}
			set
			{
				if (_nextSavableEntityID == value)
				{
					return;
				}
				_nextSavableEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("nextNonSavableEntityID")] 
		public CUInt32 NextNonSavableEntityID
		{
			get
			{
				if (_nextNonSavableEntityID == null)
				{
					_nextNonSavableEntityID = (CUInt32) CR2WTypeManager.Create("Uint32", "nextNonSavableEntityID", cr2w, this);
				}
				return _nextNonSavableEntityID;
			}
			set
			{
				if (_nextNonSavableEntityID == value)
				{
					return;
				}
				_nextNonSavableEntityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get
			{
				if (_lifePath == null)
				{
					_lifePath = (CEnum<gamedataLifePath>) CR2WTypeManager.Create("gamedataLifePath", "lifePath", cr2w, this);
				}
				return _lifePath;
			}
			set
			{
				if (_lifePath == value)
				{
					return;
				}
				_lifePath = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("bodyGender")] 
		public CString BodyGender
		{
			get
			{
				if (_bodyGender == null)
				{
					_bodyGender = (CString) CR2WTypeManager.Create("String", "bodyGender", cr2w, this);
				}
				return _bodyGender;
			}
			set
			{
				if (_bodyGender == value)
				{
					return;
				}
				_bodyGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("brainGender")] 
		public CString BrainGender
		{
			get
			{
				if (_brainGender == null)
				{
					_brainGender = (CString) CR2WTypeManager.Create("String", "brainGender", cr2w, this);
				}
				return _brainGender;
			}
			set
			{
				if (_brainGender == value)
				{
					return;
				}
				_brainGender = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("level")] 
		public CFloat Level
		{
			get
			{
				if (_level == null)
				{
					_level = (CFloat) CR2WTypeManager.Create("Float", "level", cr2w, this);
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

		[Ordinal(16)] 
		[RED("streetCred")] 
		public CFloat StreetCred
		{
			get
			{
				if (_streetCred == null)
				{
					_streetCred = (CFloat) CR2WTypeManager.Create("Float", "streetCred", cr2w, this);
				}
				return _streetCred;
			}
			set
			{
				if (_streetCred == value)
				{
					return;
				}
				_streetCred = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("gunslinger")] 
		public CFloat Gunslinger
		{
			get
			{
				if (_gunslinger == null)
				{
					_gunslinger = (CFloat) CR2WTypeManager.Create("Float", "gunslinger", cr2w, this);
				}
				return _gunslinger;
			}
			set
			{
				if (_gunslinger == value)
				{
					return;
				}
				_gunslinger = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("assault")] 
		public CFloat Assault
		{
			get
			{
				if (_assault == null)
				{
					_assault = (CFloat) CR2WTypeManager.Create("Float", "assault", cr2w, this);
				}
				return _assault;
			}
			set
			{
				if (_assault == value)
				{
					return;
				}
				_assault = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("demolition")] 
		public CFloat Demolition
		{
			get
			{
				if (_demolition == null)
				{
					_demolition = (CFloat) CR2WTypeManager.Create("Float", "demolition", cr2w, this);
				}
				return _demolition;
			}
			set
			{
				if (_demolition == value)
				{
					return;
				}
				_demolition = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("athletics")] 
		public CFloat Athletics
		{
			get
			{
				if (_athletics == null)
				{
					_athletics = (CFloat) CR2WTypeManager.Create("Float", "athletics", cr2w, this);
				}
				return _athletics;
			}
			set
			{
				if (_athletics == value)
				{
					return;
				}
				_athletics = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("brawling")] 
		public CFloat Brawling
		{
			get
			{
				if (_brawling == null)
				{
					_brawling = (CFloat) CR2WTypeManager.Create("Float", "brawling", cr2w, this);
				}
				return _brawling;
			}
			set
			{
				if (_brawling == value)
				{
					return;
				}
				_brawling = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("coldBlood")] 
		public CFloat ColdBlood
		{
			get
			{
				if (_coldBlood == null)
				{
					_coldBlood = (CFloat) CR2WTypeManager.Create("Float", "coldBlood", cr2w, this);
				}
				return _coldBlood;
			}
			set
			{
				if (_coldBlood == value)
				{
					return;
				}
				_coldBlood = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("stealth")] 
		public CFloat Stealth
		{
			get
			{
				if (_stealth == null)
				{
					_stealth = (CFloat) CR2WTypeManager.Create("Float", "stealth", cr2w, this);
				}
				return _stealth;
			}
			set
			{
				if (_stealth == value)
				{
					return;
				}
				_stealth = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("engineering")] 
		public CFloat Engineering
		{
			get
			{
				if (_engineering == null)
				{
					_engineering = (CFloat) CR2WTypeManager.Create("Float", "engineering", cr2w, this);
				}
				return _engineering;
			}
			set
			{
				if (_engineering == value)
				{
					return;
				}
				_engineering = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("crafting")] 
		public CFloat Crafting
		{
			get
			{
				if (_crafting == null)
				{
					_crafting = (CFloat) CR2WTypeManager.Create("Float", "crafting", cr2w, this);
				}
				return _crafting;
			}
			set
			{
				if (_crafting == value)
				{
					return;
				}
				_crafting = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("hacking")] 
		public CFloat Hacking
		{
			get
			{
				if (_hacking == null)
				{
					_hacking = (CFloat) CR2WTypeManager.Create("Float", "hacking", cr2w, this);
				}
				return _hacking;
			}
			set
			{
				if (_hacking == value)
				{
					return;
				}
				_hacking = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("combatHacking")] 
		public CFloat CombatHacking
		{
			get
			{
				if (_combatHacking == null)
				{
					_combatHacking = (CFloat) CR2WTypeManager.Create("Float", "combatHacking", cr2w, this);
				}
				return _combatHacking;
			}
			set
			{
				if (_combatHacking == value)
				{
					return;
				}
				_combatHacking = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get
			{
				if (_strength == null)
				{
					_strength = (CFloat) CR2WTypeManager.Create("Float", "strength", cr2w, this);
				}
				return _strength;
			}
			set
			{
				if (_strength == value)
				{
					return;
				}
				_strength = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("intelligence")] 
		public CFloat Intelligence
		{
			get
			{
				if (_intelligence == null)
				{
					_intelligence = (CFloat) CR2WTypeManager.Create("Float", "intelligence", cr2w, this);
				}
				return _intelligence;
			}
			set
			{
				if (_intelligence == value)
				{
					return;
				}
				_intelligence = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("reflexes")] 
		public CFloat Reflexes
		{
			get
			{
				if (_reflexes == null)
				{
					_reflexes = (CFloat) CR2WTypeManager.Create("Float", "reflexes", cr2w, this);
				}
				return _reflexes;
			}
			set
			{
				if (_reflexes == value)
				{
					return;
				}
				_reflexes = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("technicalAbility")] 
		public CFloat TechnicalAbility
		{
			get
			{
				if (_technicalAbility == null)
				{
					_technicalAbility = (CFloat) CR2WTypeManager.Create("Float", "technicalAbility", cr2w, this);
				}
				return _technicalAbility;
			}
			set
			{
				if (_technicalAbility == value)
				{
					return;
				}
				_technicalAbility = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("cool")] 
		public CFloat Cool
		{
			get
			{
				if (_cool == null)
				{
					_cool = (CFloat) CR2WTypeManager.Create("Float", "cool", cr2w, this);
				}
				return _cool;
			}
			set
			{
				if (_cool == value)
				{
					return;
				}
				_cool = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("initialBuildID")] 
		public CString InitialBuildID
		{
			get
			{
				if (_initialBuildID == null)
				{
					_initialBuildID = (CString) CR2WTypeManager.Create("String", "initialBuildID", cr2w, this);
				}
				return _initialBuildID;
			}
			set
			{
				if (_initialBuildID == value)
				{
					return;
				}
				_initialBuildID = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("finishedQuests")] 
		public CString FinishedQuests
		{
			get
			{
				if (_finishedQuests == null)
				{
					_finishedQuests = (CString) CR2WTypeManager.Create("String", "finishedQuests", cr2w, this);
				}
				return _finishedQuests;
			}
			set
			{
				if (_finishedQuests == value)
				{
					return;
				}
				_finishedQuests = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("playthroughID")] 
		public CString PlaythroughID
		{
			get
			{
				if (_playthroughID == null)
				{
					_playthroughID = (CString) CR2WTypeManager.Create("String", "playthroughID", cr2w, this);
				}
				return _playthroughID;
			}
			set
			{
				if (_playthroughID == value)
				{
					return;
				}
				_playthroughID = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("pointOfNoReturnId")] 
		public CString PointOfNoReturnId
		{
			get
			{
				if (_pointOfNoReturnId == null)
				{
					_pointOfNoReturnId = (CString) CR2WTypeManager.Create("String", "pointOfNoReturnId", cr2w, this);
				}
				return _pointOfNoReturnId;
			}
			set
			{
				if (_pointOfNoReturnId == value)
				{
					return;
				}
				_pointOfNoReturnId = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("visitID")] 
		public CString VisitID
		{
			get
			{
				if (_visitID == null)
				{
					_visitID = (CString) CR2WTypeManager.Create("String", "visitID", cr2w, this);
				}
				return _visitID;
			}
			set
			{
				if (_visitID == value)
				{
					return;
				}
				_visitID = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("buildSKU")] 
		public CString BuildSKU
		{
			get
			{
				if (_buildSKU == null)
				{
					_buildSKU = (CString) CR2WTypeManager.Create("String", "buildSKU", cr2w, this);
				}
				return _buildSKU;
			}
			set
			{
				if (_buildSKU == value)
				{
					return;
				}
				_buildSKU = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("buildPatch")] 
		public CString BuildPatch
		{
			get
			{
				if (_buildPatch == null)
				{
					_buildPatch = (CString) CR2WTypeManager.Create("String", "buildPatch", cr2w, this);
				}
				return _buildPatch;
			}
			set
			{
				if (_buildPatch == value)
				{
					return;
				}
				_buildPatch = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get
			{
				if (_difficulty == null)
				{
					_difficulty = (CEnum<gameDifficulty>) CR2WTypeManager.Create("gameDifficulty", "difficulty", cr2w, this);
				}
				return _difficulty;
			}
			set
			{
				if (_difficulty == value)
				{
					return;
				}
				_difficulty = value;
				PropertySet(this);
			}
		}

		public saveGameMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
