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
			get => GetProperty(ref _gameDefinition);
			set => SetProperty(ref _gameDefinition, value);
		}

		[Ordinal(1)] 
		[RED("activeQuests")] 
		public CString ActiveQuests
		{
			get => GetProperty(ref _activeQuests);
			set => SetProperty(ref _activeQuests, value);
		}

		[Ordinal(2)] 
		[RED("trackedQuestEntry")] 
		public CString TrackedQuestEntry
		{
			get => GetProperty(ref _trackedQuestEntry);
			set => SetProperty(ref _trackedQuestEntry, value);
		}

		[Ordinal(3)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetProperty(ref _trackedQuest);
			set => SetProperty(ref _trackedQuest, value);
		}

		[Ordinal(4)] 
		[RED("mainQuest")] 
		public CString MainQuest
		{
			get => GetProperty(ref _mainQuest);
			set => SetProperty(ref _mainQuest, value);
		}

		[Ordinal(5)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get => GetProperty(ref _debugString);
			set => SetProperty(ref _debugString, value);
		}

		[Ordinal(6)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetProperty(ref _locationName);
			set => SetProperty(ref _locationName, value);
		}

		[Ordinal(7)] 
		[RED("playerPosition")] 
		public Vector3 PlayerPosition
		{
			get => GetProperty(ref _playerPosition);
			set => SetProperty(ref _playerPosition, value);
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetProperty(ref _playTime);
			set => SetProperty(ref _playTime, value);
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetProperty(ref _playthroughTime);
			set => SetProperty(ref _playthroughTime, value);
		}

		[Ordinal(10)] 
		[RED("nextSavableEntityID")] 
		public CUInt32 NextSavableEntityID
		{
			get => GetProperty(ref _nextSavableEntityID);
			set => SetProperty(ref _nextSavableEntityID, value);
		}

		[Ordinal(11)] 
		[RED("nextNonSavableEntityID")] 
		public CUInt32 NextNonSavableEntityID
		{
			get => GetProperty(ref _nextNonSavableEntityID);
			set => SetProperty(ref _nextNonSavableEntityID, value);
		}

		[Ordinal(12)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get => GetProperty(ref _lifePath);
			set => SetProperty(ref _lifePath, value);
		}

		[Ordinal(13)] 
		[RED("bodyGender")] 
		public CString BodyGender
		{
			get => GetProperty(ref _bodyGender);
			set => SetProperty(ref _bodyGender, value);
		}

		[Ordinal(14)] 
		[RED("brainGender")] 
		public CString BrainGender
		{
			get => GetProperty(ref _brainGender);
			set => SetProperty(ref _brainGender, value);
		}

		[Ordinal(15)] 
		[RED("level")] 
		public CFloat Level
		{
			get => GetProperty(ref _level);
			set => SetProperty(ref _level, value);
		}

		[Ordinal(16)] 
		[RED("streetCred")] 
		public CFloat StreetCred
		{
			get => GetProperty(ref _streetCred);
			set => SetProperty(ref _streetCred, value);
		}

		[Ordinal(17)] 
		[RED("gunslinger")] 
		public CFloat Gunslinger
		{
			get => GetProperty(ref _gunslinger);
			set => SetProperty(ref _gunslinger, value);
		}

		[Ordinal(18)] 
		[RED("assault")] 
		public CFloat Assault
		{
			get => GetProperty(ref _assault);
			set => SetProperty(ref _assault, value);
		}

		[Ordinal(19)] 
		[RED("demolition")] 
		public CFloat Demolition
		{
			get => GetProperty(ref _demolition);
			set => SetProperty(ref _demolition, value);
		}

		[Ordinal(20)] 
		[RED("athletics")] 
		public CFloat Athletics
		{
			get => GetProperty(ref _athletics);
			set => SetProperty(ref _athletics, value);
		}

		[Ordinal(21)] 
		[RED("brawling")] 
		public CFloat Brawling
		{
			get => GetProperty(ref _brawling);
			set => SetProperty(ref _brawling, value);
		}

		[Ordinal(22)] 
		[RED("coldBlood")] 
		public CFloat ColdBlood
		{
			get => GetProperty(ref _coldBlood);
			set => SetProperty(ref _coldBlood, value);
		}

		[Ordinal(23)] 
		[RED("stealth")] 
		public CFloat Stealth
		{
			get => GetProperty(ref _stealth);
			set => SetProperty(ref _stealth, value);
		}

		[Ordinal(24)] 
		[RED("engineering")] 
		public CFloat Engineering
		{
			get => GetProperty(ref _engineering);
			set => SetProperty(ref _engineering, value);
		}

		[Ordinal(25)] 
		[RED("crafting")] 
		public CFloat Crafting
		{
			get => GetProperty(ref _crafting);
			set => SetProperty(ref _crafting, value);
		}

		[Ordinal(26)] 
		[RED("hacking")] 
		public CFloat Hacking
		{
			get => GetProperty(ref _hacking);
			set => SetProperty(ref _hacking, value);
		}

		[Ordinal(27)] 
		[RED("combatHacking")] 
		public CFloat CombatHacking
		{
			get => GetProperty(ref _combatHacking);
			set => SetProperty(ref _combatHacking, value);
		}

		[Ordinal(28)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetProperty(ref _strength);
			set => SetProperty(ref _strength, value);
		}

		[Ordinal(29)] 
		[RED("intelligence")] 
		public CFloat Intelligence
		{
			get => GetProperty(ref _intelligence);
			set => SetProperty(ref _intelligence, value);
		}

		[Ordinal(30)] 
		[RED("reflexes")] 
		public CFloat Reflexes
		{
			get => GetProperty(ref _reflexes);
			set => SetProperty(ref _reflexes, value);
		}

		[Ordinal(31)] 
		[RED("technicalAbility")] 
		public CFloat TechnicalAbility
		{
			get => GetProperty(ref _technicalAbility);
			set => SetProperty(ref _technicalAbility, value);
		}

		[Ordinal(32)] 
		[RED("cool")] 
		public CFloat Cool
		{
			get => GetProperty(ref _cool);
			set => SetProperty(ref _cool, value);
		}

		[Ordinal(33)] 
		[RED("initialBuildID")] 
		public CString InitialBuildID
		{
			get => GetProperty(ref _initialBuildID);
			set => SetProperty(ref _initialBuildID, value);
		}

		[Ordinal(34)] 
		[RED("finishedQuests")] 
		public CString FinishedQuests
		{
			get => GetProperty(ref _finishedQuests);
			set => SetProperty(ref _finishedQuests, value);
		}

		[Ordinal(35)] 
		[RED("playthroughID")] 
		public CString PlaythroughID
		{
			get => GetProperty(ref _playthroughID);
			set => SetProperty(ref _playthroughID, value);
		}

		[Ordinal(36)] 
		[RED("pointOfNoReturnId")] 
		public CString PointOfNoReturnId
		{
			get => GetProperty(ref _pointOfNoReturnId);
			set => SetProperty(ref _pointOfNoReturnId, value);
		}

		[Ordinal(37)] 
		[RED("visitID")] 
		public CString VisitID
		{
			get => GetProperty(ref _visitID);
			set => SetProperty(ref _visitID, value);
		}

		[Ordinal(38)] 
		[RED("buildSKU")] 
		public CString BuildSKU
		{
			get => GetProperty(ref _buildSKU);
			set => SetProperty(ref _buildSKU, value);
		}

		[Ordinal(39)] 
		[RED("buildPatch")] 
		public CString BuildPatch
		{
			get => GetProperty(ref _buildPatch);
			set => SetProperty(ref _buildPatch, value);
		}

		[Ordinal(40)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get => GetProperty(ref _difficulty);
			set => SetProperty(ref _difficulty, value);
		}

		public saveGameMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
