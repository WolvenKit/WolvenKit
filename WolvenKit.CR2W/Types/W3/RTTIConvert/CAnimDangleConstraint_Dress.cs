using System.IO;using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Dress : CAnimSkeletalDangleConstraint
	{
		[RED("thighBoneWeight")] 		public CFloat ThighBoneWeight { get; set;}

		[RED("shinBoneWeight")] 		public CFloat ShinBoneWeight { get; set;}

		[RED("kneeRollBoneWeight")] 		public CFloat KneeRollBoneWeight { get; set;}

		[RED("ofweight")] 		public CFloat Ofweight { get; set;}

		[RED("p1")] 		public Vector P1 { get; set;}

		[RED("p2")] 		public Vector P2 { get; set;}

		[RED("p3")] 		public Vector P3 { get; set;}

		[RED("r1")] 		public Vector R1 { get; set;}

		[RED("r2")] 		public Vector R2 { get; set;}

		[RED("r3")] 		public Vector R3 { get; set;}

		public CAnimDangleConstraint_Dress(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CAnimDangleConstraint_Dress(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}