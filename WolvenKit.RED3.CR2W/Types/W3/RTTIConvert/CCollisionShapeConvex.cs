using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCollisionShapeConvex : ICollisionShape
	{
		[Ordinal(1)] [RED("physicalMaterialName")] 		public CName PhysicalMaterialName { get; set;}

		[Ordinal(2)] [RED("vertices", 94,0)] 		public CArray<Vector> Vertices { get; set;}

		[Ordinal(3)] [RED("planes", 94,0)] 		public CArray<Vector> Planes { get; set;}

		[Ordinal(4)] [RED("polygons", 94,0)] 		public CArray<CUInt16> Polygons { get; set;}

		public CCollisionShapeConvex(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}