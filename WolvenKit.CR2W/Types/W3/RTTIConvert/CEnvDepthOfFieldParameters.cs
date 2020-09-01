using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvDepthOfFieldParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("nearBlurDist")] 		public SSimpleCurve NearBlurDist { get; set;}

		[Ordinal(0)] [RED("("nearFocusDist")] 		public SSimpleCurve NearFocusDist { get; set;}

		[Ordinal(0)] [RED("("farFocusDist")] 		public SSimpleCurve FarFocusDist { get; set;}

		[Ordinal(0)] [RED("("farBlurDist")] 		public SSimpleCurve FarBlurDist { get; set;}

		[Ordinal(0)] [RED("("intensity")] 		public SSimpleCurve Intensity { get; set;}

		[Ordinal(0)] [RED("("activatedSkyThreshold")] 		public CBool ActivatedSkyThreshold { get; set;}

		[Ordinal(0)] [RED("("skyThreshold")] 		public CFloat SkyThreshold { get; set;}

		[Ordinal(0)] [RED("("activatedSkyRange")] 		public CBool ActivatedSkyRange { get; set;}

		[Ordinal(0)] [RED("("skyRange")] 		public CFloat SkyRange { get; set;}

		public CEnvDepthOfFieldParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvDepthOfFieldParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}