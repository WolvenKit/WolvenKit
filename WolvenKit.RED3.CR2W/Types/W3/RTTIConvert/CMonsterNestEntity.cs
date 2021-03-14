using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CMonsterNestEntity : CInteractiveEntity
	{
		[Ordinal(1)] [RED("bombActivators", 2,0)] 		public CArray<CName> BombActivators { get; set;}

		[Ordinal(2)] [RED("lootOnNestDestroyed")] 		public CHandle<CEntityTemplate> LootOnNestDestroyed { get; set;}

		[Ordinal(3)] [RED("interactionOnly")] 		public CBool InteractionOnly { get; set;}

		[Ordinal(4)] [RED("desiredPlayerToEntityDistance")] 		public CFloat DesiredPlayerToEntityDistance { get; set;}

		[Ordinal(5)] [RED("matchPlayerHeadingWithHeadingOfTheEntity")] 		public CBool MatchPlayerHeadingWithHeadingOfTheEntity { get; set;}

		[Ordinal(6)] [RED("settingExplosivesTime")] 		public CFloat SettingExplosivesTime { get; set;}

		[Ordinal(7)] [RED("shouldPlayFXOnExplosion")] 		public CBool ShouldPlayFXOnExplosion { get; set;}

		[Ordinal(8)] [RED("appearanceChangeDelayAfterExplosion")] 		public CFloat AppearanceChangeDelayAfterExplosion { get; set;}

		[Ordinal(9)] [RED("shouldDealDamageOnExplosion")] 		public CBool ShouldDealDamageOnExplosion { get; set;}

		[Ordinal(10)] [RED("factSetAfterFindingNest")] 		public CString FactSetAfterFindingNest { get; set;}

		[Ordinal(11)] [RED("factSetAfterSuccessfulDestruction")] 		public CString FactSetAfterSuccessfulDestruction { get; set;}

		[Ordinal(12)] [RED("linkingMode")] 		public CBool LinkingMode { get; set;}

		[Ordinal(13)] [RED("linkedEncounterHandle")] 		public EntityHandle LinkedEncounterHandle { get; set;}

		[Ordinal(14)] [RED("linkedEncounterTag")] 		public CName LinkedEncounterTag { get; set;}

		[Ordinal(15)] [RED("setDestructionFactImmediately")] 		public CBool SetDestructionFactImmediately { get; set;}

		[Ordinal(16)] [RED("expOnNestDestroyed")] 		public CInt32 ExpOnNestDestroyed { get; set;}

		[Ordinal(17)] [RED("bonusExpOnBossKilled")] 		public CInt32 BonusExpOnBossKilled { get; set;}

		[Ordinal(18)] [RED("addExpOnlyOnce")] 		public CBool AddExpOnlyOnce { get; set;}

		[Ordinal(19)] [RED("nestUpdateDefintion")] 		public SMonsterNestUpdateDefinition NestUpdateDefintion { get; set;}

		[Ordinal(20)] [RED("monsterNestType")] 		public CEnum<ENestType> MonsterNestType { get; set;}

		[Ordinal(21)] [RED("regionType")] 		public CEnum<EEP2PoiType> RegionType { get; set;}

		[Ordinal(22)] [RED("entityType")] 		public CEnum<EMonsterNestType> EntityType { get; set;}

		[Ordinal(23)] [RED("explodeAfter")] 		public CFloat ExplodeAfter { get; set;}

		[Ordinal(24)] [RED("nestBurnedAfter")] 		public CFloat NestBurnedAfter { get; set;}

		[Ordinal(25)] [RED("playerInventory")] 		public CHandle<CInventoryComponent> PlayerInventory { get; set;}

		[Ordinal(26)] [RED("usedBomb")] 		public SItemUniqueId UsedBomb { get; set;}

		[Ordinal(27)] [RED("encounter")] 		public CHandle<CEncounter> Encounter { get; set;}

		[Ordinal(28)] [RED("nestFound")] 		public CBool NestFound { get; set;}

		[Ordinal(29)] [RED("messageTimestamp")] 		public CFloat MessageTimestamp { get; set;}

		[Ordinal(30)] [RED("bossKilled")] 		public CBool BossKilled { get; set;}

		[Ordinal(31)] [RED("container")] 		public CHandle<W3Container> Container { get; set;}

		[Ordinal(32)] [RED("bossKilledCounter")] 		public CInt32 BossKilledCounter { get; set;}

		[Ordinal(33)] [RED("expWasAdded")] 		public CBool ExpWasAdded { get; set;}

		[Ordinal(34)] [RED("bombEntity")] 		public CHandle<CEntity> BombEntity { get; set;}

		[Ordinal(35)] [RED("bombEntityTemplate")] 		public CHandle<CEntityTemplate> BombEntityTemplate { get; set;}

		[Ordinal(36)] [RED("bombName")] 		public CName BombName { get; set;}

		[Ordinal(37)] [RED("actionBlockingExceptions", 2,0)] 		public CArray<CEnum<EInputActionBlock>> ActionBlockingExceptions { get; set;}

		[Ordinal(38)] [RED("saveLockIdx")] 		public CInt32 SaveLockIdx { get; set;}

		[Ordinal(39)] [RED("voicesetTime")] 		public CFloat VoicesetTime { get; set;}

		[Ordinal(40)] [RED("voicesetPlayed")] 		public CBool VoicesetPlayed { get; set;}

		[Ordinal(41)] [RED("canPlayVset")] 		public CBool CanPlayVset { get; set;}

		[Ordinal(42)] [RED("l_enginetime")] 		public CFloat L_enginetime { get; set;}

		[Ordinal(43)] [RED("airDmg")] 		public CBool AirDmg { get; set;}

		[Ordinal(44)] [RED("interactionComponent")] 		public CHandle<CInteractionComponent> InteractionComponent { get; set;}

		[Ordinal(45)] [RED("wasExploded")] 		public CBool WasExploded { get; set;}

		public CMonsterNestEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CMonsterNestEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}