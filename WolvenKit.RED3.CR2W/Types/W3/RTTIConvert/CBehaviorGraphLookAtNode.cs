using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("boneName")] 		public CString BoneName { get; set;}

		[Ordinal(2)] [RED("axis")] 		public Vector Axis { get; set;}

		[Ordinal(3)] [RED("useLimits")] 		public CBool UseLimits { get; set;}

		[Ordinal(4)] [RED("limitAngle")] 		public CFloat LimitAngle { get; set;}

		[Ordinal(5)] [RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[Ordinal(6)] [RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		public CBehaviorGraphLookAtNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphLookAtNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}