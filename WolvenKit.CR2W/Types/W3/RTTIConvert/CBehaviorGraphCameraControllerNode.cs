using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphCameraControllerNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("("valueScale")] 		public CFloat ValueScale { get; set;}

		[Ordinal(3)] [RED("("axis")] 		public CEnum<EAxis> Axis { get; set;}

		[Ordinal(4)] [RED("("clamp")] 		public CBool Clamp { get; set;}

		[Ordinal(5)] [RED("("angleMin")] 		public CFloat AngleMin { get; set;}

		[Ordinal(6)] [RED("("angleMax")] 		public CFloat AngleMax { get; set;}

		[Ordinal(7)] [RED("("cachedControlInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlInputNode { get; set;}

		[Ordinal(8)] [RED("("cachedWeightInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightInputNode { get; set;}

		[Ordinal(9)] [RED("("cachedControlAngleInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlAngleInputNode { get; set;}

		public CBehaviorGraphCameraControllerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCameraControllerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}