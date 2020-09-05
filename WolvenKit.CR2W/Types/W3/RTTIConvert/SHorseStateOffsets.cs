using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class SHorseStateOffsets : CVariable
	{
		[Ordinal(1)] [RED("speedValue")] 		public CFloat SpeedValue { get; set;}

		[Ordinal(2)] [RED("maxValue")] 		public CFloat MaxValue { get; set;}

		[Ordinal(3)] [RED("legFY")] 		public CFloat LegFY { get; set;}

		[Ordinal(4)] [RED("legFZ")] 		public CFloat LegFZ { get; set;}

		[Ordinal(5)] [RED("legBY")] 		public CFloat LegBY { get; set;}

		[Ordinal(6)] [RED("legBZ")] 		public CFloat LegBZ { get; set;}

		[Ordinal(7)] [RED("pelvisY")] 		public CFloat PelvisY { get; set;}

		[Ordinal(8)] [RED("pelvisZ")] 		public CFloat PelvisZ { get; set;}

		[Ordinal(9)] [RED("headFirstAngle")] 		public CFloat HeadFirstAngle { get; set;}

		[Ordinal(10)] [RED("headSecondAngle")] 		public CFloat HeadSecondAngle { get; set;}

		[Ordinal(11)] [RED("headThirdAngle")] 		public CFloat HeadThirdAngle { get; set;}

		public SHorseStateOffsets(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new SHorseStateOffsets(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}