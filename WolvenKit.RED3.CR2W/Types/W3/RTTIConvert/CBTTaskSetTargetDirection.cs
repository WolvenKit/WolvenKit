using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBTTaskSetTargetDirection : IBehTreeTask
	{
		[Ordinal(1)] [RED("npcPos")] 		public Vector NpcPos { get; set;}

		[Ordinal(2)] [RED("vec")] 		public Vector Vec { get; set;}

		[Ordinal(3)] [RED("curRot")] 		public EulerAngles CurRot { get; set;}

		[Ordinal(4)] [RED("rot")] 		public EulerAngles Rot { get; set;}

		[Ordinal(5)] [RED("angleDistance")] 		public CFloat AngleDistance { get; set;}

		[Ordinal(6)] [RED("useCombatTarget")] 		public CBool UseCombatTarget { get; set;}

		[Ordinal(7)] [RED("setRotationOnActivate")] 		public CBool SetRotationOnActivate { get; set;}

		[Ordinal(8)] [RED("setOnAnimEvent")] 		public CBool SetOnAnimEvent { get; set;}

		[Ordinal(9)] [RED("animationEventName")] 		public CName AnimationEventName { get; set;}

		[Ordinal(10)] [RED("useTargetsTarget")] 		public CBool UseTargetsTarget { get; set;}

		[Ordinal(11)] [RED("completeOnAllowBlend")] 		public CBool CompleteOnAllowBlend { get; set;}

		public CBTTaskSetTargetDirection(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBTTaskSetTargetDirection(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}