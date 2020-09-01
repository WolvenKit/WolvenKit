using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionBlendNode : CBehaviorGraphStateTransitionNode
	{
		[Ordinal(1)] [RED("transitionTime")] 		public CFloat TransitionTime { get; set;}

		[Ordinal(2)] [RED("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(3)] [RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(4)] [RED("motionBlendType")] 		public CEnum<EBehaviorTransitionBlendMotion> MotionBlendType { get; set;}

		public CBehaviorGraphStateTransitionBlendNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphStateTransitionBlendNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}