using System.IO;
using System.Runtime.Serialization;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;


namespace WolvenKit.CR2W.Types
{
	[DataContract(Namespace = "")]
	[REDMeta]
	public class Quad : CVariable
	{
		[Ordinal(1)] [RED("p1")] 		public Vector P1 { get; set;}

		[Ordinal(2)] [RED("p2")] 		public Vector P2 { get; set;}

		[Ordinal(3)] [RED("p3")] 		public Vector P3 { get; set;}

		[Ordinal(4)] [RED("p4")] 		public Vector P4 { get; set;}

		public Quad(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name){ }

		public static CVariable Create(CR2WFile cr2w, CVariable parent, string name) => new Quad(cr2w, parent, name);

		public override void Read(BinaryReader file, uint size) => base.Read(file, size);

		public override void Write(BinaryWriter file) => base.Write(file);

	}
}