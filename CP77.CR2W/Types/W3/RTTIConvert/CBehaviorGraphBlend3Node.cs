using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlend3Node : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(2)] [RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(3)] [RED("useCustomSpace")] 		public CBool UseCustomSpace { get; set;}

		[Ordinal(4)] [RED("takeEventsFromMostImportantInput")] 		public CBool TakeEventsFromMostImportantInput { get; set;}

		[Ordinal(5)] [RED("A")] 		public Vector A { get; set;}

		[Ordinal(6)] [RED("B")] 		public Vector B { get; set;}

		[Ordinal(7)] [RED("C")] 		public Vector C { get; set;}

		[Ordinal(8)] [RED("D")] 		public Vector D { get; set;}

		[Ordinal(9)] [RED("cachedInputNode_A")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_A { get; set;}

		[Ordinal(10)] [RED("cachedInputNode_B")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_B { get; set;}

		[Ordinal(11)] [RED("cachedInputNode_C")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_C { get; set;}

		[Ordinal(12)] [RED("cachedInputNode_D")] 		public CPtr<CBehaviorGraphNode> CachedInputNode_D { get; set;}

		[Ordinal(13)] [RED("cachedControlVariableNode_A")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode_A { get; set;}

		[Ordinal(14)] [RED("cachedControlVariableNode_B")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode_B { get; set;}

		public CBehaviorGraphBlend3Node(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlend3Node(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}