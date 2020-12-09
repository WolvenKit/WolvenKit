using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk2Node : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[Ordinal(2)] [RED("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[Ordinal(3)] [RED("cachedTargetRotNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotNode { get; set;}

		[Ordinal(4)] [RED("firstBone")] 		public CString FirstBone { get; set;}

		[Ordinal(5)] [RED("secondBone")] 		public CString SecondBone { get; set;}

		[Ordinal(6)] [RED("endBone")] 		public CString EndBone { get; set;}

		[Ordinal(7)] [RED("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		[Ordinal(8)] [RED("angleMax")] 		public CFloat AngleMax { get; set;}

		[Ordinal(9)] [RED("angleMin")] 		public CFloat AngleMin { get; set;}

		[Ordinal(10)] [RED("firstJointGain")] 		public CFloat FirstJointGain { get; set;}

		[Ordinal(11)] [RED("secondJointGain")] 		public CFloat SecondJointGain { get; set;}

		[Ordinal(12)] [RED("endJointGain")] 		public CFloat EndJointGain { get; set;}

		[Ordinal(13)] [RED("enforceEndPosition")] 		public CBool EnforceEndPosition { get; set;}

		[Ordinal(14)] [RED("enforceEndRotation")] 		public CBool EnforceEndRotation { get; set;}

		[Ordinal(15)] [RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[Ordinal(16)] [RED("rotationOffset")] 		public EulerAngles RotationOffset { get; set;}

		public CBehaviorGraphIk2Node(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphIk2Node(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}