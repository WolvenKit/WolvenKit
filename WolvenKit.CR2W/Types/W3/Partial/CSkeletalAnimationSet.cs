using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CSkeletalAnimationSet : CExtAnimEventsFile
	{
		[RED("animations", 2,0)] 		public CArray<CPtr<CSkeletalAnimationSetEntry>> Animations { get; set;}

		[RED("extAnimEvents", 2,0)] 		public CArray<CHandle<CExtAnimEventsFile>> ExtAnimEvents { get; set;}

		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("compressedPoses", 2,0)] 		public CArray<CPtr<ICompressedPose>> CompressedPoses { get; set;}

		[RED("compressedPoseInfos", 2,0)] 		public CArray<SCompressedPoseInfo> CompressedPoseInfos { get; set;}

		[RED("Streaming option")] 		public CEnum<SAnimationBufferStreamingOption> Streaming_option { get; set;}

		[RED("Number of non-streamable bones")] 		public CUInt32 Number_of_non_streamable_bones { get; set;}

		[RED("forceUncompressedImport")] 		public CBool ForceUncompressedImport { get; set;}

		[RED("overrideBitwiseCompressionSettingsOnImport")] 		public CBool OverrideBitwiseCompressionSettingsOnImport { get; set;}

		[RED("bitwiseCompressionPreset")] 		public CEnum<SAnimationBufferBitwiseCompressionPreset> BitwiseCompressionPreset { get; set;}

		[RED("bitwiseCompressionSettings")] 		public SAnimationBufferBitwiseCompressionSettings BitwiseCompressionSettings { get; set;}

		public CSkeletalAnimationSet(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CSkeletalAnimationSet(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}