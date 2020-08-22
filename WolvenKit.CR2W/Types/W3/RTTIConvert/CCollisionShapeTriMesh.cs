using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class CCollisionShapeTriMesh : ICollisionShape
	{
		[RED("physicalMaterialNames", 94,0)] 		public CArray<CName> PhysicalMaterialNames { get; set;}

		[RED("vertices", 94,0)] 		public CArray<Vector> Vertices { get; set;}

		[RED("triangles", 94,0)] 		public CArray<CUInt16> Triangles { get; set;}

		[RED("physicalMaterialIndexes", 94,0)] 		public CArray<CUInt16> PhysicalMaterialIndexes { get; set;}

		public CCollisionShapeTriMesh(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static new CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new CCollisionShapeTriMesh(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}