using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphRotateBoneNode : CBehaviorGraphBaseNode
	{
		[Ordinal(0)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(0)] [RED("axis")] 		public CEnum<EBoneRotationAxis> Axis { get; set;}

		[Ordinal(0)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(0)] [RED("biasAngle")] 		public CFloat BiasAngle { get; set;}

		[Ordinal(0)] [RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[Ordinal(0)] [RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		[Ordinal(0)] [RED("clampRotation")] 		public CBool ClampRotation { get; set;}

		[Ordinal(0)] [RED("localSpace")] 		public CBool LocalSpace { get; set;}

		[Ordinal(0)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(0)] [RED("cachedAngleMinNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMinNode { get; set;}

		[Ordinal(0)] [RED("cachedAngleMaxNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMaxNode { get; set;}

		public CBehaviorGraphRotateBoneNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphRotateBoneNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}