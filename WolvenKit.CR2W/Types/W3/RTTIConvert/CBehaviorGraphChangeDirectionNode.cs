using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphChangeDirectionNode : CBehaviorGraphValueNode
	{
		[Ordinal(0)] [RED("("anyDirection")] 		public CBool AnyDirection { get; set;}

		[Ordinal(0)] [RED("("angles", 2,0)] 		public CArray<CFloat> Angles { get; set;}

		[Ordinal(0)] [RED("("updateOnlyOnActivation")] 		public CBool UpdateOnlyOnActivation { get; set;}

		[Ordinal(0)] [RED("("dirBlendTime")] 		public CFloat DirBlendTime { get; set;}

		[Ordinal(0)] [RED("("dirMaxBlendSpeed")] 		public CFloat DirMaxBlendSpeed { get; set;}

		[Ordinal(0)] [RED("("overshootAngle")] 		public CFloat OvershootAngle { get; set;}

		[Ordinal(0)] [RED("("requestedFacingDirectionWSVariableName")] 		public CName RequestedFacingDirectionWSVariableName { get; set;}

		[Ordinal(0)] [RED("("cachedRequestedFacingDirectionWSValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedRequestedFacingDirectionWSValueNode { get; set;}

		public CBehaviorGraphChangeDirectionNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphChangeDirectionNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}