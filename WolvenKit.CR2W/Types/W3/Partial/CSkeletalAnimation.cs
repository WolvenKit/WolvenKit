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
		[Ordinal(0)] [RED("name")] 		public CName Name { get; set;}

		[Ordinal(0)] [RED("importFileTimeStamp")] 		public CDateTime ImportFileTimeStamp { get; set;}

		[Ordinal(0)] [RED("Import file")] 		public CString Import_file { get; set;}

		[Ordinal(0)] [RED("authorName")] 		public CString AuthorName { get; set;}

		[Ordinal(0)] [RED("baseResourcePath")] 		public CString BaseResourcePath { get; set;}

		[Ordinal(0)] [RED("Animation type for reimport")] 		public CEnum<ESkeletalAnimationType> Animation_type_for_reimport { get; set;}

		[Ordinal(0)] [RED("Additive type for reimport")] 		public CEnum<EAdditiveType> Additive_type_for_reimport { get; set;}

		[Ordinal(0)] [RED("Additive anim ref name for reimport")] 		public CString Additive_anim_ref_name_for_reimport { get; set;}

		[Ordinal(0)] [RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[Ordinal(0)] [RED("streamingType")] 		public CEnum<ESkeletalAnimationStreamingType> StreamingType { get; set;}

		[Ordinal(0)] [RED("useOwnBitwiseCompressionParams")] 		public CBool UseOwnBitwiseCompressionParams { get; set;}

		[Ordinal(0)] [RED("bitwiseCompressionPreset")] 		public CEnum<SAnimationBufferBitwiseCompressionPreset> BitwiseCompressionPreset { get; set;}

		[Ordinal(0)] [RED("bitwiseCompressionSettings")] 		public SAnimationBufferBitwiseCompressionSettings BitwiseCompressionSettings { get; set;}

		[Ordinal(0)] [RED("sourceDataCreatedFromAnimBuffer")] 		public CBool SourceDataCreatedFromAnimBuffer { get; set;}

		[Ordinal(0)] [RED("hasBundingBox")] 		public CBool HasBundingBox { get; set;}

		[Ordinal(0)] [RED("boundingBox")] 		public Box BoundingBox { get; set;}

		[Ordinal(0)] [RED("id")] 		public CUInt32 Id { get; set;}

		[Ordinal(0)] [RED("motionExtraction")] 		public CPtr<IMotionExtraction> MotionExtraction { get; set;}

		[Ordinal(0)] [RED("compressedPose")] 		public CInt32 CompressedPose { get; set;}

		[Ordinal(0)] [RED("animBuffer")] 		public CPtr<IAnimationBuffer> AnimBuffer { get; set;}

		[Ordinal(0)] [RED("framesPerSecond")] 		public CFloat FramesPerSecond { get; set;}

		[Ordinal(0)] [RED("duration")] 		public CFloat Duration { get; set;}

		[Ordinal(0)] [RED("uncompressedMotionExtraction")] 		public CPtr<CUncompressedMotionExtraction> UncompressedMotionExtraction { get; set;}

		[Ordinal(0)] [RED("compressedPoseName")] 		public CName CompressedPoseName { get; set;}

		public CSkeletalAnimation(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimation(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}