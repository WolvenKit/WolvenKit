using System.IO;
using System.Runtime.Serialization;
using WolvenKit.RED3.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED3.CR2W.Types.Enums;


namespace WolvenKit.RED3.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCollisionShapeTriMesh : ICollisionShape
	{
		[Ordinal(1)] [RED("physicalMaterialNames", 94,0)] 		public CArray<CName> PhysicalMaterialNames { get; set;}

		[Ordinal(2)] [RED("vertices", 94,0)] 		public CArray<Vector> Vertices { get; set;}

		[Ordinal(3)] [RED("triangles", 94,0)] 		public CArray<CUInt16> Triangles { get; set;}

		[Ordinal(4)] [RED("physicalMaterialIndexes", 94,0)] 		public CArray<CUInt16> PhysicalMaterialIndexes { get; set;}

		public CCollisionShapeTriMesh(IRed3EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCollisionShapeTriMesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}