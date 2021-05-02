using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTeleport : TaskTeleportAction
	{
		[Ordinal(1)] [RED("vanish")] 		public CBool Vanish { get; set;}

		[Ordinal(2)] [RED("forceInvisible")] 		public CBool ForceInvisible { get; set;}

		[Ordinal(3)] [RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(4)] [RED("slideInsteadOfTeleport")] 		public CBool SlideInsteadOfTeleport { get; set;}

		[Ordinal(5)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(6)] [RED("nextTeleTime")] 		public CFloat NextTeleTime { get; set;}

		[Ordinal(7)] [RED("delayActivation")] 		public CFloat DelayActivation { get; set;}

		[Ordinal(8)] [RED("delayReappearance")] 		public CFloat DelayReappearance { get; set;}

		[Ordinal(9)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(10)] [RED("disableInvisibilityAfterReappearance")] 		public CBool DisableInvisibilityAfterReappearance { get; set;}

		[Ordinal(11)] [RED("disableImmortalityAfterReappearance")] 		public CBool DisableImmortalityAfterReappearance { get; set;}

		[Ordinal(12)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(13)] [RED("appearFXName")] 		public CName AppearFXName { get; set;}

		[Ordinal(14)] [RED("stopEffectAppearFXName")] 		public CBool StopEffectAppearFXName { get; set;}

		[Ordinal(15)] [RED("additionalAppearFXName")] 		public CName AdditionalAppearFXName { get; set;}

		[Ordinal(16)] [RED("performPosCheckOnTeleportEventName")] 		public CBool PerformPosCheckOnTeleportEventName { get; set;}

		[Ordinal(17)] [RED("performLastMomentPosCheck")] 		public CBool PerformLastMomentPosCheck { get; set;}

		[Ordinal(18)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(19)] [RED("activationEventName")] 		public CName ActivationEventName { get; set;}

		[Ordinal(20)] [RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(21)] [RED("raiseEventImmediately")] 		public CBool RaiseEventImmediately { get; set;}

		[Ordinal(22)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(23)] [RED("appearRaiseEventName")] 		public CName AppearRaiseEventName { get; set;}

		[Ordinal(24)] [RED("enableCollisionAfterReappearance")] 		public CBool EnableCollisionAfterReappearance { get; set;}

		[Ordinal(25)] [RED("enableCollisionsOnDeactivate")] 		public CBool EnableCollisionsOnDeactivate { get; set;}

		[Ordinal(26)] [RED("appearFXPlayed")] 		public CBool AppearFXPlayed { get; set;}

		[Ordinal(27)] [RED("shouldPlayHitAnim")] 		public CBool ShouldPlayHitAnim { get; set;}

		[Ordinal(28)] [RED("sendRotationEventAboveTeleportDist")] 		public CFloat SendRotationEventAboveTeleportDist { get; set;}

		[Ordinal(29)] [RED("appearRaiseEventNameOnFailure")] 		public CName AppearRaiseEventNameOnFailure { get; set;}

		[Ordinal(30)] [RED("setBehVarNameOnRaiseEvent")] 		public CName SetBehVarNameOnRaiseEvent { get; set;}

		[Ordinal(31)] [RED("setBehVarValueOnRaiseDisappearEvent")] 		public CFloat SetBehVarValueOnRaiseDisappearEvent { get; set;}

		[Ordinal(32)] [RED("setBehVarValueOnRaiseAppearEvent")] 		public CFloat SetBehVarValueOnRaiseAppearEvent { get; set;}

		[Ordinal(33)] [RED("cameraToPlayerDistance")] 		public CFloat CameraToPlayerDistance { get; set;}

		[Ordinal(34)] [RED("heading")] 		public Vector Heading { get; set;}

		[Ordinal(35)] [RED("randVec")] 		public Vector RandVec { get; set;}

		[Ordinal(36)] [RED("playerPos")] 		public Vector PlayerPos { get; set;}

		[Ordinal(37)] [RED("whereTo")] 		public Vector WhereTo { get; set;}

		[Ordinal(38)] [RED("canBeStrafed")] 		public CBool CanBeStrafed { get; set;}

		[Ordinal(39)] [RED("appearRaiseEventLaunched")] 		public CBool AppearRaiseEventLaunched { get; set;}

		[Ordinal(40)] [RED("disappearRaiseEventLaunched")] 		public CBool DisappearRaiseEventLaunched { get; set;}

		[Ordinal(41)] [RED("newPosition")] 		public Vector NewPosition { get; set;}

		[Ordinal(42)] [RED("rotated")] 		public CBool Rotated { get; set;}

		public CBTTaskTeleport(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}