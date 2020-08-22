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
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("valueScale")] 		public CFloat ValueScale { get; set;}

		[RED("axis")] 		public CEnum<EAxis> Axis { get; set;}

		[RED("clamp")] 		public CBool Clamp { get; set;}

		[RED("angleMin")] 		public CFloat AngleMin { get; set;}

		[RED("angleMax")] 		public CFloat AngleMax { get; set;}

		[RED("cachedControlInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlInputNode { get; set;}

		[RED("cachedWeightInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedWeightInputNode { get; set;}

		[RED("cachedControlAngleInputNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlAngleInputNode { get; set;}

		public CBehaviorGraphCameraControllerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphCameraControllerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}