using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CBehaviorGraphIk2BakerNode : CBehaviorGraphBaseNode
	{
		[Ordinal(1)] [RED("("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[Ordinal(2)] [RED("("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[Ordinal(3)] [RED("("cachedTargetRotNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotNode { get; set;}

		[Ordinal(4)] [RED("("endBoneName")] 		public CString EndBoneName { get; set;}

		[Ordinal(5)] [RED("("blendInDuration")] 		public CFloat BlendInDuration { get; set;}

		[Ordinal(6)] [RED("("blendOutDuration")] 		public CFloat BlendOutDuration { get; set;}

		[Ordinal(7)] [RED("("animEventName")] 		public CName AnimEventName { get; set;}

		[Ordinal(8)] [RED("("defaultEventStartTime")] 		public CFloat DefaultEventStartTime { get; set;}

		[Ordinal(9)] [RED("("defaultEventEndTime")] 		public CFloat DefaultEventEndTime { get; set;}

		[Ordinal(10)] [RED("("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		[Ordinal(11)] [RED("("enforceEndPosition")] 		public CBool EnforceEndPosition { get; set;}

		[Ordinal(12)] [RED("("bonePositionInWorldSpace")] 		public CBool BonePositionInWorldSpace { get; set;}

		[Ordinal(13)] [RED("("enforceEndRotation")] 		public CBool EnforceEndRotation { get; set;}

		public CBehaviorGraphIk2BakerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphIk2BakerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}