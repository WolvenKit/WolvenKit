using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk2Node : CBehaviorGraphBaseNode
	{
		[RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[RED("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[RED("cachedTargetRotNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotNode { get; set;}

		[RED("firstBone")] 		public CString FirstBone { get; set;}

		[RED("secondBone")] 		public CString SecondBone { get; set;}

		[RED("endBone")] 		public CString EndBone { get; set;}

		[RED("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		[RED("angleMax")] 		public CFloat AngleMax { get; set;}

		[RED("angleMin")] 		public CFloat AngleMin { get; set;}

		[RED("firstJointGain")] 		public CFloat FirstJointGain { get; set;}

		[RED("secondJointGain")] 		public CFloat SecondJointGain { get; set;}

		[RED("endJointGain")] 		public CFloat EndJointGain { get; set;}

		[RED("enforceEndPosition")] 		public CBool EnforceEndPosition { get; set;}

		[RED("enforceEndRotation")] 		public CBool EnforceEndRotation { get; set;}

		[RED("positionOffset")] 		public Vector PositionOffset { get; set;}

		[RED("rotationOffset")] 		public EulerAngles RotationOffset { get; set;}

		public CBehaviorGraphIk2Node(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphIk2Node(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}