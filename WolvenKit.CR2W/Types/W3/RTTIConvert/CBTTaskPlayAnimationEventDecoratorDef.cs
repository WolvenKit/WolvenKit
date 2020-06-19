using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayAnimationEventDecoratorDef : IBehTreeTaskDefinition
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

		public CBTTaskPlayAnimationEventDecoratorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayAnimationEventDecoratorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}