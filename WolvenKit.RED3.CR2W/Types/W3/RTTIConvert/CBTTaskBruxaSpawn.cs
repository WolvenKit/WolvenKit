using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBruxaSpawn : IBehTreeTask
	{
		[Ordinal(1)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(2)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(3)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(4)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(5)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(6)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(7)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(8)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(9)] [RED("validateSpawnPosition")] 		public CBool ValidateSpawnPosition { get; set;}

		[Ordinal(10)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(11)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(12)] [RED("fxNameOnSpawnEntity")] 		public CName FxNameOnSpawnEntity { get; set;}

		[Ordinal(13)] [RED("fxNameOnSpawnOwner")] 		public CName FxNameOnSpawnOwner { get; set;}

		[Ordinal(14)] [RED("fxNameAfterSpawnOwner")] 		public CName FxNameAfterSpawnOwner { get; set;}

		[Ordinal(15)] [RED("fxNameAfterSpawnDelay")] 		public CFloat FxNameAfterSpawnDelay { get; set;}

		[Ordinal(16)] [RED("connectFxAfterSpawnWithEntity")] 		public CBool ConnectFxAfterSpawnWithEntity { get; set;}

		[Ordinal(17)] [RED("bruxaEntityTag")] 		public CName BruxaEntityTag { get; set;}

		[Ordinal(18)] [RED("inheritTagsFromOwner")] 		public CBool InheritTagsFromOwner { get; set;}

		[Ordinal(19)] [RED("setBehVarOnSpawn")] 		public CName SetBehVarOnSpawn { get; set;}

		[Ordinal(20)] [RED("setBehVarValue")] 		public CFloat SetBehVarValue { get; set;}

		[Ordinal(21)] [RED("setAppearanceOnSpawn")] 		public CName SetAppearanceOnSpawn { get; set;}

		[Ordinal(22)] [RED("setEntityAsActionTarget")] 		public CBool SetEntityAsActionTarget { get; set;}

		[Ordinal(23)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(24)] [RED("disableVisibility")] 		public CBool DisableVisibility { get; set;}

		[Ordinal(25)] [RED("disableCollisionOnSpawn")] 		public CBool DisableCollisionOnSpawn { get; set;}

		[Ordinal(26)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(27)] [RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(28)] [RED("teleportInterval")] 		public CFloat TeleportInterval { get; set;}

		[Ordinal(29)] [RED("minTeleportDistFromTarget")] 		public CFloat MinTeleportDistFromTarget { get; set;}

		[Ordinal(30)] [RED("maxTeleportDistFromTarget")] 		public CFloat MaxTeleportDistFromTarget { get; set;}

		[Ordinal(31)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(32)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(33)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(34)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(35)] [RED("eventReceived")] 		public CBool EventReceived { get; set;}

		public CBTTaskBruxaSpawn(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}