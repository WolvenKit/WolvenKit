using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("("synchronize")] 		public CBool Synchronize { get; set;}

		[Ordinal(2)] [RED("("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[Ordinal(3)] [RED("("inputValues", 2,0)] 		public CArray<CFloat> InputValues { get; set;}

		[Ordinal(4)] [RED("("minControlValue")] 		public CFloat MinControlValue { get; set;}

		[Ordinal(5)] [RED("("maxControlValue")] 		public CFloat MaxControlValue { get; set;}

		[Ordinal(6)] [RED("("radialBlending")] 		public CBool RadialBlending { get; set;}

		[Ordinal(7)] [RED("("takeEventsFromMoreImportantInput")] 		public CBool TakeEventsFromMoreImportantInput { get; set;}

		[Ordinal(8)] [RED("("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[Ordinal(9)] [RED("("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(10)] [RED("("cachedMinControlValue")] 		public CPtr<CBehaviorGraphValueNode> CachedMinControlValue { get; set;}

		[Ordinal(11)] [RED("("cachedMaxControlValue")] 		public CPtr<CBehaviorGraphValueNode> CachedMaxControlValue { get; set;}

		public CBehaviorGraphBlendMultipleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendMultipleNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}