using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class saveGameMetadata : CVariable
	{
		[Ordinal(0)]  [RED("activeQuests")] public CString ActiveQuests { get; set; }
		[Ordinal(1)]  [RED("assault")] public CFloat Assault { get; set; }
		[Ordinal(2)]  [RED("athletics")] public CFloat Athletics { get; set; }
		[Ordinal(3)]  [RED("bodyGender")] public CString BodyGender { get; set; }
		[Ordinal(4)]  [RED("brainGender")] public CString BrainGender { get; set; }
		[Ordinal(5)]  [RED("brawling")] public CFloat Brawling { get; set; }
		[Ordinal(6)]  [RED("buildPatch")] public CString BuildPatch { get; set; }
		[Ordinal(7)]  [RED("buildSKU")] public CString BuildSKU { get; set; }
		[Ordinal(8)]  [RED("coldBlood")] public CFloat ColdBlood { get; set; }
		[Ordinal(9)]  [RED("combatHacking")] public CFloat CombatHacking { get; set; }
		[Ordinal(10)]  [RED("cool")] public CFloat Cool { get; set; }
		[Ordinal(11)]  [RED("crafting")] public CFloat Crafting { get; set; }
		[Ordinal(12)]  [RED("debugString")] public CString DebugString { get; set; }
		[Ordinal(13)]  [RED("demolition")] public CFloat Demolition { get; set; }
		[Ordinal(14)]  [RED("difficulty")] public CEnum<gameDifficulty> Difficulty { get; set; }
		[Ordinal(15)]  [RED("engineering")] public CFloat Engineering { get; set; }
		[Ordinal(16)]  [RED("finishedQuests")] public CString FinishedQuests { get; set; }
		[Ordinal(17)]  [RED("gameDefinition")] public CString GameDefinition { get; set; }
		[Ordinal(18)]  [RED("gunslinger")] public CFloat Gunslinger { get; set; }
		[Ordinal(19)]  [RED("hacking")] public CFloat Hacking { get; set; }
		[Ordinal(20)]  [RED("initialBuildID")] public CString InitialBuildID { get; set; }
		[Ordinal(21)]  [RED("intelligence")] public CFloat Intelligence { get; set; }
		[Ordinal(22)]  [RED("level")] public CFloat Level { get; set; }
		[Ordinal(23)]  [RED("lifePath")] public CEnum<gamedataLifePath> LifePath { get; set; }
		[Ordinal(24)]  [RED("locationName")] public CString LocationName { get; set; }
		[Ordinal(25)]  [RED("mainQuest")] public CString MainQuest { get; set; }
		[Ordinal(26)]  [RED("nextNonSavableEntityID")] public CUInt32 NextNonSavableEntityID { get; set; }
		[Ordinal(27)]  [RED("nextSavableEntityID")] public CUInt32 NextSavableEntityID { get; set; }
		[Ordinal(28)]  [RED("playTime")] public CDouble PlayTime { get; set; }
		[Ordinal(29)]  [RED("playerPosition")] public Vector3 PlayerPosition { get; set; }
		[Ordinal(30)]  [RED("playthroughID")] public CString PlaythroughID { get; set; }
		[Ordinal(31)]  [RED("playthroughTime")] public CDouble PlaythroughTime { get; set; }
		[Ordinal(32)]  [RED("pointOfNoReturnId")] public CString PointOfNoReturnId { get; set; }
		[Ordinal(33)]  [RED("reflexes")] public CFloat Reflexes { get; set; }
		[Ordinal(34)]  [RED("stealth")] public CFloat Stealth { get; set; }
		[Ordinal(35)]  [RED("streetCred")] public CFloat StreetCred { get; set; }
		[Ordinal(36)]  [RED("strength")] public CFloat Strength { get; set; }
		[Ordinal(37)]  [RED("technicalAbility")] public CFloat TechnicalAbility { get; set; }
		[Ordinal(38)]  [RED("trackedQuest")] public CString TrackedQuest { get; set; }
		[Ordinal(39)]  [RED("trackedQuestEntry")] public CString TrackedQuestEntry { get; set; }
		[Ordinal(40)]  [RED("visitID")] public CString VisitID { get; set; }

		public saveGameMetadata(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
