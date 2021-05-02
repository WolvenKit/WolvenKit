using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphConstraintNodeParentAlign : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("bone")] 		public CString Bone { get; set;}

		[Ordinal(2)] [RED("parentBone")] 		public CString ParentBone { get; set;}

		[Ordinal(3)] [RED("cachedControlValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedControlValueNode { get; set;}

		[Ordinal(4)] [RED("localSpace")] 		public CBool LocalSpace { get; set;}

		public CBehaviorGraphConstraintNodeParentAlign(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}