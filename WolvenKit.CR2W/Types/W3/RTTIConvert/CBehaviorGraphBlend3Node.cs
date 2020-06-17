using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlend3Node : CBehaviorGraphNode
	{
		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("useCustomSpace")] 		public CBool UseCustomSpace { get; set;}

		[RED("takeEventsFromMostImportantInput")] 		public CBool TakeEventsFromMostImportantInput { get; set;}

		[RED("A")] 		public Vector A { get; set;}

		[RED("B")] 		public Vector B { get; set;}

		[RED("C")] 		public Vector C { get; set;}

		[RED("D")] 		public Vector D { get; set;}

		[RED("cachedInputNode_A")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_A { get; set;}

		[RED("cachedInputNode_B")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_B { get; set;}

		[RED("cachedInputNode_C")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_C { get; set;}

		[RED("cachedInputNode_D")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_D { get; set;}

		[RED("cachedControlVariableNode_A")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode_A { get; set;}

		[RED("cachedControlVariableNode_B")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode_B { get; set;}

		public CBehaviorGraphBlend3Node(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphBlend3Node(cr2w);

	}
}