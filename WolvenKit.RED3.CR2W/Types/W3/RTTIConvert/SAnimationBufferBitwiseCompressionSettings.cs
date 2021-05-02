using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SAnimationBufferBitwiseCompressionSettings : CVariable
	{
		[Ordinal(1)] [RED("translationTolerance")] 		public CFloat TranslationTolerance { get; set;}

		[Ordinal(2)] [RED("translationSkipFrameTolerance")] 		public CFloat TranslationSkipFrameTolerance { get; set;}

		[Ordinal(3)] [RED("orientationTolerance")] 		public CFloat OrientationTolerance { get; set;}

		[Ordinal(4)] [RED("orientationCompressionMethod")] 		public CEnum<SAnimationBufferOrientationCompressionMethod> OrientationCompressionMethod { get; set;}

		[Ordinal(5)] [RED("orientationSkipFrameTolerance")] 		public CFloat OrientationSkipFrameTolerance { get; set;}

		[Ordinal(6)] [RED("scaleTolerance")] 		public CFloat ScaleTolerance { get; set;}

		[Ordinal(7)] [RED("scaleSkipFrameTolerance")] 		public CFloat ScaleSkipFrameTolerance { get; set;}

		[Ordinal(8)] [RED("trackTolerance")] 		public CFloat TrackTolerance { get; set;}

		[Ordinal(9)] [RED("trackSkipFrameTolerance")] 		public CFloat TrackSkipFrameTolerance { get; set;}

		public SAnimationBufferBitwiseCompressionSettings(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SAnimationBufferBitwiseCompressionSettings(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}