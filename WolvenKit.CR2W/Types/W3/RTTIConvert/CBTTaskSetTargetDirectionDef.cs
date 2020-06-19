using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetTargetDirectionDef : IBehTreeTaskDefinition
	{
		[RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[RED("setRotationOnActivate")] 		public CBool SetRotationOnActivate { get; set;}

		[RED("setOnAnimEvent")] 		public CBool SetOnAnimEvent { get; set;}

		[RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[RED("useTargetsTarget")] 		public CBool UseTargetsTarget { get; set;}

		[RED("completeOnAllowBlend")] 		public CBool CompleteOnAllowBlend { get; set;}

		public CBTTaskSetTargetDirectionDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetTargetDirectionDef(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}