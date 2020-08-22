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

		[RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[RED("nestBurnedAfter")] 		public CFloat NestBurnedAfter { get; set;}

		[RED("playerInventory")] 		public CHandle<CInventoryComponent> PlayerInventory { get; set;}

		[RED("usedBomb")] 		public SItemUniqueId UsedBomb { get; set;}

		[RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[RED("nestFound")] 		public CBool NestFound { get; set;}

		[RED("messageTimestamp")] 		public CFloat MessageTimestamp { get; set;}

		[RED("bossKilled")] 		public CBool BossKilled { get; set;}

		[RED("container")] 		public CHandle<W3Container> Container { get; set;}

		[RED("bossKilledCounter")] 		public CInt32 BossKilledCounter { get; set;}

		[RED("expWasAdded")] 		public CBool ExpWasAdded { get; set;}

		[RED("bombEntity")] 		public CHandle<CEntity> BombEntity { get; set;}

		[RED("bombEntityTemplate")] 		public CHandle<CEntityTemplate> BombEntityTemplate { get; set;}

		[RED("bombName")] 		public CName BombName { get; set;}

		[RED("actionBlockingExceptions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> ActionBlockingExceptions { get; set;}

		[RED("saveLockIdx")] 		public CInt32 SaveLockIdx { get; set;}

		[RED("voicesetTime")] 		public CFloat VoicesetTime { get; set;}

		[RED("voicesetPlayed")] 		public CBool VoicesetPlayed { get; set;}

		[RED("canPlayVset")] 		public CBool CanPlayVset { get; set;}

		[RED("l_enginetime")] 		public CFloat L_enginetime { get; set;}

		[RED("airDmg")] 		public CBool AirDmg { get; set;}

		[RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[RED("wasExploded")] 		public CBool WasExploded { get; set;}

		public CMonsterNestEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMonsterNestEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}