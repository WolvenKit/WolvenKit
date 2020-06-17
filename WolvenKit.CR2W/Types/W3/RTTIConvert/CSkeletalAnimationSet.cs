using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CSkeletalAnimationSet : CExtAnimEventsFile
	{
		[RED("animations", 2,0)] 		public CArray<CPtr<CSkeletalAnimationSetEntry>> Animations { get; set;}

		[RED("extAnimEvents", 2,0)] 		public CArray<CHandle<CExtAnimEventsFile>> ExtAnimEvents { get; set;}

		[RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[RED("compressedPoses", 2,0)] 		public CArray<CPtr<ICompressedPose>> CompressedPoses { get; set;}

		[RED("Streaming option")] 		public SAnimationBufferStreamingOption Streaming_option { get; set;}

		[RED("Number of non-streamable bones")] 		public CUInt32 Number_of_non_streamable_bones { get; set;}

		public CSkeletalAnimationSet(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new CSkeletalAnimationSet(cr2w);

	}
}