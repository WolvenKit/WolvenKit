using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayAnimationEventDecorator : IBehTreeTask
	{
		[RED("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		[RED("rotateOnRotateEvent")] 		public CBool RotateOnRotateEvent { get; set;}

		[RED("disableHitOnActivation")] 		public CBool DisableHitOnActivation { get; set;}

		[RED("disableLookatOnActivation")] 		public CBool DisableLookatOnActivation { get; set;}

		[RED("interruptOverlayAnim")] 		public CBool InterruptOverlayAnim { get; set;}

		[RED("checkStats")] 		public CBool CheckStats { get; set;}

		[RED("xmlMoraleCheckName")] 		public CName XmlMoraleCheckName { get; set;}

		[RED("xmlStaminaCostName")] 		public CName XmlStaminaCostName { get; set;}

		[RED("drainStaminaOnUse")] 		public CBool DrainStaminaOnUse { get; set;}

		[RED("completeTaskOnRotateEnd")] 		public CBool CompleteTaskOnRotateEnd { get; set;}

		[RED("useCombatTargetForRotation")] 		public CBool UseCombatTargetForRotation { get; set;}

		[RED("setIsImportantAnim")] 		public CBool SetIsImportantAnim { get; set;}

		[RED("staminaCost")] 		public CFloat StaminaCost { get; set;}

		[RED("moraleThreshold")] 		public CFloat MoraleThreshold { get; set;}

		[RED("lookAt")] 		public CBool LookAt { get; set;}

		[RED("hitAnim")] 		public CBool HitAnim { get; set;}

		[RED("additiveHits")] 		public CBool AdditiveHits { get; set;}

		[RED("slowMo")] 		public CBool SlowMo { get; set;}

		[RED("guardOpen")] 		public CBool GuardOpen { get; set;}

		[RED("unstoppable")] 		public CBool Unstoppable { get; set;}

		[RED("waitingForEndOfDisableHit")] 		public CBool WaitingForEndOfDisableHit { get; set;}

		[RED("combatDataStorage")] 		public CHandle<CBaseAICombatStorage> CombatDataStorage { get; set;}

		public CBTTaskPlayAnimationEventDecorator(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayAnimationEventDecorator(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}