using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvWaterParameters : CVariable
	{
		[Ordinal(0)] [RED("("activated")] 		public CBool Activated { get; set;}

		[Ordinal(0)] [RED("("waterFlowIntensity")] 		public SSimpleCurve WaterFlowIntensity { get; set;}

		[Ordinal(0)] [RED("("underwaterBrightness")] 		public SSimpleCurve UnderwaterBrightness { get; set;}

		[Ordinal(0)] [RED("("underWaterFogIntensity")] 		public SSimpleCurve UnderWaterFogIntensity { get; set;}

		[Ordinal(0)] [RED("("waterColor")] 		public SSimpleCurve WaterColor { get; set;}

		[Ordinal(0)] [RED("("underWaterColor")] 		public SSimpleCurve UnderWaterColor { get; set;}

		[Ordinal(0)] [RED("("waterFresnel")] 		public SSimpleCurve WaterFresnel { get; set;}

		[Ordinal(0)] [RED("("waterCaustics")] 		public SSimpleCurve WaterCaustics { get; set;}

		[Ordinal(0)] [RED("("waterFoamIntensity")] 		public SSimpleCurve WaterFoamIntensity { get; set;}

		[Ordinal(0)] [RED("("waterAmbientScale")] 		public SSimpleCurve WaterAmbientScale { get; set;}

		[Ordinal(0)] [RED("("waterDiffuseScale")] 		public SSimpleCurve WaterDiffuseScale { get; set;}

		public CEnvWaterParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvWaterParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}