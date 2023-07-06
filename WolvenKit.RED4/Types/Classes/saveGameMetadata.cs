using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class saveGameMetadata : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("gameDefinition")] 
		public CString GameDefinition
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("activeQuests")] 
		public CString ActiveQuests
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("trackedQuestEntry")] 
		public CString TrackedQuestEntry
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(3)] 
		[RED("trackedQuest")] 
		public CString TrackedQuest
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(4)] 
		[RED("mainQuest")] 
		public CString MainQuest
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(5)] 
		[RED("debugString")] 
		public CString DebugString
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(6)] 
		[RED("locationName")] 
		public CString LocationName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(7)] 
		[RED("playerPosition")] 
		public Vector3 PlayerPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(8)] 
		[RED("playTime")] 
		public CDouble PlayTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(9)] 
		[RED("playthroughTime")] 
		public CDouble PlaythroughTime
		{
			get => GetPropertyValue<CDouble>();
			set => SetPropertyValue<CDouble>(value);
		}

		[Ordinal(10)] 
		[RED("nextSavableEntityID")] 
		public CUInt32 NextSavableEntityID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(11)] 
		[RED("nextNonSavableEntityID")] 
		public CUInt32 NextNonSavableEntityID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("lifePath")] 
		public CEnum<gamedataLifePath> LifePath
		{
			get => GetPropertyValue<CEnum<gamedataLifePath>>();
			set => SetPropertyValue<CEnum<gamedataLifePath>>(value);
		}

		[Ordinal(13)] 
		[RED("bodyGender")] 
		public CString BodyGender
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("brainGender")] 
		public CString BrainGender
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("level")] 
		public CFloat Level
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("streetCred")] 
		public CFloat StreetCred
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("gunslinger")] 
		public CFloat Gunslinger
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("assault")] 
		public CFloat Assault
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("demolition")] 
		public CFloat Demolition
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("athletics")] 
		public CFloat Athletics
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("brawling")] 
		public CFloat Brawling
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("coldBlood")] 
		public CFloat ColdBlood
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("stealth")] 
		public CFloat Stealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("engineering")] 
		public CFloat Engineering
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("crafting")] 
		public CFloat Crafting
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(26)] 
		[RED("hacking")] 
		public CFloat Hacking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(27)] 
		[RED("combatHacking")] 
		public CFloat CombatHacking
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(28)] 
		[RED("strength")] 
		public CFloat Strength
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(29)] 
		[RED("intelligence")] 
		public CFloat Intelligence
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(30)] 
		[RED("reflexes")] 
		public CFloat Reflexes
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(31)] 
		[RED("technicalAbility")] 
		public CFloat TechnicalAbility
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("cool")] 
		public CFloat Cool
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("initialBuildID")] 
		public CString InitialBuildID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(34)] 
		[RED("finishedQuests")] 
		public CString FinishedQuests
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(35)] 
		[RED("playthroughID")] 
		public CString PlaythroughID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(36)] 
		[RED("pointOfNoReturnId")] 
		public CString PointOfNoReturnId
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(37)] 
		[RED("visitID")] 
		public CString VisitID
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(38)] 
		[RED("buildSKU")] 
		public CString BuildSKU
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(39)] 
		[RED("buildPatch")] 
		public CString BuildPatch
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(40)] 
		[RED("difficulty")] 
		public CEnum<gameDifficulty> Difficulty
		{
			get => GetPropertyValue<CEnum<gameDifficulty>>();
			set => SetPropertyValue<CEnum<gameDifficulty>>(value);
		}

		public saveGameMetadata()
		{
			PlayerPosition = new Vector3();
			PlayTime = 0.000000;
			PlaythroughTime = 0.000000;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
