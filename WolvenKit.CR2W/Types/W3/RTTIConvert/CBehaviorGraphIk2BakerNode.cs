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
		[RED("cachedValueNode")] 		public CPtr<CBehaviorGraphValueNode> CachedValueNode { get; set;}

		[RED("cachedTargetPosNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetPosNode { get; set;}

		[RED("cachedTargetRotNode")] 		public CPtr<CBehaviorGraphVectorValueNode> CachedTargetRotNode { get; set;}

		[RED("endBoneName")] 		public CString EndBoneName { get; set;}

		[RED("blendInDuration")] 		public CFloat BlendInDuration { get; set;}

		[RED("blendOutDuration")] 		public CFloat BlendOutDuration { get; set;}

		[RED("animEventName")] 		public CName AnimEventName { get; set;}

		[RED("defaultEventStartTime")] 		public CFloat DefaultEventStartTime { get; set;}

		[RED("defaultEventEndTime")] 		public CFloat DefaultEventEndTime { get; set;}

		[RED("hingeAxis")] 		public CEnum<EAxis> HingeAxis { get; set;}

		[RED("enforceEndPosition")] 		public CBool EnforceEndPosition { get; set;}

		[RED("bonePositionInWorldSpace")] 		public CBool BonePositionInWorldSpace { get; set;}

		[RED("enforceEndRotation")] 		public CBool EnforceEndRotation { get; set;}

		public CBehaviorGraphIk2BakerNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CBehaviorGraphIk2BakerNode(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}