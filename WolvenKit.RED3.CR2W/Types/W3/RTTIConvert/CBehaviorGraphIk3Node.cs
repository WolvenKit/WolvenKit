using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk3Node : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[Ordinal(2)] [RED("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[Ordinal(3)] [RED("firstBone")] 		public CString FirstBone { get; set;}

		[Ordinal(4)] [RED("secondBone")] 		public CString SecondBone { get; set;}

		[Ordinal(5)] [RED("thirdBone")] 		public CString ThirdBone { get; set;}

		[Ordinal(6)] [RED("endBone")] 		public CString EndBone { get; set;}

		[Ordinal(7)] [RED("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		public CBehaviorGraphIk3Node(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}