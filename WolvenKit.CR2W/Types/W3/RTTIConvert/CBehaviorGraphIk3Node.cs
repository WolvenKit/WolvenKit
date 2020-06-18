using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk3Node : CBehaviorGraphBaseNode
	{
		[RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[RED("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[RED("firstBone")] 		public CString FirstBone { get; set;}

		[RED("secondBone")] 		public CString SecondBone { get; set;}

		[RED("thirdBone")] 		public CString ThirdBone { get; set;}

		[RED("endBone")] 		public CString EndBone { get; set;}

		[RED("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		public CBehaviorGraphIk3Node(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphIk3Node(cr2w);

	}
}