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
		[Ordinal(0)] [RED("attachToActor")] 		public CBool AttachToActor { get; set;}

		[Ordinal(0)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(0)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(0)] [RED("useOnlyOneFXEntity")] 		public CBool UseOnlyOneFXEntity { get; set;}

		[Ordinal(0)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(0)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(0)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(0)] [RED("receiveRotationFromGameplayEvent")] 		public CBool ReceiveRotationFromGameplayEvent { get; set;}

		[Ordinal(0)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(0)] [RED("capRotationFromOwnerToTarget")] 		public CFloat CapRotationFromOwnerToTarget { get; set;}

		[Ordinal(0)] [RED("zeroPitchAndRoll")] 		public CBool ZeroPitchAndRoll { get; set;}

		[Ordinal(0)] [RED("attachToSlotName")] 		public CName AttachToSlotName { get; set;}

		[Ordinal(0)] [RED("teleportToComponentName")] 		public CName TeleportToComponentName { get; set;}

		[Ordinal(0)] [RED("toComponentOnWeapon")] 		public CBool ToComponentOnWeapon { get; set;}

		[Ordinal(0)] [RED("teleportToBoneName")] 		public CName TeleportToBoneName { get; set;}

		[Ordinal(0)] [RED("continuousTeleport")] 		public CBool ContinuousTeleport { get; set;}

		[Ordinal(0)] [RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[Ordinal(0)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(0)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(0)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(0)] [RED("delayEntitySpawn")] 		public CFloat DelayEntitySpawn { get; set;}

		[Ordinal(0)] [RED("fxNameOnSpawn")] 		public CName FxNameOnSpawn { get; set;}

		[Ordinal(0)] [RED("continuousPlayEffectInInterval")] 		public CFloat ContinuousPlayEffectInInterval { get; set;}

		[Ordinal(0)] [RED("fxEntityTag")] 		public CName FxEntityTag { get; set;}

		[Ordinal(0)] [RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[Ordinal(0)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(0)] [RED("destroyEntityOnDeact")] 		public CBool DestroyEntityOnDeact { get; set;}

		[Ordinal(0)] [RED("stopAllEffectsOnDeact")] 		public CBool StopAllEffectsOnDeact { get; set;}

		[Ordinal(0)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(0)] [RED("zToleranceFromActorRoot")] 		public CFloat ZToleranceFromActorRoot { get; set;}

		[Ordinal(0)] [RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[Ordinal(0)] [RED("additionalRotation")] 		public EulerAngles AdditionalRotation { get; set;}

		[Ordinal(0)] [RED("attachedTo")] 		public CHandle<CEntity> AttachedTo { get; set;}

		[Ordinal(0)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(0)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(0)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(0)] [RED("fxRotation")] 		public CFloat FxRotation { get; set;}

		[Ordinal(0)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(0)] [RED("eventReceived")] 		public CBool EventReceived { get; set;}

		[Ordinal(0)] [RED("receivedRotationEvent")] 		public CBool ReceivedRotationEvent { get; set;}

		[Ordinal(0)] [RED("stopped")] 		public CBool Stopped { get; set;}

		[Ordinal(0)] [RED("boneIdx")] 		public CInt32 BoneIdx { get; set;}

		public CBTTaskSpawnFXEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnFXEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}