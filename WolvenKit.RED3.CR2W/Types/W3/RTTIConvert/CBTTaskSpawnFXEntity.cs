using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnFXEntity : IBehTreeTask
	{
		[Ordinal(1)] [RED("attachToActor")] 		public CBool AttachToActor { get; set;}

		[Ordinal(2)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(3)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(4)] [RED("useOnlyOneFXEntity")] 		public CBool UseOnlyOneFXEntity { get; set;}

		[Ordinal(5)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(6)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(7)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(8)] [RED("receiveRotationFromGameplayEvent")] 		public CBool ReceiveRotationFromGameplayEvent { get; set;}

		[Ordinal(9)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(10)] [RED("capRotationFromOwnerToTarget")] 		public CFloat CapRotationFromOwnerToTarget { get; set;}

		[Ordinal(11)] [RED("zeroPitchAndRoll")] 		public CBool ZeroPitchAndRoll { get; set;}

		[Ordinal(12)] [RED("attachToSlotName")] 		public CName AttachToSlotName { get; set;}

		[Ordinal(13)] [RED("teleportToComponentName")] 		public CName TeleportToComponentName { get; set;}

		[Ordinal(14)] [RED("toComponentOnWeapon")] 		public CBool ToComponentOnWeapon { get; set;}

		[Ordinal(15)] [RED("teleportToBoneName")] 		public CName TeleportToBoneName { get; set;}

		[Ordinal(16)] [RED("continuousTeleport")] 		public CBool ContinuousTeleport { get; set;}

		[Ordinal(17)] [RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[Ordinal(18)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(19)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(20)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(21)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(22)] [RED("delayEntitySpawn")] 		public CFloat DelayEntitySpawn { get; set;}

		[Ordinal(23)] [RED("fxNameOnSpawn")] 		public CName FxNameOnSpawn { get; set;}

		[Ordinal(24)] [RED("continuousPlayEffectInInterval")] 		public CFloat ContinuousPlayEffectInInterval { get; set;}

		[Ordinal(25)] [RED("fxEntityTag")] 		public CName FxEntityTag { get; set;}

		[Ordinal(26)] [RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[Ordinal(27)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(28)] [RED("destroyEntityOnDeact")] 		public CBool DestroyEntityOnDeact { get; set;}

		[Ordinal(29)] [RED("stopAllEffectsOnDeact")] 		public CBool StopAllEffectsOnDeact { get; set;}

		[Ordinal(30)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(31)] [RED("zToleranceFromActorRoot")] 		public CFloat ZToleranceFromActorRoot { get; set;}

		[Ordinal(32)] [RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[Ordinal(33)] [RED("additionalRotation")] 		public EulerAngles AdditionalRotation { get; set;}

		[Ordinal(34)] [RED("attachedTo")] 		public CHandle<CEntity> AttachedTo { get; set;}

		[Ordinal(35)] [RED("entity")] 		public CHandle<CEntity> Entity { get; set;}

		[Ordinal(36)] [RED("entityTemplate")] 		public CHandle<CEntityTemplate> EntityTemplate { get; set;}

		[Ordinal(37)] [RED("timeStamp")] 		public CFloat TimeStamp { get; set;}

		[Ordinal(38)] [RED("fxRotation")] 		public CFloat FxRotation { get; set;}

		[Ordinal(39)] [RED("spawned")] 		public CBool Spawned { get; set;}

		[Ordinal(40)] [RED("eventReceived")] 		public CBool EventReceived { get; set;}

		[Ordinal(41)] [RED("receivedRotationEvent")] 		public CBool ReceivedRotationEvent { get; set;}

		[Ordinal(42)] [RED("stopped")] 		public CBool Stopped { get; set;}

		[Ordinal(43)] [RED("boneIdx")] 		public CInt32 BoneIdx { get; set;}

		public CBTTaskSpawnFXEntity(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnFXEntity(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}