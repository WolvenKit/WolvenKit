using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnFXEntity : IBehTreeTask
	{
		[RED("attachToActor")] 		public CBool AttachToActor { get; set;}

		[RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[RED("useOnlyOneFXEntity")] 		public CBool UseOnlyOneFXEntity { get; set;}

		[RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[RED("receiveRotationFromGameplayEvent")] 		public CBool ReceiveRotationFromGameplayEvent { get; set;}

		[RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[RED("capRotationFromOwnerToTarget")] 		public CFloat CapRotationFromOwnerToTarget { get; set;}

		[RED("zeroPitchAndRoll")] 		public CBool ZeroPitchAndRoll { get; set;}

		[RED("attachToSlotName")] 		public CName AttachToSlotName { get; set;}

		[RED("teleportToComponentName")] 		public CName TeleportToComponentName { get; set;}

		[RED("toComponentOnWeapon")] 		public CBool ToComponentOnWeapon { get; set;}

		[RED("teleportToBoneName")] 		public CName TeleportToBoneName { get; set;}

		[RED("continuousTeleport")] 		public CBool ContinuousTeleport { get; set;}

		[RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[RED("resourceName")] 		public CName ResourceName { get; set;}

		[RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[RED("delayEntitySpawn")] 		public CFloat DelayEntitySpawn { get; set;}

		[RED("fxNameOnSpawn")] 		public CName FxNameOnSpawn { get; set;}

		[RED("continuousPlayEffectInInterval")] 		public CFloat ContinuousPlayEffectInInterval { get; set;}

		[RED("fxEntityTag")] 		public CName FxEntityTag { get; set;}

		[RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[RED("destroyEntityOnDeact")] 		public CBool DestroyEntityOnDeact { get; set;}

		[RED("stopAllEffectsOnDeact")] 		public CBool StopAllEffectsOnDeact { get; set;}

		[RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[RED("zToleranceFromActorRoot")] 		public CFloat ZToleranceFromActorRoot { get; set;}

		[RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[RED("additionalRotation")] 		public EulerAngles AdditionalRotation { get; set;}

		[RED("attachedTo")] 		public CHandle<CEntity> AttachedTo { get; set;}

		[RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[RED("fxRotation")] 		public CFloat FxRotation { get; set;}

		[RED("spawned")] 		public CBool Spawned { get; set;}

		[RED("eventReceived")] 		public CBool EventReceived { get; set;}

		[RED("receivedRotationEvent")] 		public CBool ReceivedRotationEvent { get; set;}

		[RED("stopped")] 		public CBool Stopped { get; set;}

		[RED("boneIdx")] 		public CInt32 BoneIdx { get; set;}

		public CBTTaskSpawnFXEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnFXEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}