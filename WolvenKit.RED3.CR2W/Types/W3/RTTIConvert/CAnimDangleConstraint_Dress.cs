using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CAnimDangleConstraint_Dress : CAnimSkeletalDangleConstraint
	{
		[Ordinal(1)] [RED("thighBoneWeight")] 		public CFloat ThighBoneWeight { get; set;}

		[Ordinal(2)] [RED("shinBoneWeight")] 		public CFloat ShinBoneWeight { get; set;}

		[Ordinal(3)] [RED("kneeRollBoneWeight")] 		public CFloat KneeRollBoneWeight { get; set;}

		[Ordinal(4)] [RED("ofweight")] 		public CFloat Ofweight { get; set;}

		[Ordinal(5)] [RED("p1")] 		public Vector P1 { get; set;}

		[Ordinal(6)] [RED("p2")] 		public Vector P2 { get; set;}

		[Ordinal(7)] [RED("p3")] 		public Vector P3 { get; set;}

		[Ordinal(8)] [RED("r1")] 		public Vector R1 { get; set;}

		[Ordinal(9)] [RED("r2")] 		public Vector R2 { get; set;}

		[Ordinal(10)] [RED("r3")] 		public Vector R3 { get; set;}

		public CAnimDangleConstraint_Dress(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}