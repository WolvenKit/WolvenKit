using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphAnimationSwitchNode : CBehaviorGraphNode
	{
		[Ordinal(1)] [RED("("inputNum")] 		public CUInt32 InputNum { get; set;}

		[Ordinal(2)] [RED("("cachedInputNodes", 2,0)] 		public CArray<CPtr<CBehaviorGraphNode>> CachedInputNodes { get; set;}

		[Ordinal(3)] [RED("("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(4)] [RED("("cachedBlendTimeValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedBlendTimeValueNode { get; set;}

		[Ordinal(5)] [RED("("blendTime")] 		public CFloat BlendTime { get; set;}

		[Ordinal(6)] [RED("("interpolation")] 		public CEnum<EInterpolationType> Interpolation { get; set;}

		[Ordinal(7)] [RED("("synchronizeOnSwitch")] 		public CBool SynchronizeOnSwitch { get; set;}

		[Ordinal(8)] [RED("("syncOnSwitchMethod")] 		public CPtr<IBehaviorSyncMethod> SyncOnSwitchMethod { get; set;}

		public CBehaviorGraphAnimationSwitchNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphAnimationSwitchNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}