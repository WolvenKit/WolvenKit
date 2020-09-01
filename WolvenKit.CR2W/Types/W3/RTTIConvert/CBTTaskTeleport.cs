using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTeleport : TaskTeleportAction
	{
		[Ordinal(0)] [RED("("vanish")] 		public CBool Vanish { get; set;}

		[Ordinal(0)] [RED("("forceInvisible")] 		public CBool ForceInvisible { get; set;}

		[Ordinal(0)] [RED("("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(0)] [RED("("slideInsteadOfTeleport")] 		public CBool SlideInsteadOfTeleport { get; set;}

		[Ordinal(0)] [RED("("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(0)] [RED("("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[Ordinal(0)] [RED("("delayActivation")] 		public CFloat DelayActivation { get; set;}

		[Ordinal(0)] [RED("("delayReappearance")] 		public CFloat DelayReappearance { get; set;}

		[Ordinal(0)] [RED("("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(0)] [RED("("disableInvisibilityAfterReappearance")] 		public CBool DisableInvisibilityAfterReappearance { get; set;}

		[Ordinal(0)] [RED("("disableImmortalityAfterReappearance")] 		public CBool DisableImmortalityAfterReappearance { get; set;}

		[Ordinal(0)] [RED("("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(0)] [RED("("appearFXName")] 		public CName AppearFXName { get; set;}

		[Ordinal(0)] [RED("("stopEffectAppearFXName")] 		public CBool StopEffectAppearFXName { get; set;}

		[Ordinal(0)] [RED("("additionalAppearFXName")] 		public CName AdditionalAppearFXName { get; set;}

		[Ordinal(0)] [RED("("performPosCheckOnTeleportEventName")] 		public CBool PerformPosCheckOnTeleportEventName { get; set;}

		[Ordinal(0)] [RED("("performLastMomentPosCheck")] 		public CBool PerformLastMomentPosCheck { get; set;}

		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("activationEventName")] 		public CName ActivationEventName { get; set;}

		[Ordinal(0)] [RED("("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(0)] [RED("("raiseEventImmediately")] 		public CBool RaiseEventImmediately { get; set;}

		[Ordinal(0)] [RED("("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(0)] [RED("("appearRaiseEventName")] 		public CName AppearRaiseEventName { get; set;}

		[Ordinal(0)] [RED("("enableCollisionAfterReappearance")] 		public CBool EnableCollisionAfterReappearance { get; set;}

		[Ordinal(0)] [RED("("enableCollisionsOnDeactivate")] 		public CBool EnableCollisionsOnDeactivate { get; set;}

		[Ordinal(0)] [RED("("appearFXPlayed")] 		public CBool AppearFXPlayed { get; set;}

		[Ordinal(0)] [RED("("shouldPlayHitAnim")] 		public CBool ShouldPlayHitAnim { get; set;}

		[Ordinal(0)] [RED("("sendRotationEventAboveTeleportDist")] 		public CFloat SendRotationEventAboveTeleportDist { get; set;}

		[Ordinal(0)] [RED("("appearRaiseEventNameOnFailure")] 		public CName AppearRaiseEventNameOnFailure { get; set;}

		[Ordinal(0)] [RED("("setBehVarNameOnRaiseEvent")] 		public CName SetBehVarNameOnRaiseEvent { get; set;}

		[Ordinal(0)] [RED("("setBehVarValueOnRaiseDisappearEvent")] 		public CFloat SetBehVarValueOnRaiseDisappearEvent { get; set;}

		[Ordinal(0)] [RED("("setBehVarValueOnRaiseAppearEvent")] 		public CFloat SetBehVarValueOnRaiseAppearEvent { get; set;}

		[Ordinal(0)] [RED("("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[Ordinal(0)] [RED("("heading")] 		public Vector Heading { get; set;}

		[Ordinal(0)] [RED("("randVec")] 		public Vector RandVec { get; set;}

		[Ordinal(0)] [RED("("playerPos")] 		public Vector PlayerPos { get; set;}

		[Ordinal(0)] [RED("("whereTo")] 		public Vector WhereTo { get; set;}

		[Ordinal(0)] [RED("("canBeStrafed")] 		public CBool CanBeStrafed { get; set;}

		[Ordinal(0)] [RED("("appearRaiseEventLaunched")] 		public CBool AppearRaiseEventLaunched { get; set;}

		[Ordinal(0)] [RED("("disappearRaiseEventLaunched")] 		public CBool DisappearRaiseEventLaunched { get; set;}

		[Ordinal(0)] [RED("("newPosition")] 		public Vector NewPosition { get; set;}

		[Ordinal(0)] [RED("("rotated")] 		public CBool Rotated { get; set;}

		public CBTTaskTeleport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTeleport(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}