using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRotateBoneNode : CBehaviorGraphBaseNode
	{
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("axis")] 		public EBoneRotationAxis Axis { get; set;}

		[RED("scale")] 		public CFloat Scale { get; set;}

		[RED("biasAngle")] 		public CFloat BiasAngle { get; set;}

		[RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		[RED("clampRotation")] 		public CBool ClampRotation { get; set;}

		[RED("localSpace")] 		public CBool LocalSpace { get; set;}

		[RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[RED("cachedAngleMinNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMinNode { get; set;}

		[RED("cachedAngleMaxNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMaxNode { get; set;}

		public CBehaviorGraphRotateBoneNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphRotateBoneNode(cr2w);

	}
}