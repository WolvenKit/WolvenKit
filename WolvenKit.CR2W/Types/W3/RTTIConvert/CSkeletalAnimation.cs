using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimation : ISerializable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("streamingType")] 		public CEnum<ESkeletalAnimationStreamingType> StreamingType { get; set;}

		[RED("hasBundingBox")] 		public CBool HasBundingBox { get; set;}

		[RED("boundingBox")] 		public Box BoundingBox { get; set;}

		[RED("id")] 		public CUInt32 Id { get; set;}

		[RED("motionExtraction")] 		public CPtr<IMotionExtraction> MotionExtraction { get; set;}

		[RED("compressedPose")] 		public CInt32 CompressedPose { get; set;}

		[RED("animBuffer")] 		public CPtr<IAnimationBuffer> AnimBuffer { get; set;}

		[RED("framesPerSecond")] 		public CFloat FramesPerSecond { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		public CSkeletalAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}