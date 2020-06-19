using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHorseStateOffsets : CVariable
	{
		[RED("speedValue")] 		public CFloat SpeedValue { get; set;}

		[RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[RED("legFY")] 		public CFloat LegFY { get; set;}

		[RED("legFZ")] 		public CFloat LegFZ { get; set;}

		[RED("legBY")] 		public CFloat LegBY { get; set;}

		[RED("legBZ")] 		public CFloat LegBZ { get; set;}

		[RED("pelvisY")] 		public CFloat PelvisY { get; set;}

		[RED("pelvisZ")] 		public CFloat PelvisZ { get; set;}

		[RED("headFirstAngle")] 		public CFloat HeadFirstAngle { get; set;}

		[RED("headSecondAngle")] 		public CFloat HeadSecondAngle { get; set;}

		[RED("headThirdAngle")] 		public CFloat HeadThirdAngle { get; set;}

		public SHorseStateOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public override CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SHorseStateOffsets(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}