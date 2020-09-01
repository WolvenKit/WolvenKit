using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphBlendAdditiveNode : CBehaviorGraphNode
	{
		[Ordinal(0)] [RED("("type")] 		public CEnum<EAdditiveType> Type { get; set;}

		[Ordinal(0)] [RED("("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(0)] [RED("("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(0)] [RED("("biasValue")] 		public CFloat BiasValue { get; set;}

		[Ordinal(0)] [RED("("scaleValue")] 		public CFloat ScaleValue { get; set;}

		[Ordinal(0)] [RED("("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(0)] [RED("("cachedAddedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedAddedInputNode { get; set;}

		[Ordinal(0)] [RED("("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphBlendAdditiveNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendAdditiveNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}