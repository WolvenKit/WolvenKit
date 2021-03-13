using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphPivotRotationNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("pivotBoneName")] 		public CString PivotBoneName { get; set;}

		[Ordinal(3)] [RED("axis")] 		public CEnum<EAxis> Axis { get; set;}

		[Ordinal(4)] [RED("scale")] 		public CFloat Scale { get; set;}

		[Ordinal(5)] [RED("biasAngle")] 		public CFloat BiasAngle { get; set;}

		[Ordinal(6)] [RED("minAngle")] 		public CFloat MinAngle { get; set;}

		[Ordinal(7)] [RED("maxAngle")] 		public CFloat MaxAngle { get; set;}

		[Ordinal(8)] [RED("clampRotation")] 		public CBool ClampRotation { get; set;}

		[Ordinal(9)] [RED("cachedControlVariableNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlVariableNode { get; set;}

		[Ordinal(10)] [RED("cachedAngleMinNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMinNode { get; set;}

		[Ordinal(11)] [RED("cachedAngleMaxNode")] 		public CPtr<CBehaviorGraphValueNode> CachedAngleMaxNode { get; set;}

		public CBehaviorGraphPivotRotationNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphPivotRotationNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}