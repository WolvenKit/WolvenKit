using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(2)] [RED("("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(3)] [RED("("takeEventsFromMostImportantInput")] 		public CBool TakeEventsFromMostImportantInput { get; set;}

		[Ordinal(4)] [RED("("firstInputValue")] 		public CFloat FirstInputValue { get; set;}

		[Ordinal(5)] [RED("("secondInputValue")] 		public CFloat SecondInputValue { get; set;}

		[Ordinal(6)] [RED("("cachedFirstInputNode")] 		public CPtr<CBehaviorGraphNode> CachedFirstInputNode { get; set;}

		[Ordinal(7)] [RED("("cachedSecondInputNode")] 		public CPtr<CBehaviorGraphNode> CachedSecondInputNode { get; set;}

		[Ordinal(8)] [RED("("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphBlendNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}