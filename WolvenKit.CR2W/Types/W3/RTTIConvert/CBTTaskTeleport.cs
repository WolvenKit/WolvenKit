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
		[RED("vanish")] 		public CBool Vanish { get; set;}

		[RED("forceInvisible")] 		public CBool ForceInvisible { get; set;}

		[RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[RED("slideInsteadOfTeleport")] 		public CBool SlideInsteadOfTeleport { get; set;}

		[RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[RED("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[RED("delayActivation")] 		public CFloat DelayActivation { get; set;}

		[RED("delayReappearance")] 		public CFloat DelayReappearance { get; set;}

		[RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[RED("disableInvisibilityAfterReappearance")] 		public CBool DisableInvisibilityAfterReappearance { get; set;}

		[RED("disableImmortalityAfterReappearance")] 		public CBool DisableImmortalityAfterReappearance { get; set;}

		[RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[RED("appearFXName")] 		public CName AppearFXName { get; set;}

		[RED("stopEffectAppearFXName")] 		public CBool StopEffectAppearFXName { get; set;}

		[RED("additionalAppearFXName")] 		public CName AdditionalAppearFXName { get; set;}

		[RED("performPosCheckOnTeleportEventName")] 		public CBool PerformPosCheckOnTeleportEventName { get; set;}

		[RED("performLastMomentPosCheck")] 		public CBool PerformLastMomentPosCheck { get; set;}

		[RED("activated")] 		public CBool Activated { get; set;}

		[RED("activationEventName")] 		public CName ActivationEventName { get; set;}

		[RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[RED("raiseEventImmediately")] 		public CBool RaiseEventImmediately { get; set;}

		[RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[RED("appearRaiseEventName")] 		public CName AppearRaiseEventName { get; set;}

		[RED("enableCollisionAfterReappearance")] 		public CBool EnableCollisionAfterReappearance { get; set;}

		[RED("enableCollisionsOnDeactivate")] 		public CBool EnableCollisionsOnDeactivate { get; set;}

		[RED("appearFXPlayed")] 		public CBool AppearFXPlayed { get; set;}

		[RED("shouldPlayHitAnim")] 		public CBool ShouldPlayHitAnim { get; set;}

		[RED("sendRotationEventAboveTeleportDist")] 		public CFloat SendRotationEventAboveTeleportDist { get; set;}

		[RED("appearRaiseEventNameOnFailure")] 		public CName AppearRaiseEventNameOnFailure { get; set;}

		[RED("setBehVarNameOnRaiseEvent")] 		public CName SetBehVarNameOnRaiseEvent { get; set;}

		[RED("setBehVarValueOnRaiseDisappearEvent")] 		public CFloat SetBehVarValueOnRaiseDisappearEvent { get; set;}

		[RED("setBehVarValueOnRaiseAppearEvent")] 		public CFloat SetBehVarValueOnRaiseAppearEvent { get; set;}

		[RED("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[RED("heading")] 		public Vector Heading { get; set;}

		[RED("randVec")] 		public Vector RandVec { get; set;}

		[RED("playerPos")] 		public Vector PlayerPos { get; set;}

		[RED("whereTo")] 		public Vector WhereTo { get; set;}

		[RED("canBeStrafed")] 		public CBool CanBeStrafed { get; set;}

		[RED("appearRaiseEventLaunched")] 		public CBool AppearRaiseEventLaunched { get; set;}

		[RED("disappearRaiseEventLaunched")] 		public CBool DisappearRaiseEventLaunched { get; set;}

		[RED("newPosition")] 		public Vector NewPosition { get; set;}

		[RED("rotated")] 		public CBool Rotated { get; set;}

		public CBTTaskTeleport(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTeleport(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}