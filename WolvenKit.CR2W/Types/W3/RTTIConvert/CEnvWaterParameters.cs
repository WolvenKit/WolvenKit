using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CEnvWaterParameters : CVariable
	{
		[Ordinal(1)] [RED("activated")] 		public CBool Activated { get; set;}

		[Ordinal(2)] [RED("waterFlowIntensity")] 		public SSimpleCurve WaterFlowIntensity { get; set;}

		[Ordinal(3)] [RED("underwaterBrightness")] 		public SSimpleCurve UnderwaterBrightness { get; set;}

		[Ordinal(4)] [RED("underWaterFogIntensity")] 		public SSimpleCurve UnderWaterFogIntensity { get; set;}

		[Ordinal(5)] [RED("waterColor")] 		public SSimpleCurve WaterColor { get; set;}

		[Ordinal(6)] [RED("underWaterColor")] 		public SSimpleCurve UnderWaterColor { get; set;}

		[Ordinal(7)] [RED("waterFresnel")] 		public SSimpleCurve WaterFresnel { get; set;}

		[Ordinal(8)] [RED("waterCaustics")] 		public SSimpleCurve WaterCaustics { get; set;}

		[Ordinal(9)] [RED("waterFoamIntensity")] 		public SSimpleCurve WaterFoamIntensity { get; set;}

		[Ordinal(10)] [RED("waterAmbientScale")] 		public SSimpleCurve WaterAmbientScale { get; set;}

		[Ordinal(11)] [RED("waterDiffuseScale")] 		public SSimpleCurve WaterDiffuseScale { get; set;}

		public CEnvWaterParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CEnvWaterParameters(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}