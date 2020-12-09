using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintCameraDialog : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("cameraBone")] 		public CString CameraBone { get; set;}

		[Ordinal(2)] [RED("referenceZ")] 		public CFloat ReferenceZ { get; set;}

		[Ordinal(3)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(4)] [RED("cachedSourceTargetValueNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedSourceTargetValueNode { get; set;}

		[Ordinal(5)] [RED("cachedDestTargetValueNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedDestTargetValueNode { get; set;}

		public CBehaviorGraphConstraintCameraDialog(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphConstraintCameraDialog(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}