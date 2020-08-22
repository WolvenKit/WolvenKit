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
		[RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[RED("validateSpawnPosition")] 		public CBool ValidateSpawnPosition { get; set;}

		[RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[RED("fxNameOnSpawnEntity")] 		public CName FxNameOnSpawnEntity { get; set;}

		[RED("fxNameOnSpawnOwner")] 		public CName FxNameOnSpawnOwner { get; set;}

		[RED("fxNameAfterSpawnOwner")] 		public CName FxNameAfterSpawnOwner { get; set;}

		[RED("fxNameAfterSpawnDelay")] 		public CFloat FxNameAfterSpawnDelay { get; set;}

		[RED("connectFxAfterSpawnWithEntity")] 		public CBool ConnectFxAfterSpawnWithEntity { get; set;}

		[RED("bruxaEntityTag")] 		public CName BruxaEntityTag { get; set;}

		[RED("inheritTagsFromOwner")] 		public CBool InheritTagsFromOwner { get; set;}

		[RED("setBehVarOnSpawn")] 		public CName SetBehVarOnSpawn { get; set;}

		[RED("setBehVarValue")] 		public CFloat SetBehVarValue { get; set;}

		[RED("setAppearanceOnSpawn")] 		public CName SetAppearanceOnSpawn { get; set;}

		[RED("setEntityAsActionTarget")] 		public CBool SetEntityAsActionTarget { get; set;}

		[RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[RED("disableVisibility")] 		public CBool DisableVisibility { get; set;}

		[RED("disableCollisionOnSpawn")] 		public CBool DisableCollisionOnSpawn { get; set;}

		[RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[RED("activeDuration")] 		public CFloat ActiveDuration { get; set;}

		[RED("teleportInterval")] 		public CFloat TeleportInterval { get; set;}

		[RED("minTeleportDistFromTarget")] 		public CFloat MinTeleportDistFromTarget { get; set;}

		[RED("maxTeleportDistFromTarget")] 		public CFloat MaxTeleportDistFromTarget { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[RED("spawned")] 		public CBool Spawned { get; set;}

		[RED("eventReceived")] 		public CBool EventReceived { get; set;}

		public CBTTaskBruxaSpawn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskBruxaSpawn(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}