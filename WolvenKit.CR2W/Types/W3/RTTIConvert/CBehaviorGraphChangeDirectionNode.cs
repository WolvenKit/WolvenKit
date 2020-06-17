using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphChangeDirectionNode : CBehaviorGraphValueNode
	{
		[RED("anyDirection")] 		public CBool AnyDirection { get; set;}

		[RED("angles", 2,0)] 		public CArray<CFloat> Angles { get; set;}

		[RED("updateOnlyOnActivation")] 		public CBool UpdateOnlyOnActivation { get; set;}

		[RED("dirBlendTime")] 		public CFloat DirBlendTime { get; set;}

		[RED("dirMaxBlendSpeed")] 		public CFloat DirMaxBlendSpeed { get; set;}

		[RED("overshootAngle")] 		public CFloat OvershootAngle { get; set;}

		[RED("requestedFacingDirectionWSVariableName")] 		public CName RequestedFacingDirectionWSVariableName { get; set;}

		[RED("cachedRequestedFacingDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

		public CBehaviorGraphChangeDirectionNode(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CBehaviorGraphChangeDirectionNode(cr2w);

	}
}