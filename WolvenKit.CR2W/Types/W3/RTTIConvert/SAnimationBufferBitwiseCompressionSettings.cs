using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationBufferBitwiseCompressionSettings : CVariable
	{
		[Ordinal(0)] [RED("translationTolerance")] 		public CFloat TranslationTolerance { get; set;}

		[Ordinal(0)] [RED("translationSkipFrameTolerance")] 		public CFloat TranslationSkipFrameTolerance { get; set;}

		[Ordinal(0)] [RED("orientationTolerance")] 		public CFloat OrientationTolerance { get; set;}

		[Ordinal(0)] [RED("orientationCompressionMethod")] 		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set;}

		[Ordinal(0)] [RED("orientationSkipFrameTolerance")] 		public CFloat OrientationSkipFrameTolerance { get; set;}

		[Ordinal(0)] [RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[Ordinal(0)] [RED("scaleSkipFrameTolerance")] 		public CFloat ScaleSkipFrameTolerance { get; set;}

		[Ordinal(0)] [RED("trackTolerance")] 		public CFloat TrackTolerance { get; set;}

		[Ordinal(0)] [RED("trackSkipFrameTolerance")] 		public CFloat TrackSkipFrameTolerance { get; set;}

		public SAnimationBufferBitwiseCompressionSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationBufferBitwiseCompressionSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}