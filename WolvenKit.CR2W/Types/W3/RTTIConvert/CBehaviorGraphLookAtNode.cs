using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphLookAtNode : CBehaviorGraphBaseNode
	{
		[RED("boneName")] 		public CString BoneName { get; set;}

		[RED("axis")] 		public Vector Axis { get; set;}

		[RED("useLimits")] 		public CBool UseLimits { get; set;}

		[RED("limitAngle")] 		public CFloat LimitAngle { get; set;}

		[RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[RED("cachedTargetNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetNode { get; set;}

		public CBehaviorGraphLookAtNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphLookAtNode(cr2w);

	}
}