using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSummonCreaturesDef : CBTTaskPlayAnimationEventDecoratorDef
	{
		[RED("dontResummonUntilMinionsAreDead")] 		public CBool DontResummonUntilMinionsAreDead { get; set;}

		[RED("preventActivationUntilMinionsAreDead")] 		public CBool PreventActivationUntilMinionsAreDead { get; set;}

		[RED("teleportOutsidePlayerFOV")] 		public CBool TeleportOutsidePlayerFOV { get; set;}

		[RED("killSummonedCreaturesOnSummonerDeath")] 		public CBool KillSummonedCreaturesOnSummonerDeath { get; set;}

		[RED("spawnOnAnimEventName")] 		public CName SpawnOnAnimEventName { get; set;}

		[RED("entityToSummonName")] 		public CName EntityToSummonName { get; set;}

		[RED("raiseEventOnSummon")] 		public CName RaiseEventOnSummon { get; set;}

		[RED("overrideAttitude")] 		public CBool OverrideAttitude { get; set;}

		[RED("attitudeToPlayer")] 		public CEnum<EAIAttitude> AttitudeToPlayer { get; set;}

		[RED("count")] 		public CInt32 Count { get; set;}

		[RED("minDistance")] 		public CFloat MinDistance { get; set;}

		[RED("maxDistance")] 		public CFloat MaxDistance { get; set;}

		[RED("spawnAnimation")] 		public CEnum<EExplorationMode> SpawnAnimation { get; set;}

		[RED("forcedSpawnAnim")] 		public CInt32 ForcedSpawnAnim { get; set;}

		[RED("spawnTag")] 		public CName SpawnTag { get; set;}

		[RED("targetShouldBeAccessible")] 		public CBool TargetShouldBeAccessible { get; set;}

		[RED("spawnerShouldBeAccessible")] 		public CBool SpawnerShouldBeAccessible { get; set;}

		[RED("spawnConditionsCheckInterval")] 		public CFloat SpawnConditionsCheckInterval { get; set;}

		[RED("spawnConditionsChecksNumber")] 		public CInt32 SpawnConditionsChecksNumber { get; set;}

		public CBTTaskSummonCreaturesDef(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBTTaskSummonCreaturesDef(cr2w);

	}
}