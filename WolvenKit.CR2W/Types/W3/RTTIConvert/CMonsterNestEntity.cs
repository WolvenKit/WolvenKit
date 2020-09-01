using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMonsterNestEntity : CInteractiveEntity
	{
		[Ordinal(0)] [RED("bombActivators", 2,0)] 		public CArray<CName> BombActivators { get; set;}

		[Ordinal(0)] [RED("lootOnNestDestroyed")] 		public CHandle<CEntityTemplate> LootOnNestDestroyed { get; set;}

		[Ordinal(0)] [RED("interactionOnly")] 		public CBool InteractionOnly { get; set;}

		[Ordinal(0)] [RED("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[Ordinal(0)] [RED("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[Ordinal(0)] [RED("settingExplosivesTime")] 		public CFloat SettingExplosivesTime { get; set;}

		[Ordinal(0)] [RED("shouldPlayFXOnExplosion")] 		public CBool ShouldPlayFXOnExplosion { get; set;}

		[Ordinal(0)] [RED("appearanceChangeDelayAfterExplosion")] 		public CFloat AppearanceChangeDelayAfterExplosion { get; set;}

		[Ordinal(0)] [RED("shouldDealDamageOnExplosion")] 		public CBool ShouldDealDamageOnExplosion { get; set;}

		[Ordinal(0)] [RED("factSetAfterFindingNest")] 		public CString FactSetAfterFindingNest { get; set;}

		[Ordinal(0)] [RED("factSetAfterSuccessfulDestruction")] 		public CString FactSetAfterSuccessfulDestruction { get; set;}

		[Ordinal(0)] [RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[Ordinal(0)] [RED("linkedEncounterHandle")] 		public EntityHandle LinkedEncounterHandle { get; set;}

		[Ordinal(0)] [RED("linkedEncounterTag")] 		public CName LinkedEncounterTag { get; set;}

		[Ordinal(0)] [RED("setDestructionFactImmediately")] 		public CBool SetDestructionFactImmediately { get; set;}

		[Ordinal(0)] [RED("expOnNestDestroyed")] 		public CInt32 ExpOnNestDestroyed { get; set;}

		[Ordinal(0)] [RED("bonusExpOnBossKilled")] 		public CInt32 BonusExpOnBossKilled { get; set;}

		[Ordinal(0)] [RED("addExpOnlyOnce")] 		public CBool AddExpOnlyOnce { get; set;}

		[Ordinal(0)] [RED("nestUpdateDefintion")] 		public SMonsterNestUpdateDefinition NestUpdateDefintion { get; set;}

		[Ordinal(0)] [RED("monsterNestType")] 		public CEnum<ENestType> MonsterNestType { get; set;}

		[Ordinal(0)] [RED("regionType")] 		public CEnum<EEP2PoiType> RegionType { get; set;}

		[Ordinal(0)] [RED("entityType")] 		public CEnum<EMonsterNestType> EntityType { get; set;}

		[Ordinal(0)] [RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[Ordinal(0)] [RED("nestBurnedAfter")] 		public CFloat NestBurnedAfter { get; set;}

		[Ordinal(0)] [RED("playerInventory")] 		public CHandle<CInventoryComponent> PlayerInventory { get; set;}

		[Ordinal(0)] [RED("usedBomb")] 		public SItemUniqueId UsedBomb { get; set;}

		[Ordinal(0)] [RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[Ordinal(0)] [RED("nestFound")] 		public CBool NestFound { get; set;}

		[Ordinal(0)] [RED("messageTimestamp")] 		public CFloat MessageTimestamp { get; set;}

		[Ordinal(0)] [RED("bossKilled")] 		public CBool BossKilled { get; set;}

		[Ordinal(0)] [RED("container")] 		public CHandle<W3Container> Container { get; set;}

		[Ordinal(0)] [RED("bossKilledCounter")] 		public CInt32 BossKilledCounter { get; set;}

		[Ordinal(0)] [RED("expWasAdded")] 		public CBool ExpWasAdded { get; set;}

		[Ordinal(0)] [RED("bombEntity")] 		public CHandle<CEntity> BombEntity { get; set;}

		[Ordinal(0)] [RED("bombEntityTemplate")] 		public CHandle<CEntityTemplate> BombEntityTemplate { get; set;}

		[Ordinal(0)] [RED("bombName")] 		public CName BombName { get; set;}

		[Ordinal(0)] [RED("actionBlockingExceptions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> ActionBlockingExceptions { get; set;}

		[Ordinal(0)] [RED("saveLockIdx")] 		public CInt32 SaveLockIdx { get; set;}

		[Ordinal(0)] [RED("voicesetTime")] 		public CFloat VoicesetTime { get; set;}

		[Ordinal(0)] [RED("voicesetPlayed")] 		public CBool VoicesetPlayed { get; set;}

		[Ordinal(0)] [RED("canPlayVset")] 		public CBool CanPlayVset { get; set;}

		[Ordinal(0)] [RED("l_enginetime")] 		public CFloat L_enginetime { get; set;}

		[Ordinal(0)] [RED("airDmg")] 		public CBool AirDmg { get; set;}

		[Ordinal(0)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(0)] [RED("wasExploded")] 		public CBool WasExploded { get; set;}

		public CMonsterNestEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMonsterNestEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}