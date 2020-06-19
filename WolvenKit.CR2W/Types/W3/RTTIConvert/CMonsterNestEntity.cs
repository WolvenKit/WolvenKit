using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMonsterNestEntity : CInteractiveEntity
	{
		[RED("bombActivators", 2,0)] 		public CArray<CName> BombActivators { get; set;}

		[RED("lootOnNestDestroyed")] 		public CHandle<CEntityTemplate> LootOnNestDestroyed { get; set;}

		[RED("interactionOnly")] 		public CBool InteractionOnly { get; set;}

		[RED("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[RED("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[RED("settingExplosivesTime")] 		public CFloat SettingExplosivesTime { get; set;}

		[RED("shouldPlayFXOnExplosion")] 		public CBool ShouldPlayFXOnExplosion { get; set;}

		[RED("appearanceChangeDelayAfterExplosion")] 		public CFloat AppearanceChangeDelayAfterExplosion { get; set;}

		[RED("shouldDealDamageOnExplosion")] 		public CBool ShouldDealDamageOnExplosion { get; set;}

		[RED("factSetAfterFindingNest")] 		public CString FactSetAfterFindingNest { get; set;}

		[RED("factSetAfterSuccessfulDestruction")] 		public CString FactSetAfterSuccessfulDestruction { get; set;}

		[RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[RED("linkedEncounterHandle")] 		public EntityHandle LinkedEncounterHandle { get; set;}

		[RED("linkedEncounterTag")] 		public CName LinkedEncounterTag { get; set;}

		[RED("setDestructionFactImmediately")] 		public CBool SetDestructionFactImmediately { get; set;}

		[RED("expOnNestDestroyed")] 		public CInt32 ExpOnNestDestroyed { get; set;}

		[RED("bonusExpOnBossKilled")] 		public CInt32 BonusExpOnBossKilled { get; set;}

		[RED("addExpOnlyOnce")] 		public CBool AddExpOnlyOnce { get; set;}

		[RED("nestUpdateDefintion")] 		public SMonsterNestUpdateDefinition NestUpdateDefintion { get; set;}

		[RED("monsterNestType")] 		public CEnum<ENestType> MonsterNestType { get; set;}

		[RED("regionType")] 		public CEnum<EEP2PoiType> RegionType { get; set;}

		[RED("entityType")] 		public CEnum<EMonsterNestType> EntityType { get; set;}

		public CMonsterNestEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMonsterNestEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}