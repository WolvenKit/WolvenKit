using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSummonCreatures : CBTTaskAttack
	{
		[Ordinal(0)] [RED("dontResummonUntilMinionsAreDead")] 		public CBool DontResummonUntilMinionsAreDead { get; set;}

		[Ordinal(0)] [RED("preventActivationUntilMinionsAreDead")] 		public CBool PreventActivationUntilMinionsAreDead { get; set;}

		[Ordinal(0)] [RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(0)] [RED("killSummonedCreaturesOnSummonerDeath")] 		public CBool KillSummonedCreaturesOnSummonerDeath { get; set;}

		[Ordinal(0)] [RED("spawnOnAnimEventName")] 		public CName SpawnOnAnimEventName { get; set;}

		[Ordinal(0)] [RED("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[Ordinal(0)] [RED("raiseEventOnSummon")] 		public CName RaiseEventOnSummon { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("overrideAttitude")] 		public CBool OverrideAttitude { get; set;}

		[Ordinal(0)] [RED("attitudeToPlayer")] 		public CEnum<EAIAttitude> AttitudeToPlayer { get; set;}

		[Ordinal(0)] [RED("count")] 		public CInt32 Count { get; set;}

		[Ordinal(0)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(0)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(0)] [RED("spawnAnimation")] 		public CEnum<EExplorationMode> SpawnAnimation { get; set;}

		[Ordinal(0)] [RED("forcedSpawnAnim")] 		public CInt32 ForcedSpawnAnim { get; set;}

		[Ordinal(0)] [RED("spawnTag")] 		public CName SpawnTag { get; set;}

		[Ordinal(0)] [RED("spawnedNPCs", 2,0)] 		public CArray<CHandle<CNewNPC>> SpawnedNPCs { get; set;}

		[Ordinal(0)] [RED("minions", 2,0)] 		public CArray<CHandle<CGameplayEntity>> Minions { get; set;}

		[Ordinal(0)] [RED("respawnTime", 2,0)] 		public CArray<EngineTime> RespawnTime { get; set;}

		[Ordinal(0)] [RED("respawnNeeded", 2,0)] 		public CArray<CBool> RespawnNeeded { get; set;}

		[Ordinal(0)] [RED("respawnDelay")] 		public CFloat RespawnDelay { get; set;}

		[Ordinal(0)] [RED("targetShouldBeAccessible")] 		public CBool TargetShouldBeAccessible { get; set;}

		[Ordinal(0)] [RED("spawnerShouldBeAccessible")] 		public CBool SpawnerShouldBeAccessible { get; set;}

		[Ordinal(0)] [RED("summonActivated")] 		public CBool SummonActivated { get; set;}

		[Ordinal(0)] [RED("spawnConditionsCheckInterval")] 		public CFloat SpawnConditionsCheckInterval { get; set;}

		[Ordinal(0)] [RED("spawnConditionsChecksNumber")] 		public CInt32 SpawnConditionsChecksNumber { get; set;}

		public CBTTaskSummonCreatures(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSummonCreatures(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}