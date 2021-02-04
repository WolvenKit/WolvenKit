using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class saveGameMetadata : CVariable
	{
		[Ordinal(0)]  [RED("debugString")] public CString DebugString { get; set; }
		[Ordinal(1)]  [RED("gameDefinition")] public CString GameDefinition { get; set; }
		[Ordinal(2)]  [RED("activeQuests")] public CString ActiveQuests { get; set; }
		[Ordinal(3)]  [RED("trackedQuestEntry")] public CString TrackedQuestEntry { get; set; }
		[Ordinal(4)]  [RED("trackedQuest")] public CString TrackedQuest { get; set; }
		[Ordinal(5)]  [RED("mainQuest")] public CString MainQuest { get; set; }
		[Ordinal(6)]  [RED("locationName")] public CString LocationName { get; set; }
		[Ordinal(7)]  [RED("playerPosition")] public Vector3 PlayerPosition { get; set; }
		[Ordinal(8)]  [RED("playTime")] public CDouble PlayTime { get; set; }
		[Ordinal(9)]  [RED("playthroughTime")] public CDouble PlaythroughTime { get; set; }
		[Ordinal(10)]  [RED("nextSavableEntityID")] public CUInt32 NextSavableEntityID { get; set; }
		[Ordinal(11)]  [RED("nextNonSavableEntityID")] public CUInt32 NextNonSavableEntityID { get; set; }
		[Ordinal(12)]  [RED("lifePath")] public CEnum<gamedataLifePath> LifePath { get; set; }
		[Ordinal(13)]  [RED("bodyGender")] public CString BodyGender { get; set; }
		[Ordinal(14)]  [RED("brainGender")] public CString BrainGender { get; set; }
		[Ordinal(15)]  [RED("level")] public CFloat Level { get; set; }
		[Ordinal(16)]  [RED("streetCred")] public CFloat StreetCred { get; set; }
		[Ordinal(17)]  [RED("gunslinger")] public CFloat Gunslinger { get; set; }
		[Ordinal(18)]  [RED("assault")] public CFloat Assault { get; set; }
		[Ordinal(19)]  [RED("demolition")] public CFloat Demolition { get; set; }
		[Ordinal(20)]  [RED("athletics")] public CFloat Athletics { get; set; }
		[Ordinal(21)]  [RED("brawling")] public CFloat Brawling { get; set; }
		[Ordinal(22)]  [RED("coldBlood")] public CFloat ColdBlood { get; set; }
		[Ordinal(23)]  [RED("stealth")] public CFloat Stealth { get; set; }
		[Ordinal(24)]  [RED("engineering")] public CFloat Engineering { get; set; }
		[Ordinal(25)]  [RED("crafting")] public CFloat Crafting { get; set; }
		[Ordinal(26)]  [RED("hacking")] public CFloat Hacking { get; set; }
		[Ordinal(27)]  [RED("combatHacking")] public CFloat CombatHacking { get; set; }
		[Ordinal(28)]  [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(29)]  [RED("intelligence")] public CFloat Intelligence { get; set; }
		[Ordinal(30)]  [RED("reflexes")] public CFloat Reflexes { get; set; }
		[Ordinal(31)]  [RED("technicalAbility")] public CFloat TechnicalAbility { get; set; }
		[Ordinal(32)]  [RED("cool")] public CFloat Cool { get; set; }
		[Ordinal(33)]  [RED("initialBuildID")] public CString InitialBuildID { get; set; }
		[Ordinal(34)]  [RED("finishedQuests")] public CString FinishedQuests { get; set; }
		[Ordinal(35)]  [RED("playthroughID")] public CString PlaythroughID { get; set; }
		[Ordinal(36)]  [RED("pointOfNoReturnId")] public CString PointOfNoReturnId { get; set; }
		[Ordinal(37)]  [RED("visitID")] public CString VisitID { get; set; }
		[Ordinal(38)]  [RED("buildSKU")] public CString BuildSKU { get; set; }
		[Ordinal(39)]  [RED("buildPatch")] public CString BuildPatch { get; set; }
		[Ordinal(40)]  [RED("difficulty")] public CEnum<gameDifficulty> Difficulty { get; set; }

		public saveGameMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
