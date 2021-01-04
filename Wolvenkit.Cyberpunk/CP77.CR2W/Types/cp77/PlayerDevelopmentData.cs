using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PlayerDevelopmentData : IScriptable
	{
		[Ordinal(0)]  [RED("attributes")] public CArray<SAttribute> Attributes { get; set; }
		[Ordinal(1)]  [RED("devPoints")] public CArray<SDevelopmentPoints> DevPoints { get; set; }
		[Ordinal(2)]  [RED("displayActivityLog")] public CBool DisplayActivityLog { get; set; }
		[Ordinal(3)]  [RED("highestCompletedMinigameLevel")] public CInt32 HighestCompletedMinigameLevel { get; set; }
		[Ordinal(4)]  [RED("knownRecipes")] public CArray<ItemRecipe> KnownRecipes { get; set; }
		[Ordinal(5)]  [RED("lifePath")] public CEnum<gamedataLifePath> LifePath { get; set; }
		[Ordinal(6)]  [RED("owner")] public wCHandle<gameObject> Owner { get; set; }
		[Ordinal(7)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(8)]  [RED("perkAreas")] public CArray<SPerkArea> PerkAreas { get; set; }
		[Ordinal(9)]  [RED("proficiencies")] public CArray<SProficiency> Proficiencies { get; set; }
		[Ordinal(10)]  [RED("queuedCombatExp")] public CArray<SExperiencePoints> QueuedCombatExp { get; set; }
		[Ordinal(11)]  [RED("skillPrereqs")] public CArray<CHandle<SkillCheckPrereqState>> SkillPrereqs { get; set; }
		[Ordinal(12)]  [RED("startingExperience")] public CInt32 StartingExperience { get; set; }
		[Ordinal(13)]  [RED("startingLevel")] public CInt32 StartingLevel { get; set; }
		[Ordinal(14)]  [RED("statPrereqs")] public CArray<CHandle<StatCheckPrereqState>> StatPrereqs { get; set; }
		[Ordinal(15)]  [RED("traits")] public CArray<STrait> Traits { get; set; }

		public PlayerDevelopmentData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
