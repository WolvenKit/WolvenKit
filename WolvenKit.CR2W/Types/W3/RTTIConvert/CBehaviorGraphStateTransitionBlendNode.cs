using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphStateTransitionBlendNode : CBehaviorGraphStateTransitionNode
	{
		[RED("transitionTime")] 		public CFloat TransitionTime { get; set;}

		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("motionBlendType")] 		public CEnum<EBehaviorTransitionBlendMotion> MotionBlendType { get; set;}

		public CBehaviorGraphStateTransitionBlendNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphStateTransitionBlendNode(cr2w);

	}
}