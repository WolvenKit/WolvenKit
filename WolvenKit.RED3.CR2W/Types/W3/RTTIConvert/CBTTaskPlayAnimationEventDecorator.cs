using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayAnimationEventDecorator : IBehTreeTask
	{
		[Ordinal(1)] [RED("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		[Ordinal(2)] [RED("rotateOnRotateEvent")] 		public CBool RotateOnRotateEvent { get; set;}

		[Ordinal(3)] [RED("disableHitOnActivation")] 		public CBool DisableHitOnActivation { get; set;}

		[Ordinal(4)] [RED("disableLookatOnActivation")] 		public CBool DisableLookatOnActivation { get; set;}

		[Ordinal(5)] [RED("interruptOverlayAnim")] 		public CBool InterruptOverlayAnim { get; set;}

		[Ordinal(6)] [RED("checkStats")] 		public CBool CheckStats { get; set;}

		[Ordinal(7)] [RED("xmlMoraleCheckName")] 		public CName XmlMoraleCheckName { get; set;}

		[Ordinal(8)] [RED("xmlStaminaCostName")] 		public CName XmlStaminaCostName { get; set;}

		[Ordinal(9)] [RED("drainStaminaOnUse")] 		public CBool DrainStaminaOnUse { get; set;}

		[Ordinal(10)] [RED("completeTaskOnRotateEnd")] 		public CBool CompleteTaskOnRotateEnd { get; set;}

		[Ordinal(11)] [RED("useCombatTargetForRotation")] 		public CBool UseCombatTargetForRotation { get; set;}

		[Ordinal(12)] [RED("setIsImportantAnim")] 		public CBool SetIsImportantAnim { get; set;}

		[Ordinal(13)] [RED("staminaCost")] 		public CFloat StaminaCost { get; set;}

		[Ordinal(14)] [RED("moraleThreshold")] 		public CFloat MoraleThreshold { get; set;}

		[Ordinal(15)] [RED("lookAt")] 		public CBool LookAt { get; set;}

		[Ordinal(16)] [RED("hitAnim")] 		public CBool HitAnim { get; set;}

		[Ordinal(17)] [RED("additiveHits")] 		public CBool AdditiveHits { get; set;}

		[Ordinal(18)] [RED("slowMo")] 		public CBool SlowMo { get; set;}

		[Ordinal(19)] [RED("guardOpen")] 		public CBool GuardOpen { get; set;}

		[Ordinal(20)] [RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[Ordinal(21)] [RED("waitingForEndOfDisableHit")] 		public CBool WaitingForEndOfDisableHit { get; set;}

		[Ordinal(22)] [RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		public CBTTaskPlayAnimationEventDecorator(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayAnimationEventDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}