using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskPlayAnimationEventDecoratorDef : IBehTreeTaskDefinition
	{
		[Ordinal(0)] [RED("finishTaskOnAllowBlend")] 		public CBool FinishTaskOnAllowBlend { get; set;}

		[Ordinal(0)] [RED("rotateOnRotateEvent")] 		public CBool RotateOnRotateEvent { get; set;}

		[Ordinal(0)] [RED("disableHitOnActivation")] 		public CBool DisableHitOnActivation { get; set;}

		[Ordinal(0)] [RED("disableLookatOnActivation")] 		public CBool DisableLookatOnActivation { get; set;}

		[Ordinal(0)] [RED("interruptOverlayAnim")] 		public CBool InterruptOverlayAnim { get; set;}

		[Ordinal(0)] [RED("checkStats")] 		public CBool CheckStats { get; set;}

		[Ordinal(0)] [RED("xmlMoraleCheckName")] 		public CName XmlMoraleCheckName { get; set;}

		[Ordinal(0)] [RED("xmlStaminaCostName")] 		public CName XmlStaminaCostName { get; set;}

		[Ordinal(0)] [RED("drainStaminaOnUse")] 		public CBool DrainStaminaOnUse { get; set;}

		[Ordinal(0)] [RED("completeTaskOnRotateEnd")] 		public CBool CompleteTaskOnRotateEnd { get; set;}

		[Ordinal(0)] [RED("useCombatTargetForRotation")] 		public CBool UseCombatTargetForRotation { get; set;}

		[Ordinal(0)] [RED("setIsImportantAnim")] 		public CBool SetIsImportantAnim { get; set;}

		public CBTTaskPlayAnimationEventDecoratorDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskPlayAnimationEventDecoratorDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}