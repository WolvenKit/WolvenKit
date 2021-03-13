using FastMember;
using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskTeleportDef : TaskTeleportActionDef
	{
		[Ordinal(0)] [RED("cooldown")] 		public CFloat Cooldown { get; set;}

		[Ordinal(1)] [RED("delayActivation")] 		public CFloat DelayActivation { get; set;}

		[Ordinal(2)] [RED("delayReappearance")] 		public CFloat DelayReappearance { get; set;}

		[Ordinal(3)] [RED("slideInsteadOfTeleport")] 		public CBool SlideInsteadOfTeleport { get; set;}

		[Ordinal(4)] [RED("forceInvisible")] 		public CBool ForceInvisible { get; set;}

		[Ordinal(5)] [RED("disableGameplayVisibility")] 		public CBool DisableGameplayVisibility { get; set;}

		[Ordinal(6)] [RED("disableInvisibilityAfterReappearance")] 		public CBool DisableInvisibilityAfterReappearance { get; set;}

		[Ordinal(7)] [RED("disableImmortalityAfterReappearance")] 		public CBool DisableImmortalityAfterReappearance { get; set;}

		[Ordinal(8)] [RED("enableCollisionAfterReappearance")] 		public CBool EnableCollisionAfterReappearance { get; set;}

		[Ordinal(9)] [RED("enableCollisionsOnDeactivate")] 		public CBool EnableCollisionsOnDeactivate { get; set;}

		[Ordinal(10)] [RED("disallowInPlayerFOV")] 		public CBool DisallowInPlayerFOV { get; set;}

		[Ordinal(11)] [RED("performPosCheckOnTeleportEventName")] 		public CBool PerformPosCheckOnTeleportEventName { get; set;}

		[Ordinal(12)] [RED("performLastMomentPosCheck")] 		public CBool PerformLastMomentPosCheck { get; set;}

		[Ordinal(13)] [RED("activationEventName")] 		public CName ActivationEventName { get; set;}

		[Ordinal(14)] [RED("teleportEventName")] 		public CName TeleportEventName { get; set;}

		[Ordinal(15)] [RED("appearRaiseEventName")] 		public CName AppearRaiseEventName { get; set;}

		[Ordinal(16)] [RED("appearRaiseEventNameOnFailure")] 		public CName AppearRaiseEventNameOnFailure { get; set;}

		[Ordinal(17)] [RED("setBehVarNameOnRaiseEvent")] 		public CName SetBehVarNameOnRaiseEvent { get; set;}

		[Ordinal(18)] [RED("setBehVarValueOnRaiseDisappearEvent")] 		public CFloat SetBehVarValueOnRaiseDisappearEvent { get; set;}

		[Ordinal(19)] [RED("setBehVarValueOnRaiseAppearEvent")] 		public CFloat SetBehVarValueOnRaiseAppearEvent { get; set;}

		[Ordinal(20)] [RED("disappearfxName")] 		public CName DisappearfxName { get; set;}

		[Ordinal(21)] [RED("appearFXName")] 		public CName AppearFXName { get; set;}

		[Ordinal(22)] [RED("stopEffectAppearFXName")] 		public CBool StopEffectAppearFXName { get; set;}

		[Ordinal(23)] [RED("additionalAppearFXName")] 		public CName AdditionalAppearFXName { get; set;}

		[Ordinal(24)] [RED("raiseEventName")] 		public CName RaiseEventName { get; set;}

		[Ordinal(25)] [RED("raiseEventImmediately")] 		public CBool RaiseEventImmediately { get; set;}

		[Ordinal(26)] [RED("shouldPlayHitAnim")] 		public CBool ShouldPlayHitAnim { get; set;}

		[Ordinal(27)] [RED("sendRotationEventAboveTeleportDist")] 		public CFloat SendRotationEventAboveTeleportDist { get; set;}

		/// <summary>
		/// Not in RTTI
		/// </summary>
		[Ordinal(28)] [RED("teleportToRequestedFacingDirection ")] 		public CBool TeleportToRequestedFacingDirection { get; set;}
		/// <summary>
		/// Not in RTTI
		/// </summary>
		[Ordinal(29)] [RED("teleportAwayFromRequestedFacingDirection ")] 		public CBool TeleportAwayFromRequestedFacingDirection { get; set;}

		public CBTTaskTeleportDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskTeleportDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}