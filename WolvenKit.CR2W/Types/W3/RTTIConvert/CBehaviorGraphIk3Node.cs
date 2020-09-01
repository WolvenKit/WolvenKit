using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk3Node : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[Ordinal(0)] [RED("("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[Ordinal(0)] [RED("("firstBone")] 		public CString FirstBone { get; set;}

		[Ordinal(0)] [RED("("secondBone")] 		public CString SecondBone { get; set;}

		[Ordinal(0)] [RED("("thirdBone")] 		public CString ThirdBone { get; set;}

		[Ordinal(0)] [RED("("endBone")] 		public CString EndBone { get; set;}

		[Ordinal(0)] [RED("("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		public CBehaviorGraphIk3Node(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphIk3Node(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}