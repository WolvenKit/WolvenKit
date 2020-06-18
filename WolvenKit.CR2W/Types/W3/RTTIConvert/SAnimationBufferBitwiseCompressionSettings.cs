using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationBufferBitwiseCompressionSettings : CVariable
	{
		[RED("translationTolerance")] 		public CFloat TranslationTolerance { get; set;}

		[RED("translationSkipFrameTolerance")] 		public CFloat TranslationSkipFrameTolerance { get; set;}

		[RED("orientationTolerance")] 		public CFloat OrientationTolerance { get; set;}

		[RED("orientationCompressionMethod")] 		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set;}

		[RED("orientationSkipFrameTolerance")] 		public CFloat OrientationSkipFrameTolerance { get; set;}

		[RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[RED("scaleSkipFrameTolerance")] 		public CFloat ScaleSkipFrameTolerance { get; set;}

		[RED("trackTolerance")] 		public CFloat TrackTolerance { get; set;}

		[RED("trackSkipFrameTolerance")] 		public CFloat TrackSkipFrameTolerance { get; set;}

		public SAnimationBufferBitwiseCompressionSettings(CR2WFile cr2w) : base(cr2w){ }

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

		public override CVariable Create(CR2WFile cr2w) => new SAnimationBufferBitwiseCompressionSettings(cr2w);

	}
}