using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimationBufferBitwiseCompressed : IAnimationBuffer
	{
		[RED("version")] 		public CUInt32 Version { get; set;}

		[RED("bones", 129,0)] 		public CArray<SAnimationBufferBitwiseCompressedBoneTrack> Bones { get; set;}

		[RED("tracks", 129,0)] 		public CArray<SAnimationBufferBitwiseCompressedData> Tracks { get; set;}

		[RED("data", 129,0)] 		public CByteArray Data { get; set;}

		[RED("fallbackData", 129,0)] 		public CByteArray FallbackData { get; set;}

		[RED("deferredData")] 		public DeferredDataBuffer DeferredData { get; set;}

		[RED("orientationCompressionMethod")] 		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set;}

		[RED("duration")] 		public CFloat Duration { get; set;}

		[RED("numFrames")] 		public CUInt32 NumFrames { get; set;}

		[RED("dt")] 		public CFloat Dt { get; set;}

		[RED("streamingOption")] 		public CEnum<SAnimationBufferStreamingOption> StreamingOption { get; set;}

		[RED("nonStreamableBones")] 		public CUInt32 NonStreamableBones { get; set;}

		[RED("hasRefIKBones")] 		public CBool HasRefIKBones { get; set;}

		public CAnimationBufferBitwiseCompressed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimationBufferBitwiseCompressed(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}