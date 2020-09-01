using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public partial class CEnvProbeComponent : CComponent
	{
		[Ordinal(1)] [RED("contribution")] 		public CFloat Contribution { get; set;}

		[Ordinal(2)] [RED("nestingLevel")] 		public CUInt32 NestingLevel { get; set;}

		[Ordinal(3)] [RED("effectIntensity")] 		public CFloat EffectIntensity { get; set;}

		[Ordinal(4)] [RED("areaMarginFactor")] 		public Vector AreaMarginFactor { get; set;}

		[Ordinal(5)] [RED("areaDisplace")] 		public Vector AreaDisplace { get; set;}

		[Ordinal(6)] [RED("isParallaxCorrected")] 		public CBool IsParallaxCorrected { get; set;}

		[Ordinal(7)] [RED("parallaxTransform")] 		public EngineTransform ParallaxTransform { get; set;}

		[Ordinal(8)] [RED("genParams")] 		public SEnvProbeGenParams GenParams { get; set;}

		[Ordinal(9)] [RED("textureCacheHashes", 4)] 		public CStatic<CUInt32> TextureCacheHashes { get; set;}

		public CEnvProbeComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvProbeComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}