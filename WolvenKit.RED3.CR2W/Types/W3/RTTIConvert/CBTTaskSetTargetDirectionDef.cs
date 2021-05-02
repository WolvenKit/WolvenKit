using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetTargetDirectionDef : IBehTreeTaskDefinition
	{
		[Ordinal(1)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(2)] [RED("setRotationOnActivate")] 		public CBool SetRotationOnActivate { get; set;}

		[Ordinal(3)] [RED("setOnAnimEvent")] 		public CBool SetOnAnimEvent { get; set;}

		[Ordinal(4)] [RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[Ordinal(5)] [RED("useTargetsTarget")] 		public CBool UseTargetsTarget { get; set;}

		[Ordinal(6)] [RED("completeOnAllowBlend")] 		public CBool CompleteOnAllowBlend { get; set;}

		public CBTTaskSetTargetDirectionDef(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}