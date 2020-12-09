using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Tetrahedron : CVariable
	{
		[Ordinal(1)] [RED("point1")] 		public Vector Point1 { get; set;}

		[Ordinal(2)] [RED("point2")] 		public Vector Point2 { get; set;}

		[Ordinal(3)] [RED("point3")] 		public Vector Point3 { get; set;}

		[Ordinal(4)] [RED("point4")] 		public Vector Point4 { get; set;}

		public Tetrahedron(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Tetrahedron(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}