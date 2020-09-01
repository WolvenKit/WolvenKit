using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSummonCreaturesDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[Ordinal(1)] [RED("dontResummonUntilMinionsAreDead")] 		public CBool DontResummonUntilMinionsAreDead { get; set;}

		[Ordinal(2)] [RED("preventActivationUntilMinionsAreDead")] 		public CBool PreventActivationUntilMinionsAreDead { get; set;}

		[Ordinal(3)] [RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[Ordinal(4)] [RED("killSummonedCreaturesOnSummonerDeath")] 		public CBool KillSummonedCreaturesOnSummonerDeath { get; set;}

		[Ordinal(5)] [RED("spawnOnAnimEventName")] 		public CName SpawnOnAnimEventName { get; set;}

		[Ordinal(6)] [RED("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[Ordinal(7)] [RED("raiseEventOnSummon")] 		public CName RaiseEventOnSummon { get; set;}

		[Ordinal(8)] [RED("overrideAttitude")] 		public CBool OverrideAttitude { get; set;}

		[Ordinal(9)] [RED("attitudeToPlayer")] 		public CEnum<EAIAttitude> AttitudeToPlayer { get; set;}

		[Ordinal(10)] [RED("count")] 		public CInt32 Count { get; set;}

		[Ordinal(11)] [RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[Ordinal(12)] [RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[Ordinal(13)] [RED("spawnAnimation")] 		public CEnum<EExplorationMode> SpawnAnimation { get; set;}

		[Ordinal(14)] [RED("forcedSpawnAnim")] 		public CInt32 ForcedSpawnAnim { get; set;}

		[Ordinal(15)] [RED("spawnTag")] 		public CName SpawnTag { get; set;}

		[Ordinal(16)] [RED("targetShouldBeAccessible")] 		public CBool TargetShouldBeAccessible { get; set;}

		[Ordinal(17)] [RED("spawnerShouldBeAccessible")] 		public CBool SpawnerShouldBeAccessible { get; set;}

		[Ordinal(18)] [RED("spawnConditionsCheckInterval")] 		public CFloat SpawnConditionsCheckInterval { get; set;}

		[Ordinal(19)] [RED("spawnConditionsChecksNumber")] 		public CInt32 SpawnConditionsChecksNumber { get; set;}

		public CBTTaskSummonCreaturesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSummonCreaturesDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}