using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSpawnFXEntityDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("resourceName")] 		public CName ResourceName { get; set;}

		[Ordinal(2)] [RED("attachToActor")] 		public CBool AttachToActor { get; set;}

		[Ordinal(3)] [RED("useNodeWithTag")] 		public CBool UseNodeWithTag { get; set;}

		[Ordinal(4)] [RED("useOnlyOneFXEntity")] 		public CBool UseOnlyOneFXEntity { get; set;}

		[Ordinal(5)] [RED("referenceNodeTag")] 		public CName ReferenceNodeTag { get; set;}

		[Ordinal(6)] [RED("useTargetInsteadOfOwner")] 		public CBool UseTargetInsteadOfOwner { get; set;}

		[Ordinal(7)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(8)] [RED("attachToSlotName")] 		public CName AttachToSlotName { get; set;}

		[Ordinal(9)] [RED("teleportToBoneName")] 		public CName TeleportToBoneName { get; set;}

		[Ordinal(10)] [RED("teleportToComponentName")] 		public CName TeleportToComponentName { get; set;}

		[Ordinal(11)] [RED("toComponentOnWeapon")] 		public CBool ToComponentOnWeapon { get; set;}

		[Ordinal(12)] [RED("snapToGround")] 		public CBool SnapToGround { get; set;}

		[Ordinal(13)] [RED("continuousTeleport")] 		public CBool ContinuousTeleport { get; set;}

		[Ordinal(14)] [RED("spawnAfter")] 		public CFloat SpawnAfter { get; set;}

		[Ordinal(15)] [RED("spawnOnAnimEvent")] 		public CName SpawnOnAnimEvent { get; set;}

		[Ordinal(16)] [RED("spawnOnGameplayEvent")] 		public CName SpawnOnGameplayEvent { get; set;}

		[Ordinal(17)] [RED("delayEntitySpawn")] 		public CFloat DelayEntitySpawn { get; set;}

		[Ordinal(18)] [RED("fxNameOnSpawn")] 		public CName FxNameOnSpawn { get; set;}

		[Ordinal(19)] [RED("continuousPlayEffectInInterval")] 		public CFloat ContinuousPlayEffectInInterval { get; set;}

		[Ordinal(20)] [RED("fxEntityTag")] 		public CName FxEntityTag { get; set;}

		[Ordinal(21)] [RED("destroyEntityAfter")] 		public CFloat DestroyEntityAfter { get; set;}

		[Ordinal(22)] [RED("destroyEntityOnAnimEvent")] 		public CName DestroyEntityOnAnimEvent { get; set;}

		[Ordinal(23)] [RED("destroyEntityOnDeact")] 		public CBool DestroyEntityOnDeact { get; set;}

		[Ordinal(24)] [RED("stopAllEffectsOnDeact")] 		public CBool StopAllEffectsOnDeact { get; set;}

		[Ordinal(25)] [RED("stopAllEffectsAfter")] 		public CFloat StopAllEffectsAfter { get; set;}

		[Ordinal(26)] [RED("zToleranceFromActorRoot")] 		public CFloat ZToleranceFromActorRoot { get; set;}

		[Ordinal(27)] [RED("offsetVector")] 		public Vector OffsetVector { get; set;}

		[Ordinal(28)] [RED("additionalRotation")] 		public EulerAngles AdditionalRotation { get; set;}

		[Ordinal(29)] [RED("baseOffsetOnCasterRotation")] 		public CBool BaseOffsetOnCasterRotation { get; set;}

		[Ordinal(30)] [RED("rotateEntityToTarget")] 		public CBool RotateEntityToTarget { get; set;}

		[Ordinal(31)] [RED("capRotationFromOwnerToTarget")] 		public CFloat CapRotationFromOwnerToTarget { get; set;}

		[Ordinal(32)] [RED("receiveRotationFromGameplayEvent")] 		public CBool ReceiveRotationFromGameplayEvent { get; set;}

		[Ordinal(33)] [RED("zeroPitchAndRoll")] 		public CBool ZeroPitchAndRoll { get; set;}

		public CBTTaskSpawnFXEntityDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSpawnFXEntityDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}