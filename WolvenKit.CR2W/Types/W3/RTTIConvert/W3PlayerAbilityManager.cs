using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class W3PlayerAbilityManager : W3AbilityManager
	{
		[Ordinal(0)] [RED("("skills", 2,0)] 		public CArray<SSkill> Skills { get; set;}

		[Ordinal(0)] [RED("("resistStatsItems", 2,0)] 		public CArray<CArray<SResistanceValue>> ResistStatsItems { get; set;}

		[Ordinal(0)] [RED("("toxicityOffset")] 		public CFloat ToxicityOffset { get; set;}

		[Ordinal(0)] [RED("("pathPointsSpent", 2,0)] 		public CArray<CInt32> PathPointsSpent { get; set;}

		[Ordinal(0)] [RED("("skillSlots", 2,0)] 		public CArray<SSkillSlot> SkillSlots { get; set;}

		[Ordinal(0)] [RED("("skillAbilities", 2,0)] 		public CArray<CName> SkillAbilities { get; set;}

		[Ordinal(0)] [RED("("totalSkillSlotsCount")] 		public CInt32 TotalSkillSlotsCount { get; set;}

		[Ordinal(0)] [RED("("orgTotalSkillSlotsCount")] 		public CInt32 OrgTotalSkillSlotsCount { get; set;}

		[Ordinal(0)] [RED("("tempSkills", 2,0)] 		public CArray<CEnum<ESkill>> TempSkills { get; set;}

		[Ordinal(0)] [RED("("mutagenSlots", 2,0)] 		public CArray<SMutagenSlot> MutagenSlots { get; set;}

		[Ordinal(0)] [RED("("temporaryTutorialSkills", 2,0)] 		public CArray<STutorialTemporarySkill> TemporaryTutorialSkills { get; set;}

		[Ordinal(0)] [RED("("ep1SkillsInitialized")] 		public CBool Ep1SkillsInitialized { get; set;}

		[Ordinal(0)] [RED("("ep2SkillsInitialized")] 		public CBool Ep2SkillsInitialized { get; set;}

		[Ordinal(0)] [RED("("baseGamePerksGUIPosUpdated")] 		public CBool BaseGamePerksGUIPosUpdated { get; set;}

		[Ordinal(0)] [RED("("mutagenBonuses", 2,0)] 		public CArray<SMutagenBonusAlchemy19> MutagenBonuses { get; set;}

		[Ordinal(0)] [RED("("alchemy19OptimizationDone")] 		public CBool Alchemy19OptimizationDone { get; set;}

		[Ordinal(0)] [RED("("isMutationSystemEnabled")] 		public CBool IsMutationSystemEnabled { get; set;}

		[Ordinal(0)] [RED("("equippedMutations", 2,0)] 		public CArray<CEnum<EPlayerMutationType>> EquippedMutations { get; set;}

		[Ordinal(0)] [RED("("mutations", 2,0)] 		public CArray<SMutation> Mutations { get; set;}

		[Ordinal(0)] [RED("("mutationUnlockedSlotsIndexes", 2,0)] 		public CArray<CInt32> MutationUnlockedSlotsIndexes { get; set;}

		[Ordinal(0)] [RED("("mutationSkillSlotsInitialized")] 		public CBool MutationSkillSlotsInitialized { get; set;}

		[Ordinal(0)] [RED("("LINK_BONUS_BLUE")] 		public CName LINK_BONUS_BLUE { get; set;}

		[Ordinal(0)] [RED("("LINK_BONUS_GREEN")] 		public CName LINK_BONUS_GREEN { get; set;}

		[Ordinal(0)] [RED("("LINK_BONUS_RED")] 		public CName LINK_BONUS_RED { get; set;}

		[Ordinal(0)] [RED("("MUTATION_SKILL_GROUP_ID")] 		public CInt32 MUTATION_SKILL_GROUP_ID { get; set;}

		public W3PlayerAbilityManager(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new W3PlayerAbilityManager(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}