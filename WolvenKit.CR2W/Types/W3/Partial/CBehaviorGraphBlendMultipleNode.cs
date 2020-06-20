using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CBehaviorGraphBlendMultipleNode : CBehaviorGraphNode
	{
		[RED("synchronize")] 		public CBool Synchronize { get; set;}

		[RED("syncMethod")] 		public CPtr<IBehaviorSyncMethod> SyncMethod { get; set;}

		[RED("inputValues", 2,0)] 		public CArray<CFloat> InputValues { get; set;}

		[RED("minControlValue")] 		public CFloat MinControlValue { get; set;}

		[RED("maxControlValue")] 		public CFloat MaxControlValue { get; set;}

		[RED("radialBlending")] 		public CBool RadialBlending { get; set;}

		[RED("takeEventsFromMoreImportantInput")] 		public CBool TakeEventsFromMoreImportantInput { get; set;}

		[RED("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[RED("cachedMinControlValue")] 		public CPtr<CBehaviorGraphValueNode> CachedMinControlValue { get; set;}

		[RED("cachedMaxControlValue")] 		public CPtr<CBehaviorGraphValueNode> CachedMaxControlValue { get; set;}

		public CBehaviorGraphBlendMultipleNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphBlendMultipleNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}