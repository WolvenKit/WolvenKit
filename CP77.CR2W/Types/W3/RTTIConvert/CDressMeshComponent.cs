using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CDressMeshComponent : CMeshComponent
	{
		[Ordinal(1)] [RED("skeleton")] 		public CHandle<CSkeleton> Skeleton { get; set;}

		[Ordinal(2)] [RED("thighBoneWeight")] 		public CFloat ThighBoneWeight { get; set;}

		[Ordinal(3)] [RED("shinBoneWeight")] 		public CFloat ShinBoneWeight { get; set;}

		[Ordinal(4)] [RED("kneeRollBoneWeight")] 		public CFloat KneeRollBoneWeight { get; set;}

		[Ordinal(5)] [RED("ofweight")] 		public CFloat Ofweight { get; set;}

		[Ordinal(6)] [RED("p1")] 		public Vector P1 { get; set;}

		[Ordinal(7)] [RED("p2")] 		public Vector P2 { get; set;}

		[Ordinal(8)] [RED("p3")] 		public Vector P3 { get; set;}

		[Ordinal(9)] [RED("r1")] 		public Vector R1 { get; set;}

		[Ordinal(10)] [RED("r2")] 		public Vector R2 { get; set;}

		[Ordinal(11)] [RED("r3")] 		public Vector R3 { get; set;}

		public CDressMeshComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CDressMeshComponent(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}