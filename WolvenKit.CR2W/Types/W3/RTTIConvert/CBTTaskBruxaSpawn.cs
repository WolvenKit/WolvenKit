using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskBruxaSpawn : IBehTreeTask
	{
		[Ordinal(0)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(0)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(0)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(0)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(0)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(0)] [RED("validateSpawnPosition")] 		public CBool ValidateSpawnPosition { get; set;}

		[Ordinal(0)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("fxNameOnSpawnEntity")] 		public CName FxNameOnSpawnEntity { get; set;}

		[Ordinal(0)] [RED("fxNameOnSpawnOwner")] 		public CName FxNameOnSpawnOwner { get; set;}

		[Ordinal(0)] [RED("fxNameAfterSpawnOwner")] 		public CName FxNameAfterSpawnOwner { get; set;}

		[Ordinal(0)] [RED("fxNameAfterSpawnDelay")] 		public CFloat FxNameAfterSpawnDelay { get; set;}

		[Ordinal(0)] [RED("connectFxAfterSpawnWithEntity")] 		public CBool ConnectFxAfterSpawnWithEntity { get; set;}

		[Ordinal(0)] [RED("bruxaEntityTag")] 		public CName BruxaEntityTag { get; set;}

		[Ordinal(0)] [RED("inheritTagsFromOwner")] 		public CBool InheritTagsFromOwner { get; set;}

		[Ordinal(0)] [RED("setBehVarOnSpawn")] 		public CName SetBehVarOnSpawn { get; set;}

		[Ordinal(0)] [RED("setBehVarValue")] 		public CFloat SetBehVarValue { get; set;}

		[Ordinal(0)] [RED("setAppearanceOnSpawn")] 		public CName SetAppearanceOnSpawn { get; set;}

		[Ordinal(0)] [RED("setEntityAsActionTarget")] 		public CBool SetEntityAsActionTarget { get; set;}

		[Ordinal(0)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(0)] [RED("disableVisibility")] 		public CBool DisableVisibility { get; set;}

		[Ordinal(0)] [RED("disableCollisionOnSpawn")] 		public CBool DisableCollisionOnSpawn { get; set;}

		[Ordinal(0)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(0)] [RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[Ordinal(0)] [RED("teleportInterval")] 		public CFloat TeleportInterval { get; set;}

		[Ordinal(0)] [RED("minTeleportDistFromTarget")] 		public CFloat MinTeleportDistFromTarget { get; set;}

		[Ordinal(0)] [RED("maxTeleportDistFromTarget")] 		public CFloat MaxTeleportDistFromTarget { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(0)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(0)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(0)] [RED("eventReceived")] 		public CBool EventReceived { get; set;}

		public CBTTaskBruxaSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBruxaSpawn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}