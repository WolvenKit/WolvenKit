using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeBoneInterpolate : CBehaviorGraphBaseNode
	{
		[RED("boneInputA")] 		public CString BoneInputA { get; set;}

		[RED("boneInputB")] 		public CString BoneInputB { get; set;}

		[RED("boneOutput")] 		public CString BoneOutput { get; set;}

		[RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		public CBehaviorGraphConstraintNodeBoneInterpolate(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphConstraintNodeBoneInterpolate(cr2w);

	}
}