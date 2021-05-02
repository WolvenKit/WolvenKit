using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphSyncOverrideNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("rootBoneName")] 		public CString RootBoneName { get; set;}

		[Ordinal(2)] [RED("blendRootParent")] 		public CBool BlendRootParent { get; set;}

		[Ordinal(3)] [RED("defaultWeight")] 		public CFloat DefaultWeight { get; set;}

		[Ordinal(4)] [RED("cachedInputNode")] 		public CPtr<CBehaviorGraphNode> CachedInputNode { get; set;}

		[Ordinal(5)] [RED("cachedOverrideInputNode")] 		public CPtr<CBehaviorGraphNode> CachedOverrideInputNode { get; set;}

		[Ordinal(6)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		public CBehaviorGraphSyncOverrideNode(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphSyncOverrideNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}