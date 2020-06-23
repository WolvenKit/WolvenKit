using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSkeletalAnimation : ISerializable
	{
		[RED("name")] 		public CName Name { get; set;}

		[RED("importFileTimeStamp")] 		public CDateTime ImportFileTimeStamp { get; set;}

		[RED("Import file")] 		public CString Import_file { get; set;}

		[RED("authorName")] 		public CString AuthorName { get; set;}

		[RED("baseResourcePath")] 		public CString BaseResourcePath { get; set;}

		[RED("Animation type for reimport")] 		public CEnum<ESkeletalAnimationType> Animation_type_for_reimport { get; set;}

		[RED("Additive type for reimport")] 		public CEnum<EAdditiveType> Additive_type_for_reimport { get; set;}

		[RED("Additive anim ref name for reimport")] 		public CString Additive_anim_ref_name_for_reimport { get; set;}

		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("streamingType")] 		public CEnum<ESkeletalAnimationStreamingType> StreamingType { get; set;}

		[RED("useOwnBitwiseCompressionParams")] 		public CBool UseOwnBitwiseCompressionParams { get; set;}

		[RED("bitwiseCompressionPreset")] 		public CEnum<SAnimationBufferBitwiseCompressionPreset> BitwiseCompressionPreset { get; set;}

		[RED("bitwiseCompressionSettings")] 		public SAnimationBufferBitwiseCompressionSettings BitwiseCompressionSettings { get; set;}

		[RED("sourceDataCreatedFromAnimBuffer")] 		public CBool SourceDataCreatedFromAnimBuffer { get; set;}

		[RED("hasBundingBox")] 		public CBool HasBundingBox { get; set;}

		[RED("boundingBox")] 		public Box BoundingBox { get; set;}

		[RED("id")] 		public CUInt32 Id { get; set;}

		[RED("motionExtraction")] 		public CPtr<IMotionExtraction> MotionExtraction { get; set;}

		[RED("compressedPose")] 		public CInt32 CompressedPose { get; set;}

		[RED("animBuffer")] 		public CPtr<IAnimationBuffer> AnimBuffer { get; set;}

		[RED("framesPerSecond")] 		public CFloat FramesPerSecond { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("uncompressedMotionExtraction")] 		public CPtr<CUncompressedMotionExtraction> UncompressedMotionExtraction { get; set;}

		[RED("compressedPoseName")] 		public CName CompressedPoseName { get; set;}

		public CSkeletalAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}