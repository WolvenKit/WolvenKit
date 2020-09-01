using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvRadialBlurParameters : CVariable
	{
		[Ordinal(1)] [RED("("radialBlurSource")] 		public Vector RadialBlurSource { get; set;}

		[Ordinal(2)] [RED("("radialBlurAmount")] 		public CFloat RadialBlurAmount { get; set;}

		[Ordinal(3)] [RED("("sineWaveAmount")] 		public CFloat SineWaveAmount { get; set;}

		[Ordinal(4)] [RED("("sineWaveSpeed")] 		public CFloat SineWaveSpeed { get; set;}

		[Ordinal(5)] [RED("("sineWaveFreq")] 		public CFloat SineWaveFreq { get; set;}

		[Ordinal(6)] [RED("("centerMultiplier")] 		public CFloat CenterMultiplier { get; set;}

		[Ordinal(7)] [RED("("distance")] 		public CFloat Distance { get; set;}

		public CEnvRadialBlurParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvRadialBlurParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}